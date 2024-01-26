using System.Xml.Linq;

namespace ArchiveManager {
	internal class Repository() {

		private RepoListItem m_info;
		private Dictionary<string, string> m_streamList = []; // [Name, Path]
		private string m_leader = "";

		private Dictionary<string, DateTime> m_leaderStorage = []; // [Path, Time]
		private Dictionary<string, DateTime> m_leaderRealtime = []; // [Path, Time]

		private string m_myDir = "";

		private bool m_available = false;

		public void Clear() {
			m_available = false;
			m_info = new();
			m_streamList.Clear();
			m_leader = "";
			m_leaderStorage.Clear();
			m_leaderRealtime.Clear();
			m_myDir = "";
		}

		public bool Load(RepoListItem item) {
			Clear();
			m_info = item;
			try {
				m_myDir = Path.Combine(Attribute0.Default.RepoDirectory, m_info.guid.ToString());
				var doc = XDocument.Load(Path.Combine(m_myDir, Attribute0.Default.RepoFileName));

				if (doc.Root == null)
					return false;
				var root = doc.Root;

				var lead = root.Attribute(Attribute0.Default.LeaderNote);
				if (lead == null)
					return false;
				m_leader = lead.Value;

				foreach (var st in root.Elements(Attribute0.Default.StreamNote)) {
					var name = st.Attribute(Attribute0.Default.NameNote)?.Value;
					var path = st.Attribute(Attribute0.Default.PathNote)?.Value;
					if (path != null && name != null) {
						m_streamList.Add(name, path);
					}
				}

				if (!m_streamList.ContainsKey(m_leader))
					return false;
			}
			catch {
				return false;
			}
			m_available = true;
			if (LoadStorage(m_leader, out m_leaderStorage)) {
				return true;
			}
			m_available = false;
			return false;
		}

		public void Save() {
			if (!m_available)
				return;
			var doc = new XDocument(
				new XElement(Attribute0.Default.RepoNote,
					new XAttribute(Attribute0.Default.VersionNote, Attribute0.Default.RepoVersion),
					new XAttribute(Attribute0.Default.TimeNote, DateTime.UtcNow.ToString()),
					new XAttribute(Attribute0.Default.LeaderNote, m_leader),
					m_streamList.Select(
						repo => new XElement(Attribute0.Default.StreamNote,
							new XAttribute(Attribute0.Default.NameNote, repo.Key),
							new XAttribute(Attribute0.Default.PathNote, repo.Value)
						)
					)
				)
			);
			doc.Save(Path.Combine(m_myDir, Attribute0.Default.RepoFileName));
		}

		public void Rename(string newname) {
			if (!m_available)
				return;
			RepoListItem item = new(m_info.guid, newname);
			RepoList.Remove(m_info);
			RepoList.Add(item);
			m_info = item;
		}

		public void RenameStream(string oldname, string newname) {
			if (!m_available)
				return;
			if (m_streamList.TryGetValue(oldname, out string? path)) {
				m_streamList.Remove(oldname);
				m_streamList.TryAdd(newname, path);
			}
			if (m_leader == oldname) {
				m_leader = newname;
			}
		}

		public Guid GetGuid() {
			if (!m_available)
				return new();
			return m_info.guid;
		}

		public string GetLeaderName() {
			if (!m_available)
				return "";
			return m_leader;
		}

		public List<string> GetFollowersName() {
			if (!m_available)
				return [];
			Dictionary<string, string> l = new(m_streamList);
			l.Remove(m_leader);
			return [.. l.Keys];
		}

		public bool LoadStorage(string name, out Dictionary<string, DateTime> list) {
			list = [];
			if (!m_available)
				return false;
			try {
				if (!m_streamList.TryGetValue(name, out var filepath)) {
					return false;
				}
				var doc = XDocument.Load(Path.Combine(filepath, Attribute0.Default.StreamInfoFile));
				var root = doc.Root;
				if (root == null) {
					return false;
				}
				foreach (var e in root.Elements()) {
					var path = e.Attribute(Attribute0.Default.PathNote)?.Value;
					var tick = e.Attribute(Attribute0.Default.TimeNote);
					if (path == null || tick == null) {
						return false;
					}
					list.Add(path, new((long)tick));
				}
			}
			catch {
				return false;
			}
			return true;
		}

		public void SaveStorage(string name, in Dictionary<string, DateTime> list) {
			if (!m_available)
				return;
			if (!m_streamList.TryGetValue(name, out var filepath)) {
				return;
			}
			var doc = new XDocument(
				new XElement(Attribute0.Default.StreamNote,
					new XAttribute(Attribute0.Default.VersionNote, Attribute0.Default.StreamVersion),
					new XAttribute(Attribute0.Default.TimeNote, DateTime.UtcNow.ToString()),
					new XAttribute(Attribute0.Default.NameNote, name),
					list.Select(
						f => new XElement("F",
							new XAttribute(Attribute0.Default.PathNote, f.Key),
							new XAttribute(Attribute0.Default.TimeNote, f.Value.Ticks)
						)
					)
				)
			);
			doc.Save(Path.Combine(filepath, Attribute0.Default.StreamInfoFile));
		}

		public bool GetFileMap(string name, out Dictionary<string, DateTime> list) {
			list = [];
			if (!m_available)
				return false;
			try {
				if (!m_streamList.TryGetValue(name, out string? path))
					return false;
				var directory = new DirectoryInfo(path);
				var files = directory.GetFiles("", SearchOption.AllDirectories);
				foreach (var x in files) {
					list.Add(Path.GetRelativePath(path, x.FullName), x.LastWriteTimeUtc);
				}
				list.Remove(Attribute0.Default.StreamInfoFile);
			}
			catch {
				return false;
			}
			return true;
		}

		public bool RefreshRealtimeMap() {
			if (!m_available)
				return false;
			if (!GetFileMap(m_leader, out var newmap))
				return false;
			m_leaderRealtime = newmap;
			return true;
		}

		public List<FileChange> GetLeaderChanges() {
			if (!m_available)
				return [];
			return CompareMap(m_leaderStorage, m_leaderRealtime);
		}

		public void Replicate(List<string> targetStreams) {
			if (!m_available)
				return;
			RefreshRealtimeMap();
			if (targetStreams.Count <= 0)
				return;
			SaveStorage(m_leader, m_leaderRealtime);
			m_leaderStorage = new(m_leaderRealtime);

			//GUI.test?.AddText("TEST");

			if (!m_streamList.TryGetValue(m_leader, out var srcDir)) {
				return;
			}
			foreach (var stream in targetStreams) {
				if (!m_streamList.TryGetValue(stream, out var dstDir)) {
					continue;
				}

				//GUI.test?.AddText(stream);

				if (!LoadStorage(stream, out var targetStorage)) {
					continue;
				}
				var diff = CompareMap(targetStorage, m_leaderRealtime);

				bool success = true;
				//string str = "";
				foreach (var change in diff) {
					try {
						//str += change.type.ToString() + " " + change.path + "\n\r";
						string dstFile = Path.Combine(dstDir, change.path);
						switch (change.type) {
						case FileChange.Type.Add:
						case FileChange.Type.Modified:
							string? dstFolder = Path.GetDirectoryName(dstFile);
							if (dstFolder != null && !Directory.Exists(dstFolder))
								Directory.CreateDirectory(dstFolder);
							File.Copy(
								Path.Combine(srcDir, change.path),
								dstFile,
								true
							);
							break;
						case FileChange.Type.Deleted:
							if (File.Exists(dstFile))
								File.Delete(
									dstFile
								);
							break;
						}
					}
					catch {
						success = false;
						break;
					}
				}
				//MessageBox.Show(str);

				if (success)
					SaveStorage(stream, m_leaderRealtime);
			}

			//Thread.Sleep(5000);

			//GUI.test?.UseOver();
		}

		public static List<FileChange> CompareMap(
			Dictionary<string, DateTime> old1,
			Dictionary<string, DateTime> new1) {
			var com = new1.IntersectBy(old1.Keys, x => x.Key);
			var add = new1.ExceptBy(old1.Keys, x => x.Key);
			var del = old1.ExceptBy(new1.Keys, x => x.Key);
			List<FileChange> res = [];
			foreach (var k in com) {
				if (k.Value > old1.GetValueOrDefault(k.Key)) {
					res.Add(new(FileChange.Type.Modified, k.Key));
				}
			}
			foreach (var k in add) {
				res.Add(new(FileChange.Type.Add, k.Key));
			}
			foreach (var k in del) {
				res.Add(new(FileChange.Type.Deleted, k.Key));
			}
			return res;
		}

		public void KillEmptyDirectory(string stream) {
			if (!m_streamList.TryGetValue(stream, out var dstDir)) {
				return;
			}
			DirectoryInfo dir = new(dstDir);
			var subdirs = dir.GetDirectories("", SearchOption.AllDirectories);
			foreach (var subdir in subdirs) {
				if (subdir.GetFileSystemInfos().Length == 0) {
					subdir.Delete();
				}
			}
		}

	}
}

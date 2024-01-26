using System.Xml.Linq;

namespace ArchiveManager {
	internal class Repository() {

		private RepoListItem m_info;
		private Dictionary<string, string> m_streamList = [];
		private string m_leader = "";

		public void Clear() {
			m_info = new();
			m_streamList.Clear();
			m_leader = "";
		}

		public bool Load(RepoListItem item) {
			Clear();
			m_info = item;
			try {
				var doc = XDocument.Load(
					Path.Combine(
						Attribute0.Default.RepoDirectory,
						m_info.guid.ToString() + Attribute0.Default.RepoFileExname
					)
				);

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
			return true;
		}

		public void Save() {
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
			doc.Save(
				Path.Combine(
					Attribute0.Default.RepoDirectory,
					m_info.guid.ToString() + Attribute0.Default.RepoFileExname
				)
			);
		}

		public void Rename(string newname) {
			RepoListItem item = new(m_info.guid, newname);
			RepoList.Remove(m_info);
			RepoList.Add(item);
			m_info = item;
		}

		public void RenameStream(string oldname, string newname) {
			if (m_streamList.TryGetValue(oldname, out string? path)) {
				m_streamList.Remove(oldname);
				m_streamList.TryAdd(newname, path);
			}
			if (m_leader == oldname) {
				m_leader = newname;
			}
		}

		public Guid GetGuid() {
			return m_info.guid;
		}

		public string GetLeaderName() {
			return m_leader;
		}

		public List<string> GetFollowersName() {
			Dictionary<string, string> l = new(m_streamList);
			l.Remove(m_leader);
			return [.. l.Keys];
		}

	}
}

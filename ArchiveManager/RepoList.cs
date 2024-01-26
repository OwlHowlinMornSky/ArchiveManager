using System.Xml.Linq;

namespace ArchiveManager {
	internal static class RepoList {

		//public static List<RepoListItem> repoList = [];
		private static Dictionary<Guid, RepoListItem> repoList = [];
		public static readonly string repoListVersion = "1.0";

		public static bool Add(RepoListItem repository) {
			return repoList.TryAdd(repository.guid, repository);
		}

		public static bool Remove(RepoListItem repo) {
			return repoList.Remove(repo.guid);
		}

		public static bool Remove(Guid guid) {
			return repoList.Remove(guid);
		}

		public static bool Get(Guid guid, out RepoListItem value) {
			return repoList.TryGetValue(guid, out value);
		}

		public static List<RepoListItem> GetAll() {
			return repoList.Select(pair => pair.Value).ToList();
		}

		public static void Load() {
			try {
				var doc = XDocument.Load("Repos.xml");
				var root = doc.Root;
				if (root != null) {
					foreach (var item in root.Elements()) {
						var guid = item.Attribute("Guid");
						var name = item.Attribute("Name");
						if (guid != null && name != null) {
							repoList.Add((Guid)guid, new RepoListItem((Guid)guid, (string)name));
						}
					}
				}
			}
			catch {
				//
			}
		}

		public static void Save() {
			var doc = new XDocument(
							new XElement("Repos",
								new XAttribute("Version", repoListVersion),
								new XAttribute("UTC", DateTime.UtcNow.ToString("s")),
								repoList.Select(
									repo => new XElement("Repo",
										new XAttribute("Guid", repo.Value.guid),
										new XAttribute("Name", repo.Value.name)
									)
								)
							)
						);
			doc.Save("Repos.xml");
		}

	}
}

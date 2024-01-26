/*
*    Archive Manager
*
*    Copyright (C) 2023-2024  Tyler Parret True
*
*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU Affero General Public License as published
*    by the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.
*
*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU Affero General Public License for more details.
*
*    You should have received a copy of the GNU Affero General Public License
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*
* @Authors
*    Tyler Parret True <mysteryworldgod@outlook.com><https://github.com/OwlHowlinMornSky>
*/
using System.Xml.Linq;

namespace ArchiveManager {
	internal static class RepoList {

		private static Dictionary<Guid, RepoListItem> repoList = [];

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
				var doc = XDocument.Load(Path.Combine(Attribute0.Default.RepoDirectory, Attribute0.Default.ListFileName));
				var root = doc.Root;
				if (root != null) {
					foreach (var item in root.Elements()) {
						var guid = item.Attribute(Attribute0.Default.GuidNote);
						var name = item.Attribute(Attribute0.Default.NameNote)?.Value;
						if (guid != null && name != null) {
							repoList.Add((Guid)guid, new RepoListItem((Guid)guid, name));
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
				new XElement(Attribute0.Default.ListRootNote,
					new XAttribute(Attribute0.Default.VersionNote, Attribute0.Default.ListVersion),
					new XAttribute(Attribute0.Default.TimeNote, DateTime.UtcNow.ToString()),
					repoList.Select(
						repo => new XElement(Attribute0.Default.RepoNote,
							new XAttribute(Attribute0.Default.GuidNote, repo.Value.guid.ToString()),
							new XAttribute(Attribute0.Default.NameNote, repo.Value.name)
						)
					)
				)
			);
			doc.Save(Path.Combine(Attribute0.Default.RepoDirectory, Attribute0.Default.ListFileName));
		}

	}
}

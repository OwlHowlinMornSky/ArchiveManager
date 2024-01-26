namespace ArchiveManager {
	internal struct RepoListItem(Guid _guid, string _name = "") {
		public readonly Guid guid = _guid;
		public string name = _name;
	}
}

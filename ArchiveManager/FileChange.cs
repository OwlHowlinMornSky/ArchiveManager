namespace ArchiveManager {
	internal readonly struct FileChange(FileChange.Type _type, string _path) {
		public enum Type {
			Unknown = 0,
			Add,
			Modified,
			Deleted
		}

		public readonly Type type = _type;
		public readonly string path = _path;

	}
}

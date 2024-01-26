namespace ArchiveManager {
	internal struct StreamFrame() {
		public enum Type {
			Unknown = 0,
			Replicate,
			Commit,
			COUNT
		}
		public Type type;
		public DateTime time;
		public Guid guid;
		public string title = "";
		public string description = "";
	}
}

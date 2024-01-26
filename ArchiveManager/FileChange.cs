using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManager {
	internal readonly struct FileChange(string _path, FileChange.Type _type) {
		public enum Type {
			Unknown = 0,
			Add,
			Modified,
			Deleted
		}
		public readonly string path = _path;
		public readonly Type type = _type;
	}
}

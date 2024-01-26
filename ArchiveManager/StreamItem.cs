using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManager {
	internal struct StreamItem(string _name, string _path) {
		public string name = _name;
		public string path = _path;
	}
}

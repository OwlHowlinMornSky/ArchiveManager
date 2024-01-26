using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManager {
	internal class Stream(StreamItem item) {
		private StreamItem m_info = item;
		public List<StreamFrame> m_frames = [];

		public bool Load() {


			return false;
		}

		public void Rename(string newname) {
			m_info.name = newname;
		}

		public string GetName() {
			return m_info.name;
		}

		public static List<FileChange> ComputeChanges(StreamFrame frame1, StreamFrame frame2) {
			List<FileChange> res = [];

			//List<FileItem> files = [];


			return res;
		}

	}
}

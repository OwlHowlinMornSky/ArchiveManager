using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManager {
	internal class Repository() {

		private RepoListItem m_info;
		private List<StreamItem> m_streamList = [];
		private string m_default = "";
		private string m_current = "";
		private Stream? m_stream;

		public bool Load(RepoListItem item) {
			return false;
		}

		public void Save() {
		}

		public void Rename(string newname) {
			RepoListItem item = new(m_info.guid, newname);
			RepoList.Remove(m_info);
			RepoList.Add(item);
			m_info = item;
		}

		public void RenameStream(string oldname, string newname) {
		}

		public bool SelectStream(string name) {
			if (!m_streamList.Exists(s => s.name == name))
				return false;
			var item = m_streamList.Find(s => s.name == name);
			m_stream = new Stream(item);
			return m_stream.Load();
		}

		public Guid GetGuid() {
			return m_info.guid;
		}

	}
}

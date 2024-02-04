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

namespace ArchiveManager {
	/// <summary>
	/// 一项文件变动
	/// </summary>
	/// <param name="_type">变动类型</param>
	/// <param name="_path">相对路径</param>
	internal readonly struct FileChange(FileChange.Type _type, string _path) {
		public enum Type {
			Unknown = 0, // 空
			Add,         // 文件被新建
			Modified,    // 文件有修改
			Deleted      // 文件被删除
		}

		public readonly Type type = _type;
		public readonly string path = _path; // 变动的文件路径（相对于流目录）。

	}
}

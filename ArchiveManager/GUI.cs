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

using static System.Net.Mime.MediaTypeNames;

namespace ArchiveManager {
	internal static class GUI {

		internal static FormTest? test;

		/// <summary>
		/// 当前选中的仓库。
		/// </summary>
		internal static Guid repoSelected;
		/// <summary>
		/// 主ui使用的实例。
		/// </summary>
		internal static Repository repo = new();

		/// <summary>
		/// 检查流名称，修改为替换的串。
		/// </summary>
		/// <param name="name">输入的名称</param>
		/// <param name="res">输出的名称</param>
		/// <returns>是否有更改</returns>
		internal static bool CheckStreamName(string name, out string res) {
			HashSet<char> invalidChars = [];
			for (int i = 0, n = name.Length; i < n; ++i) {
				char c = name[i];
				if (!(('A' <= c && c <= 'Z') || ('a' <= c && c <= 'z') || ('0' <= c && c <= '9') || c == '_' || c == '-')) {
					invalidChars.Add(c);
				}
			}
			if (invalidChars.Count > 0) {
				res = name;
				foreach (char c in invalidChars) {
					res = res.Replace(c, '-');
				}
				return true;
			}
			res = name;
			return false;
		}

	}
}

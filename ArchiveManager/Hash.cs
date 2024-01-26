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
using System.Security.Cryptography;
using System.Text;

namespace ArchiveManager {
	internal static class Hash {

		static readonly HashAlgorithm hash = MD5.Create();

		public static string? GetHashOfFile(string filePath) {
			string? fileMd5 = null;
			try {
				using FileStream? fileStream = File.OpenRead(filePath);
				byte[] fileMD5Bytes = hash.ComputeHash(fileStream);
				fileMd5 = BitConverter.ToString(fileMD5Bytes).Replace("-", "");
			}
			catch {
				//
			}
			return fileMd5;
		}

		public static string? GetHashOfString(string str) {
			string? strMd5 = null;
			try {
				byte[] md5bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(str));
				strMd5 = BitConverter.ToString(md5bytes).Replace("-", "");
			}
			catch {
				//
			}
			return strMd5;
		}

	}
}

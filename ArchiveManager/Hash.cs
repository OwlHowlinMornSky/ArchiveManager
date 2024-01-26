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

using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace ArchiveManager {
	internal static class Hash {

		static HashAlgorithm hash = MD5.Create();

		public enum Algorithm {
			MD5 = 0,
			SHA1, SHA256, SHA384, SHA512,
			COUNT
		}

		public static void ChangeAlgorithm(Algorithm algorithm) {
			switch (algorithm) {
			case Algorithm.MD5:
				hash = MD5.Create();
				break;
			case Algorithm.SHA1:
				hash = SHA1.Create();
				break;
			case Algorithm.SHA256:
				hash = SHA256.Create();
				break;
			case Algorithm.SHA384:
				hash = SHA384.Create();
				break;
			case Algorithm.SHA512:
				hash = SHA512.Create();
				break;
			default:
				throw new ArgumentException("ChangeAlgorithm: invalid algorithm.");
			}
		}

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

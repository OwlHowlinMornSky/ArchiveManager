using System.Runtime.InteropServices;
using System.Security;

namespace ArchiveManager {
	[SuppressUnmanagedCodeSecurity]
	internal static partial class Util {
		[LibraryImport("shlwapi.dll", EntryPoint = "StrCmpLogicalW", StringMarshalling = StringMarshalling.Utf16)]
		public static partial int StrCmpLogicalW(string psz1, string psz2);
	}
}

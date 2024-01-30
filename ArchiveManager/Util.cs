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
using System.Runtime.InteropServices;
using System.Security;

namespace ArchiveManager {
	[SuppressUnmanagedCodeSecurity]
	internal static partial class Util {
		[LibraryImport("shlwapi.dll", EntryPoint = "StrCmpLogicalW", StringMarshalling = StringMarshalling.Utf16)]
		public static partial int StrCmpLogicalW(string psz1, string psz2);

		public enum BeepType : int {
			SimpleBeep = -1, // 0xFFFFFFFF 一个简单的哔哔声 如果声卡不可用，则使用扬声器生成声音。

			MB_OK = 0x00000000, // 指定为 Windows 默认蜂鸣声的声音。 

			MB_ICONERROR = 0x00000010, // 指定为 Windows 严重停止声音的声音。
			MB_ICONHAND = 0x00000010, // 请参阅 MB_ICONERROR。
			MB_ICONSTOP = 0x00000010, // 请参阅 MB_ICONERROR。

			MB_ICONQUESTION = 0x00000020, // 指定为 Windows 问题声音的声音。

			MB_ICONWARNING = 0x00000030, // 指定为 Windows 感叹号的声音。
			MB_ICONEXCLAMATION = 0x00000030, // 请参阅 MB_ICONWARNING。

			MB_ICONINFORMATION = 0x00000040, // 指定为 Windows 星号声音的声音。
			MB_ICONASTERISK = 0x00000040, // 请参阅 MB_ICONINFORMATION。
		}

		[LibraryImport("User32.dll", EntryPoint = "MessageBeep")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static partial bool MessageBeep(BeepType type);

	}
}

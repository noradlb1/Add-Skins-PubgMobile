using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Memory;

namespace ModPubg.fClass
{
	// Token: 0x02000028 RID: 40
	internal class functions
	{
		// Token: 0x0600012D RID: 301 RVA: 0x0000D55C File Offset: 0x0000B75C
		public void cmd(string arg)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\cmd.exe",
				Arguments = "/c " + arg
			};
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x0600012E RID: 302
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x0600012F RID: 303
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern int Process32First(IntPtr handle, ref functions.ProcessEntry32 pe);

		// Token: 0x06000130 RID: 304
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern int Process32Next(IntPtr handle, ref functions.ProcessEntry32 pe);

		// Token: 0x06000131 RID: 305 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		public void StartKernel()
		{
			this.cmd("net stop BPDriver");
			this.cmd("sc delete BPDriver");
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://mod.gamevip.fun/file/HaNguyen.sys", "C:\\HaNguyen.sys");
			}
			this.cmd("sc create BPDriver binPath=" + this.KernelPath + " start=demand type=filesys");
			this.cmd("net start BPDriver");
			this.cmd("sc start BPDriver");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000D654 File Offset: 0x0000B854
		public string GetProcID()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0U;
			IntPtr intPtr2 = functions.CreateToolhelp32Snapshot(2U, 0U);
			if ((int)intPtr2 > 0)
			{
				functions.ProcessEntry32 processEntry = default(functions.ProcessEntry32);
				processEntry.dwSize = checked((uint)Marshal.SizeOf<functions.ProcessEntry32>(processEntry));
				for (int num2 = functions.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = functions.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal(checked((int)processEntry.dwSize));
					Marshal.StructureToPtr<functions.ProcessEntry32>(processEntry, intPtr3, true);
					object obj = Marshal.PtrToStructure(intPtr3, typeof(functions.ProcessEntry32));
					functions.ProcessEntry32 processEntry2 = (obj != null) ? ((functions.ProcessEntry32)obj) : default(functions.ProcessEntry32);
					Marshal.FreeHGlobal(intPtr3);
					if (processEntry2.szExeFile.Contains("AndroidProcess") && processEntry2.cntThreads > num)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
					if (processEntry2.szExeFile.Contains("aow_exe") && processEntry2.cntThreads > num)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
			}
			return Convert.ToString(intPtr);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000D780 File Offset: 0x0000B980
		[DebuggerStepThrough]
		public void Rep(string PID, string org, string rpl)
		{
			functions.<Rep>d__9 <Rep>d__ = new functions.<Rep>d__9();
			<Rep>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Rep>d__.<>4__this = this;
			<Rep>d__.PID = PID;
			<Rep>d__.org = org;
			<Rep>d__.rpl = rpl;
			<Rep>d__.<>1__state = -1;
			<Rep>d__.<>t__builder.Start<functions.<Rep>d__9>(ref <Rep>d__);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		public void Alert(string msg, Form_Alert.enmType type)
		{
			Form_Alert form_Alert = new Form_Alert();
			form_Alert.showAlert(msg, type);
		}

		// Token: 0x040000CB RID: 203
		private Mem memlib = new Mem();

		// Token: 0x040000CC RID: 204
		public string KernelPath = "C:\\HaNguyen.sys";

		// Token: 0x02000029 RID: 41
		public struct ProcessEntry32
		{
			// Token: 0x040000CD RID: 205
			public uint dwSize;

			// Token: 0x040000CE RID: 206
			public uint cntUsage;

			// Token: 0x040000CF RID: 207
			public uint th32ProcessID;

			// Token: 0x040000D0 RID: 208
			public IntPtr th32DefaultHeapID;

			// Token: 0x040000D1 RID: 209
			public uint th32ModuleID;

			// Token: 0x040000D2 RID: 210
			public uint cntThreads;

			// Token: 0x040000D3 RID: 211
			public uint th32ParentProcessID;

			// Token: 0x040000D4 RID: 212
			public int pcPriClassBase;

			// Token: 0x040000D5 RID: 213
			public uint dwFlags;

			// Token: 0x040000D6 RID: 214
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}
	}
}

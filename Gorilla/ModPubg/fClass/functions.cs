using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Memory;

namespace ModPubg.fClass
{
	// Token: 0x0200001F RID: 31
	internal class functions
	{
		// Token: 0x060000F9 RID: 249
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x060000FA RID: 250
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern int Process32First(IntPtr handle, ref functions.ProcessEntry32 pe);

		// Token: 0x060000FB RID: 251
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern int Process32Next(IntPtr handle, ref functions.ProcessEntry32 pe);

		// Token: 0x060000FC RID: 252 RVA: 0x0000B938 File Offset: 0x00009B38
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

		// Token: 0x060000FD RID: 253 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		public void StartKernel()
		{
			this.cmd("net stop BPDriver");
			this.cmd("sc delete BPDriver");
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("https://vncheat.site/gorilla/source/filedownload/HaNguyen.sys", "C:\\HANGUYEN.sys");
			}
			this.cmd("sc create BPDriver binPath=" + this.KernelPath + " start=demand type=filesys");
			this.cmd("net start BPDriver");
			this.cmd("sc start BPDriver");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000BA30 File Offset: 0x00009C30
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

		// Token: 0x060000FF RID: 255 RVA: 0x0000BB5C File Offset: 0x00009D5C
		[DebuggerStepThrough]
		public void Rep(string PID, string org, string rpl)
		{

		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public void Alert(string msg, Form_Alert.enmType type)
		{
			Form_Alert form_Alert = new Form_Alert();
			form_Alert.showAlert(msg, type);
		}

		// Token: 0x040000A0 RID: 160
		private Mem memlib = new Mem();

		// Token: 0x040000A1 RID: 161
		public string KernelPath = "C:\\HANGUYEN.sys";

		// Token: 0x02000020 RID: 32
		public struct ProcessEntry32
		{
			// Token: 0x040000A2 RID: 162
			public uint dwSize;

			// Token: 0x040000A3 RID: 163
			public uint cntUsage;

			// Token: 0x040000A4 RID: 164
			public uint th32ProcessID;

			// Token: 0x040000A5 RID: 165
			public IntPtr th32DefaultHeapID;

			// Token: 0x040000A6 RID: 166
			public uint th32ModuleID;

			// Token: 0x040000A7 RID: 167
			public uint cntThreads;

			// Token: 0x040000A8 RID: 168
			public uint th32ParentProcessID;

			// Token: 0x040000A9 RID: 169
			public int pcPriClassBase;

			// Token: 0x040000AA RID: 170
			public uint dwFlags;

			// Token: 0x040000AB RID: 171
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}
	}
}

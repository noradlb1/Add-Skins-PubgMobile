using System;
using System.Threading;
using System.Windows.Forms;

namespace ModPubg
{
	// Token: 0x02000021 RID: 33
	internal static class Program
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00007AFC File Offset: 0x00005CFC
		[STAThread]
		private static void Main()
		{
			using (Mutex mutex = new Mutex(true, "modpubg"))
			{
				if (!mutex.WaitOne(TimeSpan.Zero))
				{
					MessageBox.Show("Bật menu 2 lần ăn lồn à");
					Environment.Exit(0);
				}
				else
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new loginForm());
				}
			}
		}
	}
}

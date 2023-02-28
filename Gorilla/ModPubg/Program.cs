using System;
using System.Threading;
using System.Windows.Forms;

namespace ModPubg
{
	// Token: 0x02000018 RID: 24
	internal static class Program
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000060A0 File Offset: 0x000042A0
		[STAThread]
		private static void Main()
		{
			using (Mutex mutex = new Mutex(true, "modpubg"))
			{
				if (mutex.WaitOne(TimeSpan.Zero))
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new mainForm());
				}
				else
				{
					MessageBox.Show("Bật menu 2 lần ăn lồn à");
					Environment.Exit(0);
				}
			}
		}
	}
}

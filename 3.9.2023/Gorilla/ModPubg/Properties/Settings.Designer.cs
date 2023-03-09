using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ModPubg.Properties
{
	// Token: 0x02000023 RID: 35
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00007EE8 File Offset: 0x000060E8
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00007EFC File Offset: 0x000060FC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00007F1C File Offset: 0x0000611C
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x0400009C RID: 156
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

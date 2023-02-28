using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ModPubg.Properties
{
	// Token: 0x0200001A RID: 26
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00006478 File Offset: 0x00004678
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000648C File Offset: 0x0000468C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000024A9 File Offset: 0x000006A9
		[UserScopedSetting]
		[DefaultSettingValue("")]
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

		// Token: 0x04000071 RID: 113
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

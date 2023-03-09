using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ModPubg
{
	// Token: 0x0200001E RID: 30
	public class json_wrapper
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x000058B4 File Offset: 0x00003AB4
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000058E0 File Offset: 0x00003AE0
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005934 File Offset: 0x00003B34
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005980 File Offset: 0x00003B80
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000076 RID: 118
		private DataContractJsonSerializer serializer;

		// Token: 0x04000077 RID: 119
		private object current_object;
	}
}

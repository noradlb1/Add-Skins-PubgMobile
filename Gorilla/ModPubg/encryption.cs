using System;
using System.Security.Cryptography;
using System.Text;

namespace ModPubg
{
	// Token: 0x02000014 RID: 20
	public static class encryption
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003FFC File Offset: 0x000021FC
		public static string HashHMAC(string enckey, string resp)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(enckey);
			byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
			HMACSHA256 hmacsha = new HMACSHA256(bytes);
			return encryption.byte_arr_to_str(hmacsha.ComputeHash(bytes2));
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004038 File Offset: 0x00002238
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004080 File Offset: 0x00002280
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000040F0 File Offset: 0x000022F0
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, 16);
		}
	}
}

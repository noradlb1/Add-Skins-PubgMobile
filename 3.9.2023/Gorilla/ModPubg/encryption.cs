using System;
using System.Security.Cryptography;
using System.Text;

namespace ModPubg
{
	// Token: 0x0200001D RID: 29
	public static class encryption
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00005798 File Offset: 0x00003998
		public static string HashHMAC(string enckey, string resp)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(enckey);
			byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
			HMACSHA256 hmacsha = new HMACSHA256(bytes);
			return encryption.byte_arr_to_str(hmacsha.ComputeHash(bytes2));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000057D4 File Offset: 0x000039D4
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000581C File Offset: 0x00003A1C
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
				api.error("The session has ended, open program again.");
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000588C File Offset: 0x00003A8C
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, 16);
		}
	}
}

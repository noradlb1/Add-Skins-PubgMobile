using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000003 RID: 3 RVA: 0x00002220 File Offset: 0x00000420
	internal static byte[] smethod_0(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] array = new byte[5];
		memoryStream.Read(array, 0, 5);
		@class.method_5(array);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array2 = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array2, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array2;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000022B8 File Offset: 0x000004B8
	internal static byte[] smethod_1()
	{
		uint num = 112U;
		uint[] array = new uint[]
		{
			4180927983U,
			4055718823U,
			4191512222U,
			3123000358U,
			3733079170U,
			3147026407U,
			407295191U,
			2530369408U,
			2675472509U,
			716344592U,
			531075163U,
			3443134031U,
			677691555U,
			1212734054U,
			871242447U,
			2202014013U,
			2078712699U,
			113984867U,
			644239906U,
			2357728484U,
			2862773709U,
			41885077U,
			3087306194U,
			2574082932U,
			176580028U,
			752221422U,
			3290196879U,
			2332459457U,
			1759438453U,
			1367725343U,
			591103389U,
			2630640428U,
			3690590398U,
			1714642616U,
			2543867335U,
			2997828447U,
			4021647905U,
			1784389647U,
			817389268U,
			807952989U,
			4211880084U,
			2036868376U,
			500609416U,
			4257351269U,
			987347778U,
			888020165U,
			1907289812U,
			2076323228U,
			1152140025U,
			2785308179U,
			1918405344U,
			2662217520U,
			4025398845U,
			454377365U,
			1051227545U,
			3031367915U,
			1028483415U,
			1130202395U,
			4244409015U,
			2890377911U,
			2085812531U,
			3814677559U,
			2265199797U,
			1536784933U,
			3754111199U,
			1352561672U,
			2615630614U,
			359969248U,
			4175064491U,
			71039276U,
			3740901829U,
			863196949U,
			1598207961U,
			2239385410U,
			1756776228U,
			1941849881U,
			1916066680U,
			1867207990U,
			1913052555U,
			3072719581U,
			3988647699U,
			2952759236U,
			192763995U,
			1275494787U,
			407021449U,
			4219393219U,
			2937087870U,
			545006776U,
			831795210U,
			1577823987U,
			1486232753U,
			3570017675U,
			1492367743U,
			3334201053U,
			157419313U,
			540460117U,
			538903864U,
			1231762485U,
			1852953311U,
			1240611509U,
			3281108967U,
			4211530606U,
			2937087870U,
			545006776U,
			831795210U,
			1577823987U,
			1486232753U,
			3570017675U,
			1492367743U,
			3334201053U,
			157419313U,
			540460117U
		};
		uint[] array2 = new uint[16];
		uint num2 = 1008897364U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		return <Module>.smethod_0(array4);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000024B0 File Offset: 0x000006B0
	internal static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		string[] manifestResourceNames = <Module>.assembly_0.GetManifestResourceNames();
		if (Array.IndexOf<string>(manifestResourceNames, resolveEventArgs_0.Name) != -1)
		{
			return <Module>.assembly_0;
		}
		return null;
	}

	// Token: 0x06000006 RID: 6
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x04000001 RID: 1
	internal static Assembly assembly_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000024E0 File Offset: 0x000006E0
		internal void method_0()
		{
			this.uint_0 = 1024U;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024F8 File Offset: 0x000006F8
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 >= num)
			{
				class0_0.uint_1 -= num;
				class0_0.uint_0 -= num;
				this.uint_0 -= this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				return 1U;
			}
			class0_0.uint_1 = num;
			this.uint_0 += 2048U - this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216U)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
				class0_0.uint_1 <<= 8;
			}
			return 0U;
		}

		// Token: 0x04000003 RID: 3
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025E4 File Offset: 0x000007E4
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000260C File Offset: 0x0000080C
		internal void method_0()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1U;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002644 File Offset: 0x00000844
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1U << this.int_0);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000268C File Offset: 0x0000088C
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026D4 File Offset: 0x000008D4
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)((UIntPtr)(uint_0 + num))].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000004 RID: 4
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000005 RID: 5
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002714 File Offset: 0x00000914
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0U;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002760 File Offset: 0x00000960
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002774 File Offset: 0x00000974
		internal void method_2()
		{
			while (this.uint_1 < 16777216U)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000027BC File Offset: 0x000009BC
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1U);
				num3 = (num3 << 1 | 1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002830 File Offset: 0x00000A30
		internal Class0()
		{
		}

		// Token: 0x04000006 RID: 6
		internal uint uint_0;

		// Token: 0x04000007 RID: 7
		internal uint uint_1;

		// Token: 0x04000008 RID: 8
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002844 File Offset: 0x00000A44
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002944 File Offset: 0x00000B44
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1U);
				uint uint_4 = Math.Max(this.uint_1, 4096U);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002990 File Offset: 0x00000B90
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000029AC File Offset: 0x00000BAC
		internal void method_2(int int_0)
		{
			uint num = 1U << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1U;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000029E4 File Offset: 0x00000BE4
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)((UIntPtr)num3)].method_0();
					this.struct0_1[(int)((UIntPtr)num3)].method_0();
				}
				this.struct0_2[(int)((UIntPtr)num)].method_0();
				this.struct0_3[(int)((UIntPtr)num)].method_0();
				this.struct0_4[(int)((UIntPtr)num)].method_0();
				this.struct0_5[(int)((UIntPtr)num)].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.struct1_0[(int)((UIntPtr)num)].method_0();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.struct0_6[(int)((UIntPtr)num)].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B10 File Offset: 0x00000D10
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((UIntPtr)(@struct.uint_0 << 4))].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0U, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0U)
				{
					byte byte_2 = this.class4_0.method_6(0U);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.struct0_2[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 1U)
					{
						if (this.struct0_3[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) != 0U)
						{
							uint num7;
							if (this.struct0_4[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.struct0_5[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) != 0U)
								{
									num7 = num4;
									num4 = num3;
								}
								else
								{
									num7 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						else if (this.struct0_1[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0U)
						{
							@struct.method_4();
							this.class4_0.method_5(this.class4_0.method_6(num));
							num5 += 1UL;
							continue;
						}
						num8 = this.class2_1.method_2(this.class0_0, num6) + 2U;
						@struct.method_3();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num9 = this.struct1_0[(int)((UIntPtr)<Module>.Class1.smethod_0(num8))].method_1(this.class0_0);
						if (num9 < 4U)
						{
							num = num9;
						}
						else
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 < 14U)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1U, this.class0_0, num10);
							}
							else
							{
								num += this.class0_0.method_3(num10 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
					{
						break;
					}
					this.class4_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E84 File Offset: 0x00001084
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			int num = (int)(byte_0[0] / 9);
			int int_2 = num % 5;
			int int_3 = num / 5;
			uint num2 = 0U;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num2);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EE4 File Offset: 0x000010E4
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2U;
			if (uint_3 < 4U)
			{
				return uint_3;
			}
			return 3U;
		}

		// Token: 0x04000009 RID: 9
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000A RID: 10
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000016 RID: 22
		internal bool bool_0;

		// Token: 0x04000017 RID: 23
		internal uint uint_0;

		// Token: 0x04000018 RID: 24
		internal uint uint_1;

		// Token: 0x04000019 RID: 25
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001A RID: 26
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x0600001B RID: 27 RVA: 0x00002F00 File Offset: 0x00001100
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1U)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00002F58 File Offset: 0x00001158
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0U; num < this.uint_0; num += 1U)
				{
					this.struct1_0[(int)((UIntPtr)num)].method_0();
					this.struct1_1[(int)((UIntPtr)num)].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002FBC File Offset: 0x000011BC
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0U)
				{
					return this.struct1_0[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				uint num = 8U;
				if (this.struct0_1.method_1(class0_0) != 0U)
				{
					num += 8U;
					num += this.struct1_2.method_1(class0_0);
				}
				else
				{
					num += this.struct1_1[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				return num;
			}

			// Token: 0x0600001E RID: 30 RVA: 0x00003028 File Offset: 0x00001228
			internal Class2()
			{
			}

			// Token: 0x0400001B RID: 27
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001C RID: 28
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001D RID: 29
			internal <Module>.Struct0 struct0_0 = default(<Module>.Struct0);

			// Token: 0x0400001E RID: 30
			internal <Module>.Struct0 struct0_1 = default(<Module>.Struct0);

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000020 RID: 32
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x0600001F RID: 31 RVA: 0x0000307C File Offset: 0x0000127C
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
				{
					return;
				}
				this.int_0 = int_2;
				this.uint_0 = (1U << int_2) - 1U;
				this.int_1 = int_3;
				uint num = 1U << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_0();
				}
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00003100 File Offset: 0x00001300
			internal void method_1()
			{
				uint num = 1U << this.int_1 + this.int_0;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
				}
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00003140 File Offset: 0x00001340
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00003170 File Offset: 0x00001370
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00003198 File Offset: 0x00001398
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002830 File Offset: 0x00000A30
			internal Class3()
			{
			}

			// Token: 0x04000021 RID: 33
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000022 RID: 34
			internal int int_0;

			// Token: 0x04000023 RID: 35
			internal int int_1;

			// Token: 0x04000024 RID: 36
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000025 RID: 37 RVA: 0x000031C4 File Offset: 0x000013C4
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000026 RID: 38 RVA: 0x000031E4 File Offset: 0x000013E4
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000027 RID: 39 RVA: 0x00003214 File Offset: 0x00001414
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x06000028 RID: 40 RVA: 0x00003248 File Offset: 0x00001448
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((UIntPtr)((1U + num2 << 8) + num))].method_1(class0_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_5E;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x04000025 RID: 37
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000032B8 File Offset: 0x000014B8
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0U;
			this.uint_1 = 0U;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000032F0 File Offset: 0x000014F0
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0U;
				this.uint_0 = 0U;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000331C File Offset: 0x0000151C
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003358 File Offset: 0x00001558
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0U)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0U;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000033B0 File Offset: 0x000015B0
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0U)
			{
				if (num >= this.uint_2)
				{
					num = 0U;
				}
				this.byte_0[(int)((UIntPtr)(this.uint_0++))] = this.byte_0[(int)((UIntPtr)(num++))];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1U;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000342C File Offset: 0x0000162C
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003468 File Offset: 0x00001668
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002830 File Offset: 0x00000A30
		internal Class4()
		{
		}

		// Token: 0x04000026 RID: 38
		internal byte[] byte_0;

		// Token: 0x04000027 RID: 39
		internal uint uint_0;

		// Token: 0x04000028 RID: 40
		internal Stream stream_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_1;

		// Token: 0x0400002A RID: 42
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000349C File Offset: 0x0000169C
		internal void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000034B0 File Offset: 0x000016B0
		internal void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000034F8 File Offset: 0x000016F8
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000351C File Offset: 0x0000171C
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003540 File Offset: 0x00001740
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003564 File Offset: 0x00001764
		internal bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400002B RID: 43
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct4
	{
	}
}

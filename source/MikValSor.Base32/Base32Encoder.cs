using System;
using System.Text;

namespace MikValSor.Encoding
{
	public static class Base32Encoder
	{
		public static string Encode(byte[] data, Base32Format format = Base32Format.RFC4648, bool padOutput = true)
		{
			if (data == null) throw new ArgumentNullException(nameof(data));
			if (data.Length == 0) return String.Empty;
			if (data.Length >= (1 << 28)) throw new ArgumentOutOfRangeException(nameof(data));

			StringBuilder stringBuilder = new StringBuilder((data.Length * 8 + 4) / 5);

			int buffer = data[0];
			int next = 1;
			int bitsLeft = 8;
			while (bitsLeft > 0 || next < data.Length)
			{
				if (bitsLeft < 5)
				{
					if (next < data.Length)
					{
						buffer <<= 8;
						buffer |= (data[next++] & 0xff);
						bitsLeft += 8;
					}
					else
					{
						int pad = 5 - bitsLeft;
						buffer <<= pad;
						bitsLeft += pad;
					}
				}
				bitsLeft -= 5;
				stringBuilder.Append(Base32RFC4648Mapping.RFC4648Chars[31 & (buffer >> (bitsLeft - 5))]);
			}
			if (padOutput)
			{
				int padding = 8 - (stringBuilder.Length % 8);
				if (padding > 0) stringBuilder.Append(new string(Base32RFC4648Mapping.PaddingChar, padding == 8 ? 0 : padding));
			}
			return stringBuilder.ToString();
		}
	}
}
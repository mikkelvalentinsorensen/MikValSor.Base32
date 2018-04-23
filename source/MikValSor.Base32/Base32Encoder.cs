using System;
using System.Text;

namespace MikValSor.Encoding
{
	/// <summary>
	///		Class used to encode byte arrays to Base32 strings.
	/// </summary>
	public static class Base32Encoder
	{
		/// <summary>
		///		Encodes the byte array to a Base32 string.
		/// </summary>
		/// <param name="byteArray">
		///		Byte array for encoding.
		/// </param>
		/// <param name="format">
		///		Specify the Base32 encoding format.
		/// </param>
		/// <param name="padOutput">
		///		Select if end padding of the Base32 string is wanted.
		/// </param>
		/// <returns></returns>
		public static string Encode(byte[] byteArray, Base32Format format = Base32Format.RFC4648, bool padOutput = true)
		{
			if (byteArray == null) throw new ArgumentNullException(nameof(byteArray));
			if (byteArray.Length == 0) return String.Empty;
			if (byteArray.Length >= (1 << 28)) throw new ArgumentOutOfRangeException(nameof(byteArray));

			var mapping = Base32Mapping.GetMapping(format);
			StringBuilder stringBuilder = new StringBuilder((byteArray.Length * 8 + 4) / 5);

			int buffer = byteArray[0];
			int index = 0;
			int pad = 0;
			int next = 1;
			int bitsLeft = 8;
			while (bitsLeft > 0 || next < byteArray.Length)
			{
				if (bitsLeft < 5)
				{
					if (next < byteArray.Length)
					{
						buffer <<= 8;
						buffer |= (byteArray[next++] & 0xff);
						bitsLeft += 8;
					}
					else
					{
						pad = 5 - bitsLeft;
						buffer <<= pad;
						bitsLeft += pad;
					}
				}
				index = 31 & (buffer >> (bitsLeft - 5));
				bitsLeft -= 5;
				stringBuilder.Append(mapping.Chars[index]);
			}
			if (padOutput)
			{
				int padding = 8 - (stringBuilder.Length % 8);
				if (padding > 0) stringBuilder.Append(new string(mapping.PaddingChar, padding == 8 ? 0 : padding));
			}
			return stringBuilder.ToString();
		}
	}
}
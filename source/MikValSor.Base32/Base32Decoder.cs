namespace MikValSor.Encoding
{
	/// <summary>
	///		Class for decoding Base32 strings to byte arrays.
	/// </summary>
	public static class Base32Decoder
	{
		/// <summary>
		///		Converte a Base32 string to byte array.
		/// </summary>
		/// <param name="base32">
		///		Base32 formated string.
		/// </param>
		/// <param name="format">
		///		Specify the Base32 encoding format.
		/// </param>
		/// <returns>
		///		byte array with value of Base32 encoding.
		/// </returns>
		public static byte[] Decode(string base32, Base32Format format = Base32Format.RFC4648)
		{
			if (base32.Length == 0) return new byte[0];
			base32 = RemovePadding(base32, Base32RFC4648Mapping.PaddingChar);

			byte[] result = new byte[base32.Length * 5 / 8];
			int buffer = 0;
			int next = 0;
			int bitsLeft = 0;

			foreach (var c in base32.ToCharArray())
			{
				if (!Base32RFC4648Mapping.RFC4648CharValues.ContainsKey(c))
				{
					throw new Base32DecodingException($"Character was illigal: {c}");
				}
				buffer <<= 5;
				buffer |= Base32RFC4648Mapping.RFC4648CharValues[c] & 31;
				bitsLeft += 5;
				if (bitsLeft >= 8)
				{
					result[next++] = (byte)(buffer >> (bitsLeft - 8));
					bitsLeft -= 8;
				}
			}

			return result;
		}

		private static string RemovePadding(string base32, char paddingChar)
		{
			var l = base32.Length;
			if (base32[l - 1] == paddingChar)
			{
				if (base32[l - 2] == paddingChar)
				{
					if (base32[l - 3] == paddingChar)
					{
						if (base32[l - 4] == paddingChar)
						{
							if (base32[l - 5] == paddingChar)
							{
								if (base32[l - 6] == paddingChar)
								{
									if (base32[l - 7] == paddingChar)
									{
										return base32.Substring(0, base32[l - 7]);
									}
									else return base32.Substring(0, l - 6);
								}
								else return base32.Substring(0, l - 5);
							}
							else return base32.Substring(0, l - 4);
						}
						else return base32.Substring(0, l - 3);
					}
					else return base32.Substring(0, l - 2);
				}
				else return base32.Substring(0, l - 1);
			}
			return base32;
		}
	}
}
using System.Collections.Generic;

namespace MikValSor.Encoding
{
    internal class Base32RFC4648Mapping
	{
		internal static readonly char[] RFC4648Chars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '2', '3', '4', '5', '6', '7' };
		internal static Dictionary<char, int> RFC4648CharValues = new Dictionary<char, int>();
		internal static readonly char PaddingChar = '=';

		static Base32RFC4648Mapping()
		{
			for (int i = 0; i < RFC4648Chars.Length; i++) RFC4648CharValues[RFC4648Chars[i]] = i;
		}
	}
}

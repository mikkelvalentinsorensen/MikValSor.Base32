using System.Collections.Generic;

namespace MikValSor.Encoding
{
    internal sealed class Base32RFC4648Mapping : IBase32Mapping
	{
		internal static IBase32Mapping Instance = new Base32RFC4648Mapping();
		static char[] Chars = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '2', '3', '4', '5', '6', '7' };
		static Dictionary<char, int> CharValues = new Dictionary<char, int>();
		static char PaddingChar = '=';

		static Base32RFC4648Mapping()
		{
			for (int i = 0; i < Chars.Length; i++) CharValues[Chars[i]] = i;
		}
		internal Base32RFC4648Mapping()
		{
		}

		char[] IBase32Mapping.Chars => Chars;
		Dictionary<char, int> IBase32Mapping.CharValues => CharValues;
		char IBase32Mapping.PaddingChar => PaddingChar;
	}
}

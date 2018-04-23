using System.Collections.Generic;

namespace MikValSor.Encoding
{
    internal sealed class Base32HexMapping : IBase32Mapping
	{
		internal static IBase32Mapping Instance = new Base32HexMapping();
		static readonly char[] Chars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V' };
		static Dictionary<char, int> CharValues = new Dictionary<char, int>();
		static readonly char PaddingChar = '=';

		static Base32HexMapping()
		{
			for (int i = 0; i < Chars.Length; i++) CharValues[Chars[i]] = i;
		}
		internal Base32HexMapping()
		{
		}

		char[] IBase32Mapping.Chars => Chars;
		Dictionary<char, int> IBase32Mapping.CharValues => CharValues;
		char IBase32Mapping.PaddingChar => PaddingChar;
	}
}

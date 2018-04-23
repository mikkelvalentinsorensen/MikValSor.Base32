using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MikValSor.Encoding
{
    internal sealed class ZBase32Mapping : IBase32Mapping
	{
		internal static IBase32Mapping Instance = new ZBase32Mapping();
		private static char[] Chars = new char[] { 'y', 'b', 'n', 'd', 'r', 'f', 'g', '8', 'e', 'j', 'k', 'm', 'c', 'p', 'q', 'x', 'o', 't', '1', 'u', 'w', 'i', 's', 'z', 'a', '3', '4', '5', 'h', '7', '6', '9' };
		private static Dictionary<char, int> CharValues = new Dictionary<char, int>(new Dictionary<char, int>());
		private static char PaddingChar = '=';

		static ZBase32Mapping()
		{
			for (int i = 0; i < Chars.Length; i++) CharValues[Chars[i]] = i;
		}

		internal ZBase32Mapping()
		{
		}

		char[] IBase32Mapping.Chars => Chars;
		Dictionary<char, int> IBase32Mapping.CharValues => CharValues;
		char IBase32Mapping.PaddingChar => PaddingChar;
	}
}

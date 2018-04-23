using System.Collections.Generic;

namespace MikValSor.Encoding
{
    internal sealed class CrockfordsMapping : IBase32Mapping
	{
		internal static IBase32Mapping Instance = new CrockfordsMapping();
		private static readonly char[] Chars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
		private static Dictionary<char, int> CharValues = new Dictionary<char, int>();
		private static readonly char PaddingChar = '=';

		static CrockfordsMapping()
		{
			for (int i = 0; i < Chars.Length; i++) CharValues[Chars[i]] = i;
			CharValues['o'] = 0;
			CharValues['O'] = 0;
			CharValues['i'] = 1;
			CharValues['I'] = 1;
			CharValues['l'] = 1;
			CharValues['L'] = 1;
			CharValues['a'] = 10;
			CharValues['b'] = 11;
			CharValues['c'] = 12;
			CharValues['d'] = 13;
			CharValues['e'] = 14;
			CharValues['f'] = 15;
			CharValues['g'] = 16;
			CharValues['h'] = 17;
			CharValues['j'] = 18;
			CharValues['k'] = 19;
			CharValues['m'] = 20;
			CharValues['n'] = 21;
			CharValues['p'] = 22;
			CharValues['q'] = 23;
			CharValues['r'] = 24;
			CharValues['s'] = 25;
			CharValues['t'] = 26;
			CharValues['v'] = 27;
			CharValues['w'] = 28;
			CharValues['x'] = 29;
			CharValues['y'] = 30;
			CharValues['z'] = 31;
		}

		internal CrockfordsMapping()
		{
		}

		char[] IBase32Mapping.Chars => Chars;
		Dictionary<char, int> IBase32Mapping.CharValues => CharValues;
		char IBase32Mapping.PaddingChar => PaddingChar;
	}
}

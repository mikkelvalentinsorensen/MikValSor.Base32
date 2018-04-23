namespace MikValSor.Encoding
{
    internal interface IBase32Mapping
    {
		char[] Chars { get; }

		System.Collections.Generic.Dictionary<char, int> CharValues { get; }

		char PaddingChar { get; }
	}
}

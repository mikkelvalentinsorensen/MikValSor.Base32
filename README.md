.NET Standard Libaray for Base32 Encoder, Decoder and ValueType. Implemented multiple standards:
- [default] Base32 according to RFC4648.
- z-base-32 aka. ZBase32.
- Crockford's Base32.
- base32hex / Triacontakaidecimal according to RFC 2938.

## Encoding Example:
```cs
static void EncodeExample()
{
	var bytearray = new byte[] { 0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11 };
	var base32string = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

	System.Console.WriteLine($"base32string: {base32string}");
}
/**
		Output:
		base32string: AAAQEBAFAYDQQCIKBM======
	**/
```

## Decoding Example:
```cs
static void DecodeExample()
{
	var base32string = "AAAQEBAFAYDQQCIKBM======";
	var bytearray = MikValSor.Encoding.Base32Decoder.Decode(base32string);

	for (var i = 0; i < bytearray.Length; i++)
	{
		System.Console.WriteLine($"bytearray[{i}]: {bytearray[i]}");
	}
}
/**
	Output:
	bytearray[0]: 0
	bytearray[1]: 1
	bytearray[2]: 2
	bytearray[3]: 4
	bytearray[4]: 5
	bytearray[5]: 6
	bytearray[6]: 7
	bytearray[7]: 8
	bytearray[8]: 9
	bytearray[9]: 10
	bytearray[10]: 11
**/
```
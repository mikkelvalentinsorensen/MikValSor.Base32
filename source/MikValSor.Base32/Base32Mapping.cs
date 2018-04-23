namespace MikValSor.Encoding
{
    internal static class Base32Mapping
    {
		internal static IBase32Mapping GetMapping(Base32Format base32Format)
		{
			switch (base32Format)
			{
				case Base32Format.Base32Hex: return Base32HexMapping.Instance;
				case Base32Format.Crockfords: return CrockfordsMapping.Instance;
				case Base32Format.RFC4648: return Base32RFC4648Mapping.Instance;
				case Base32Format.ZBase32: return ZBase32Mapping.Instance;
			}
			throw new System.NotImplementedException();
		}
    }
}

namespace MikValSor.Encoding
{
    public class Base32
	{
		private readonly byte[] ByteArray;
		private readonly string Value;
		public readonly Base32Format Format;

		private Base32(byte[] byteArray, string value, Base32Format format)
		{
			ByteArray = byteArray;
			Value = value;
			Format = format;
		}

		public Base32(byte[] byteArray, Base32Format format = Base32Format.RFC4648)
		{
			ByteArray = byteArray;
			Value = Base32Encoder.Encode(byteArray, format);
			Format = format;
		}

		public byte[] ToByteArray()
		{
			return (byte[])ByteArray.Clone();
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			var objBase32 = obj as Base32;
			if (objBase32 == null) return false;
			if (Format != objBase32.Format) return false;
			return Value.Equals(objBase32.Value);
		}

		public override string ToString()
		{
			return Value;
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		public static Base32 Parse(string base32, Base32Format format = Base32Format.RFC4648)
		{
			if (base32 == null) throw new System.ArgumentNullException(nameof(base32));
			var byteArray = Base32Decoder.Decode(base32, format);
			return new Base32(byteArray, base32, format);
		}

		public static bool TryParse(string base32string, out Base32 base32, Base32Format format = Base32Format.RFC4648)
		{
			try
			{
				base32 = Parse(base32string, format);
				return true;
			}
			catch (System.Exception)
			{
				base32 = null;
				return false;
			}
		}
	}
}

namespace MikValSor.Encoding
{
	/// <summary>
	///		This class is a immutable representation of a Base32 encoding.
	/// </summary>
    public class Base32
	{
		private readonly byte[] ByteArray;
		private readonly string Value;

		/// <summary>
		///		Encoding for mat of the Base32 value.
		/// </summary>
		public readonly Base32Format Format;

		private Base32(byte[] byteArray, string value, Base32Format format)
		{
			ByteArray = byteArray;
			Value = value;
			Format = format;
		}


		/// <summary>
		///		Constructs a Base32 value from a byte array.
		/// </summary>
		/// <param name="byteArray">
		///		Source byte array for the Base32 value.
		/// </param>
		/// <param name="format">
		///		Specifies the Base32 encoding format.
		/// </param>
		public Base32(byte[] byteArray, Base32Format format = Base32Format.RFC4648)
		{
			ByteArray = byteArray;
			Value = Base32Encoder.Encode(byteArray, format);
			Format = format;
		}


		/// <summary>
		///		Converts the Base32 value to byte array.
		/// </summary>
		/// <returns>
		///		Returns byte array value presentation of the Base32 encoding.
		/// </returns>
		public byte[] ToByteArray()
		{
			return (byte[])ByteArray.Clone();
		}
		/// <summary>
		///		Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">
		///		The object to compare with the current object.
		/// </param>
		/// <returns>
		///		True if the specified object is equal to the current object; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			var objBase32 = obj as Base32;
			if (objBase32 == null) return false;
			if (Format != objBase32.Format) return false;
			return Value.Equals(objBase32.Value);
		}

		/// <summary>
		///		Returns a string that represents the Base32 value.
		/// </summary>
		/// <returns>
		///		A string that represents the Base32 value.
		/// </returns>
		public override string ToString()
		{
			return Value;
		}

		/// <summary>
		///		Return hash value of the Base32 value.
		/// </summary>
		/// <returns>
		///		A hash code for the current Base32 value.
		/// </returns>
		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}

		/// <summary>
		///		Parses a Base32 formated string to Base32 object.
		/// </summary>
		/// <param name="base32">
		///		Base32 formated string.
		/// </param>
		/// <param name="format">
		///		Specify the Base32 encoding format.
		/// </param>
		/// <returns>
		///		A Base32 representation of the Base32 formated string.
		/// </returns>
		public static Base32 Parse(string base32, Base32Format format = Base32Format.RFC4648)
		{
			if (base32 == null) throw new System.ArgumentNullException(nameof(base32));
			var byteArray = Base32Decoder.Decode(base32, format);
			return new Base32(byteArray, base32, format);
		}


		/// <summary>
		///		Tryies to parses a Base32 formated string to Base32 object.
		/// </summary>
		/// <param name="base32string">
		///		Base32 formates string.
		/// </param>
		/// <param name="base32">
		///		Return Base32 representation of the Base32 formated string.
		/// </param>
		/// <param name="format">
		///		Specify the Base32 encoding format.
		/// </param>
		/// <returns>
		///		True if Parse of string was successful.
		/// </returns>
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

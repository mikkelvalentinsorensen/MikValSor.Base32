using System;

namespace MikValSor.Encoding
{
	/// <summary>
	///		Class for encoding nyte arries Base32 strings to byte arrays.
	/// </summary>
	public class Base32DecodingException : Exception
	{
		/// <summary>
		///		Creates a decoding exception.
		/// </summary>
		/// <param name="message">
		///		The message that describes the error.
		/// </param>
		public Base32DecodingException(string message) : base(message)
		{
		}
	}
}

using System;

namespace MikValSor.Encoding
{	public class Base32DecodingException : Exception
	{
		public Base32DecodingException(string message) : base(message)
		{
		}
	}
}

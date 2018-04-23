using NUnit.Framework;
using System;

namespace MikValSor.Base32.Test
{
	[TestFixture]
	public class Base32Decoder
	{
		[Test]
		public void DecodeTest_Empty_Empty()
		{
			//Arrange
			var base32 = String.Empty;

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[0];
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AA_000()
		{
			//Arrange
			var base32 = "AA======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AE_001()
		{
			//Arrange
			var base32 = "AE======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 001 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AI_002()
		{
			//Arrange
			var base32 = "AI======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 002 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AM_003()
		{
			//Arrange
			var base32 = "AM======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 003 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AQ_004()
		{
			//Arrange
			var base32 = "AQ======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 004 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AU_005()
		{
			//Arrange
			var base32 = "AU======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 005 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AY_006()
		{
			//Arrange
			var base32 = "AY======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 006 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_A4_007()
		{
			//Arrange
			var base32 = "A4======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 007 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_BA_008()
		{
			//Arrange
			var base32 = "BA======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 008 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_BE_009()
		{
			//Arrange
			var base32 = "BE======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 009 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_BI_010()
		{
			//Arrange
			var base32 = "BI======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 010 };
			Assert.AreEqual(expected, actual);
		}


		[Test]
		public void DecodeTest_AAAA_000_000()
		{
			//Arrange
			var base32 = "AAAA====";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000, 000 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AAAAA_000_000_000()
		{
			//Arrange
			var base32 = "AAAAA===";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000, 000, 000 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AAAAAAA_000_000_000_000()
		{
			//Arrange
			var base32 = "AAAAAAA=";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000, 000, 000, 000 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AAAAAAAA_000_000_000_000_000()
		{
			//Arrange
			var base32 = "AAAAAAAA";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000, 000, 000, 000, 000 };
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void DecodeTest_AAAAAAAAAA_000_000_000_000_000_000()
		{
			//Arrange
			var base32 = "AAAAAAAAAA======";

			//Act
			var actual = MikValSor.Encoding.Base32Decoder.Decode(base32);

			//Assert
			var expected = new byte[] { 000, 000, 000, 000, 000, 000 };
			Assert.AreEqual(expected, actual);
		}
	}
}

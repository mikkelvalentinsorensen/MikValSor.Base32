using NUnit.Framework;
using System;

namespace MikValSor.Base32.Test
{
	[TestFixture]
	public class Base32Encoder
	{
		[Test]
		public void EncodeTest_Empty_Empty()
		{
			//Arrange
			var bytearray = new byte[] {};

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = String.Empty;
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_AA()
		{
			//Arrange
			var bytearray = new byte[] { 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AA======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_001_AE()
		{
			//Arrange
			var bytearray = new byte[] { 001 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AE======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_002_AI()
		{
			//Arrange
			var bytearray = new byte[] { 002 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AI======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_003_AM()
		{
			//Arrange
			var bytearray = new byte[] { 003 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AM======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_004_AQ()
		{
			//Arrange
			var bytearray = new byte[] { 004 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AQ======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_005_AU()
		{
			//Arrange
			var bytearray = new byte[] { 005 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AU======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_006_AY()
		{
			//Arrange
			var bytearray = new byte[] { 006 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AY======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_007_A4()
		{
			//Arrange
			var bytearray = new byte[] { 007 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "A4======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_008_BA()
		{
			//Arrange
			var bytearray = new byte[] { 008 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "BA======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_009_BE()
		{
			//Arrange
			var bytearray = new byte[] { 009 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "BE======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_010_BI()
		{
			//Arrange
			var bytearray = new byte[] { 010 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "BI======";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_000_AAAA()
		{
			//Arrange
			var bytearray = new byte[] { 000, 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AAAA====";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_000_000_AAAAA()
		{
			//Arrange
			var bytearray = new byte[] { 000, 000, 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AAAAA===";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_000_000_000_AAAAAAA()
		{
			//Arrange
			var bytearray = new byte[] { 000, 000, 000, 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AAAAAAA=";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_000_000_000_000_AAAAAAAA()
		{
			//Arrange
			var bytearray = new byte[] { 000, 000, 000, 000, 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AAAAAAAA";
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void EncodeTest_000_000_000_000_000_000_AAAAAAAAAA()
		{
			//Arrange
			var bytearray = new byte[] { 000, 000, 000, 000, 000, 000 };

			//Act
			var actual = MikValSor.Encoding.Base32Encoder.Encode(bytearray);

			//Assert
			var expected = "AAAAAAAAAA======";
			Assert.AreEqual(expected, actual);
		}
	}
}

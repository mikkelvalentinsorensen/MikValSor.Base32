using NUnit.Framework;

namespace MikValSor.Base32.Test
{
	[TestFixture]
	public class Base32ImmutableTest
	{
		[Test]
		public void ImmutableTest()
		{
			//Arrange
			var validator = new MikValSor.Immutable.ImmutableValidator();
			var target = typeof(MikValSor.Encoding.Base32);

			//Act
			validator.EnsureImmutable(target);

			//Assert
		}
	}
}

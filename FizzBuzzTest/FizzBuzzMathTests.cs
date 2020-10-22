using FizzBuzz.Engines;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
	[TestClass]
	public class FizzBuzzMathTests
	{
		[TestMethod]
		public void IsaMultipleOfTestTrue()
		{
			// Arrange
			var x = 10;
			var n = 2;

			// Act
			var result = FizzBuzzMath.IsaMulipleOf( x, n );

			// Assert
			Assert.IsTrue( result, "10 is divisible by 2" );
		}

		[TestMethod]
		public void IsaMultipleOfTestFalse()
		{
			// Arrange
			var x = 10;
			var n = 3;

			// Act
			var result = FizzBuzzMath.IsaMulipleOf( x, n );

			// Assert
			Assert.IsFalse( result, "10 is not divisible by 3" );
		}
	}
}

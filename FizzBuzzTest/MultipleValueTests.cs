using FizzBuzz.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
	[TestClass]
	public class MultipleValueTests
	{
		[TestMethod]
		public void MultipleValueTest()
		{
			// Arrange
			var number = 3;
			var value = "Fizz";

			// Act
			var result = new MultipleValue( number, value );

			// Assert
			Assert.AreEqual( number, result.Multiple, $"Expected multiple {number}" );
			Assert.AreEqual( value, result.Value, $"Expected value {value}" );
		}
	}
}

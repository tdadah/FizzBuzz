using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FizzBuzz.Engines;
using FizzBuzz.Models;

namespace FizzBuzzTest
{
	[TestClass]
	public class ProcessOutputTests
	{
		[TestMethod]
		public void FizzBuzzTest1()
		{
			// Arrange
			var multipleValues = new List<MultipleValue>
			{
				new MultipleValue( 3, "Fizz" ),
				new MultipleValue( 5, "Buzz" )
			};

			var start = 9;
			var end = 15;
			var newLine = "\n";

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, start, end, newLine );

			// Assert
			Assert.AreEqual( "Fizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n", result );
		}

		[TestMethod]
		public void FizzBuzzTest2()
		{
			// Arrange
			var multipleValues = new List<MultipleValue>
			{
				new MultipleValue( 3, "Fizz" ),
				new MultipleValue( 11, "Bang" )
			};

			var start = 33;
			var end = 33;
			var newLine = "\n";

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, start, end, newLine );

			// Assert
			Assert.AreEqual( "FizzBang\n", result );
		}

		[TestMethod]
		public void FizzBuzzTest3()
		{
			// Arrange
			var multipleValues = new List<MultipleValue>
			{
				new MultipleValue( 5, "Buzz" ),
				new MultipleValue( 7, "Wizz" )
			};

			var start = 70;
			var end = 70;
			var newLine = "\n";

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, start, end, newLine );

			// Assert
			Assert.AreEqual( "BuzzWizz\n", result );
		}

		[TestMethod]
		public void FizzBuzzValidStartEndTest()
		{
			// Arrange
			var multipleValues = new List<MultipleValue>
			{
				new MultipleValue( 3, "Fizz" ),
				new MultipleValue( 5, "Buzz" )
			};

			var start = 9;
			var end = 1;
			var newLine = "\n";

			// Act
			var result = ProcessOutput.FizzBuzz(multipleValues, start, end, newLine );

			// Assert
			Assert.AreEqual("Invalid inputs, start should be less than end.", result);
		}
	}
}

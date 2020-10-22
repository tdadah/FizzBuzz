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

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, 9, 15 );

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

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, 33, 33 );

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

			// Act
			var result = ProcessOutput.FizzBuzz( multipleValues, 70, 70 );

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

			// Act
			var result = ProcessOutput.FizzBuzz(multipleValues, 9, 1);

			// Assert
			Assert.AreEqual("Invalid inputs, start should be less than end.", result);
		}
	}
}

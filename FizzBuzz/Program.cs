using System;
using System.Collections.Generic;

using FizzBuzz.Engines;
using FizzBuzz.Models;

namespace FizzBuzz
{
	public class Program
	{
		/// <summary>
		/// Main sets up the data and calls ProcessOutput.FizzBuzz and outputs the results.
		/// </summary>
		/// <param name="args"></param>
		public static void Main( string[] args )
		{
			var watch = System.Diagnostics.Stopwatch.StartNew();

			var intReplacement = new List<MultipleValue>
			{
				new MultipleValue( 3, "Fizz" ),
				new MultipleValue( 5, "Buzz" ),
				new MultipleValue( 7, "Wizz" ),
				new MultipleValue( 11, "Bang" )
			};
			Console.WriteLine( ProcessOutput.FizzBuzz( intReplacement, 1, 100 ) );

			Console.WriteLine( $"\n\nElapsed time: {watch.ElapsedMilliseconds }" );
		}
	}
}

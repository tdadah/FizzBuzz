using System.Collections.Generic;

using FizzBuzz.Models;

namespace BlazorFizzBuzz.Data
{
	public class InputData
	{
		public InputData()
		{
			MultipleValues = new List<MultipleValue>
			{
				new MultipleValue( 3, "Fizz" ),
				new MultipleValue( 5, "Buzz" ),
				new MultipleValue( 7, "Wizz" ),
				new MultipleValue( 11, "Bang" )
			};
		}

		public List<MultipleValue> MultipleValues
		{
			get;
			set;
		}
	}
}

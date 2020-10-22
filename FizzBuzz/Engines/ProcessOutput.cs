using FizzBuzz.Models;

using System.Collections.Generic;

namespace FizzBuzz.Engines
{
	public class ProcessOutput
	{
		/// <summary>
		/// FizzBuzz loops through a set of numbers, as long as start is less than end.
		/// For each number, it will build an output string where each number is added followed by a newline,
		/// or the string replacement if the number is divisible by one of the provided multiple values in intReplacement.
		/// </summary>
		/// <param name="intReplacement">
		///	List of MultipleValues where MultipleValues.Multiple representes the integer we are checking for divisibility
		///	and MultipleValues.Value which represents the string value that will replace the number we are printing out.
		/// </param>
		/// <param name="start">
		/// The starting int for the for loop, for example 1.
		/// </param>
		/// <param name="end">
		/// The ending int for the loop, for example 100.
		/// </param>
		/// <returns>
		/// The output string that can be printed with the results of either the number or the string replacement.
		/// </returns>
		public static string FizzBuzz( List<MultipleValue> intReplacement, int start, int end )
		{
			var output = string.Empty;
			if( end < start)
			{
				output = "Invalid inputs, start should be less than end.";
			}
			else
			{
				for(var i = start; i < end + 1; i++)
				{
					var outputNumber = true;
					foreach(var item in intReplacement)
					{
						if (FizzBuzzMath.IsaMulipleOf(i, item.Multiple))
						{
							output += item.Value;
							outputNumber = false;
						}
					}

					if (outputNumber)
					{
						output += i;
					}

					output += "\n";
				}
			}

			return output;
		}
	}
}

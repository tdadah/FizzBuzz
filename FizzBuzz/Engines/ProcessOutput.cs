using FizzBuzz.Models;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Engines
{
	public class ProcessOutput
	{
		public static string FizzBuzz( List<MultipleValue> intReplacement, int start, int end )
		{
			var output = string.Empty;
			for( var i = start; i < end + 1; i++ )
			{
				var outputNumber = true;
				foreach( var item in intReplacement )
				{
					if( FizzBuzzMath.IsDivisibleBy( i, item.Multiple ) )
					{
						output += item.Value;
						outputNumber = false;
					}
				}

				if( outputNumber )
				{
					output += i;
				}

				output += "\n";
			}

			return output;
		}
	}
}

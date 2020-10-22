namespace FizzBuzz.Models
{
	/// <summary>
	/// Mutiple represents the integer that we will check to see if a number is a multiple of.
	/// Value represents the string that will replace the number during ouput if the number is a multiple.
	/// </summary>
	public class MultipleValue
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="multiple">
		/// Mutiple represents the integer that we will check to see if a number is a multiple of.
		/// </param>
		/// <param name="value">
		/// Value represents the string that will replace the number during ouput if the number is a multiple.
		/// </param>
		public MultipleValue( int multiple, string value )
		{
			Multiple = multiple;
			Value = value;
		}

		public int Multiple
		{
			get;
			set;
		}

		public string Value
		{
			get;
			set;
		}
	}
}

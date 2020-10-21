namespace FizzBuzz.Models
{
	public class MultipleValue
	{
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

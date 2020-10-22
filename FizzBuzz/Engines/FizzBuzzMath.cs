namespace FizzBuzz.Engines
{
	public static class FizzBuzzMath
	{
		/// <summary>
		/// Calculates if x is divisible by n using the modulo operator.
		/// If the remainder is zero, then x is divisible by n.
		/// </summary>
		/// <param name="n">
		/// Numerator
		/// </param>
		/// <param name="d">
		/// Denominator
		/// </param>
		/// <returns>
		/// Returns true if x is divisible by n, otherwise returns false.
		/// </returns>
		public static bool IsaMulipleOf( int n, int d )
		{
			return n % d == 0;
		}
	}
}

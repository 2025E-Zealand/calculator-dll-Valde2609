namespace CalculatorClassLibrary
{
    public class Calculator
    {
		/// <summary>
		/// Added a Add method that adds two numbers and returns the result.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public int Add(int a, int b)
		{
			return a + b;
		}
		/// <summary>
		/// Added a Subtract method that subtracts two numbers and returns the result.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public int Subtract(int a, int b)
		{
			return a - b;
		}
		/// <summary>
		/// Added a Multiply method that multiplies two numbers and returns the result.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public int Multiply(int a, int b)
		{
			return a * b;
		}
		/// <summary>
		/// Added a Divide method that divides two numbers and returns the result.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		/// <exception cref="DivideByZeroException"></exception>
		public int Divide(int a, int b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Division by zero is not allowed.");
			}
			return a / b;
		}
	}
}

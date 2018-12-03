using System;

namespace CalculateExpressionWithSqrt
{
	class Program
	{
		static void Main(string[] args)
		{
			//           Task 4
			// Да се изчисли: - стр.126 / 213-е) 

			 double result = 0.0;
			 Console.WriteLine("Calculate an expression ");
			 Console.WriteLine(" ");

			for (int i = 49; i >= 1; i--)
			{
				result = Math.Sqrt(i + result);
			} 

			 Console.WriteLine("The result = " + result);
			 Console.ReadKey(true);
		}
	}
}

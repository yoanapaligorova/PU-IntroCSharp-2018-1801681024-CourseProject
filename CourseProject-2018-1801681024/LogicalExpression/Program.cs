using System;

namespace LogicalExpression
{
	class Program
	{
		static void Main(string[] args)
		{
			 
			/*                         Task 3
			  Ако със знаковете ¬ ,^ и v означим съответно операциите отрицание,
			  логическо събитане и логическо умножение, да се запише на C# следният израз: - стр.38/37-8)
		   */

			bool result = false;
			Console.Write("Enter x=");
			double x = double.Parse(Console.ReadLine());
			Console.Write("Enter y=");
			double y = double.Parse(Console.ReadLine());
			Console.Write("Enter z=");
			double z = double.Parse(Console.ReadLine());
			Console.Write("Enter a=");
			double a = double.Parse(Console.ReadLine());
			double firstCount = Math.Sqrt((x + 1 - (a * Math.Pow(y, 2))) / (x + y));
			double secondCount = Math.Exp(y);
			double tirthCount = z - 1;
			double fourthCount = Math.Sqrt(z - 1);

			if (firstCount > 0 || secondCount < tirthCount && fourthCount <= 5)
			{
				result = true;
				Console.WriteLine(" It is " + result);
			}
			else
			{
				Console.WriteLine(" It is " + result);
			}
			Console.ReadKey(true);
		}
	}
}

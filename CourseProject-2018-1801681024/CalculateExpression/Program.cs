using System;
using System.Text;

namespace CalculateExpression
{
	class Program
	{
		static void Main(string[] args)
		{
			/*                     Task 2  
			 Да се запише според правилата на С# изразът: - стр.129 / Тест 1/2 I group
			*/
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Решаване на числов израз");
			double result = 0;
			Console.Write("Enter x=");
			double x = double.Parse(Console.ReadLine());
			Console.Write("Enter y=");
			double y = double.Parse(Console.ReadLine());
			Console.Write("Enter z=");
			double z = double.Parse(Console.ReadLine());
			if (y >= 0)
			{
				result = ((Math.Pow(x, 7) * y * z) - (3 * 3 * Math.Abs(x + Math.Pow(y, 0.25)))) / (Math.Pow(10, 7) + Math.Sqrt(Math.Log(4)));
				Console.WriteLine("Резултатът =" + " " + result);
			}
			else
			{
				Console.WriteLine(" ");
				Console.WriteLine("Резултатът няма да се изведе защото у < 0 т.е. не съществува отрицателно число под корен");
			}
			Console.ReadKey(true);
		}
	}
}

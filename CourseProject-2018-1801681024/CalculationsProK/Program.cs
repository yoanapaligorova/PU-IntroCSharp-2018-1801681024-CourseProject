using System;

namespace CalculationsProK
{
	class Program
	{
			//  Task 5  -  стр.214 / 378 

		 private static Random rand = new Random();
		static int Pro(int k)
		{
			int product = 1;
			int[] number = new int[k];
			for (int i = 0; i < number.Length; i++)
			{
				number[i] = rand.Next(-200, 200);
			}
			for (int i = 0; i < number.Length; i++)
			{
				if (number[i] <= 10 || number[i] >= -10)
				{
					product *= number[i];
				}
				else { Console.WriteLine("There aren't any numbers between [-10,10]"); }
			}
			return product;
		}
		static void Main(string[] args)
		{
			// 1 част => Да се въведат от клавиатурата произволен брой не нулеви числа (за край на въвеждането да служи числото 0 ).
			//           Да се отпечата сумата на тези от тях, които са отрицателни.

			double sum = 0;
			bool inputIsNumber;
			double numbers;
			
			Console.WriteLine("Calculate the sum of the negative numbres. Enter some numbers. When you're done, enter 0.");

			do
			{
				Console.WriteLine("Enter number");
				inputIsNumber = double.TryParse(Console.ReadLine(), out numbers);
				if (numbers < 0)
				{
					sum += numbers;
				}
			}
			while (numbers != 0 || !inputIsNumber);
			{
				if (sum == 0)
				{
					Console.WriteLine("There aren't any negative numbers");
				}
				else
				{
					Console.WriteLine("Sum  = " + sum);
				}
			}
			Console.WriteLine("........................................................................");

		// 2 част =>Да се въведат от клавиатурата 13 числа. 
		//       Да се намери и отпечата на екрана стредноаретметичното на тези от тях, които отговарят на следното условие: да са положителни или по-малки от -100 .

			double numbFrom1to13;
			double avarage = 0;

			Console.WriteLine("Enter 13 numbers");
			for (int i = 0; i < 13; i++)
			{
				Console.Write("number " + (i + 1) + " =");
				numbFrom1to13 = Convert.ToDouble(Console.ReadLine());

				sum += numbFrom1to13;
				if (numbFrom1to13 > 0 || numbFrom1to13 < -100)
				{
					avarage = sum / i;
				}
			}
			Console.WriteLine("Avarage = " + avarage);

			Console.WriteLine("........................................................................");

			/* 
			   3 част => Да се създаде метод Pro(k), който генерира k на брой случайни цели числа и като резулат връща произведението на тези от тях, 
			       които са в интервала [-10, 10]. В главния метод да се въведат 3 цели положителни числа a,b и c. Да се намери и отпечата: Pro(|c-b|)*Pro(a)
            */

			// Calculate => Pro(|c-b|)*Pro(a)
			int result = 0;

			Console.WriteLine(" ");
			Console.Write("Enter a=");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Enter b=");
			int b = int.Parse(Console.ReadLine());
			Console.Write("Enter c=");
			int c = int.Parse(Console.ReadLine());

			int cb = Pro(Math.Abs(c - b));

			result = cb * Pro(a);
			Console.WriteLine(" ");
			Console.Write($"Result =  " + result);

			Console.ReadKey();
		}
	}
}

using System;
using System.Text;

namespace Binery
{
	class Program
	{
		static void Main(string[] args)
		{
			//   Task 1 

			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Представяне на числото 2024 в осмична и шеснайсетична бройна система");
			Console.WriteLine();

			int numberValue = 2024;
			string binery8 = Convert.ToString(numberValue, 8);
			string binery16 = Convert.ToString(numberValue, 16);

			Console.WriteLine("Числото 2024 в осмична бройна система => " + binery8);
			Console.WriteLine("Числото 2024 в шеснайсетична бройна система => " + binery16);
		}
	}
}

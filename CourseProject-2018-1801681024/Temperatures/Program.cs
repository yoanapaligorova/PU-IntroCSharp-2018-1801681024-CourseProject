using System;

namespace Temperatures
{
	class Program
	{
			// Task 6 - стр.220/397 

			/* a) Съставете програма, в която се дефинира метод Kalvin(t), в който формалният параметър t представлява температура в Целзиеви градуси,
			      а резултатът от метода е същата температура по Келвин, изчислена по формулата t+ 273,15;    */

			static double Kelvin(double t)
			{
				return t + 273.15;
			}

			/* б) Програма, в която се въвежда масив от до 31 числа в интервала [-50, 50] - средни дневни температури по Целзий за текущия месец  */
			static void Interval(double[] a)
			{
				for (int i = 0; i < a.Length; i++)
				{
					bool k;
					do
					{
						Console.Write("Enter the average t° for " + "day " + (i + 1) + " from this month " + " => ");
						k = double.TryParse(Console.ReadLine(), out a[i]);
					}
					while (!k || a[i] < -50 || a[i] > 50);
				}
			}
			static void Main(string[] args)
			{
				DateTime today = DateTime.Now;
				Console.WriteLine(today);
			    double[] a = new double[today.Day]; Interval(a);

				// в) Да се отпечата на екрана разликата максималната и минималната среднодневни температури: - в ( °C ) и в ( °K )

				double Min = a[0];
				double Max = a[0];
				for (int i = 1; i < today.Day; i++)
				{
					if (Min > a[i])
					{
						Min = a[i];
					}
					else if (Max < a[i])
					{
						Max = a[i];
					}
				}
				Console.WriteLine("  ");
				Console.WriteLine("The difference between max and min temperature in °C is : {0} ", Max - Min);
				Console.WriteLine("The difference between max and min temperature in °K is : {0} ", Kelvin(Max - Min));
				Console.WriteLine("  ");

				// г) Да се изведат на екрана всички среднодневни температури в Келвинови гардуси.

				Console.WriteLine("The temperatures for the current month in °K :");
				for (int i = 0; i < today.Day; i++)
					Console.WriteLine(Kelvin(a[i]));
			}
	}
}

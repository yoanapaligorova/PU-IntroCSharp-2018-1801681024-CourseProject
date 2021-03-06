﻿using System;

namespace NumberToWords
{
	class Program
	{
			public static string NumberToWords(int number)
			{
			//  Task 7
			// Условие => Съставете метод ,който при зададено число (до 9 цифри) връща записа на това число с думи. - стр.210 / 369

			if (number >= 1000000000)
				return "You must enter number up to 9 digits ";

				if (number == 0)
					return "zero";

				if (number < 0)
					return "Try again next time with positive number" ;
				
				string words = "";

				if ((number / 1000000) > 0)
				{
					words += NumberToWords(number / 1000000) + " million ";
					number %= 1000000;
				}

				if ((number / 1000) > 0)
				{
					words += NumberToWords(number / 1000) + " thousand ";
					number %= 1000;
				}

				if ((number / 100) > 0)
				{
					words += NumberToWords(number / 100) + " hundred ";
					number %= 100;
				}

				if (number > 0)
				{
					if (words != "")
						words += "and ";

					string[] from0to19 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
					string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

					if (number < 20)
						words += from0to19[number];
					else
					{
						words += tens[number / 10];
						if ((number % 10) > 0)
							words += " " + from0to19[number % 10];
					}
				}

				return words;
			}
			static void Main(string[] args)
			{
				Console.WriteLine("Enter number ");
				int number = int.Parse(Console.ReadLine());
				Console.WriteLine(NumberToWords(number));


			}
		}
}

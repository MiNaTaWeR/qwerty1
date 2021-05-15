using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите диапазон");
			int m = int.Parse(Console.ReadLine());


			int[] agro = new int[12];
			Random ran = new Random();
			for (int i = 0; i < 12; i++)
			{
				agro[i] = ran.Next(m);
				Console.Write(agro[i] + " ");
			}
			for (int i = 0; i < 12; i++)
			{
				for (int j = 1; j < 12 - i; j++)
					if (agro[j-1] > agro[j])
					{
						int t = agro[j];
						agro[j] = agro[j - 1];
						agro[j - 1] = t;
					}
			}
			Console.WriteLine("");
			for (int i = 0; i < 12; i++)
			{
				Console.Write(agro[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Введите число которое вы хотите найти:");
			int f = int.Parse(Console.ReadLine());
			for (int i = 0; i < 12; i++)
			{
				if (agro[i] == f)
				{
					Console.WriteLine("Число " + f +" найдено");
				}
				else Console.WriteLine("Такого числа нет");
			}
			Console.ReadKey();
		}
	}
}

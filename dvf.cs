using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите диапазон");
			int m = int.Parse(Console.ReadLine());


			int[] agro = new int[10];
			Random ran = new Random();
			for (int i = 0; i < 10; i++)
			{
				agro[i] = ran.Next(m);
				Console.Write(agro[i] + " ");
			}
			for (int i = 0; i < 10; i++)
			{
				for (int j = 1; j < 10 - i; j++)
					if (agro[j-1] > agro[j])
					{
						int t = agro[j];
						agro[j] = agro[j - 1];
						agro[j - 1] = t;
					}
			}
			Console.WriteLine("");
			for (int i = 0; i < 10; i++)
			{
				Console.Write(agro[i] + " ");
			}
			Console.WriteLine();
			Console.WriteLine("Введите число которое вы хотите найти:");
			int f = int.Parse(Console.ReadLine());
			int d = -1;
			for (int i = 0; i < 10; i++)
			{
				if (agro[i] == f)
				{
					d = i;
					break;
				}
			}
			if (d == -1) Console.WriteLine("Токого значения нет");
			else Console.WriteLine("Число " + d + " найдено");
			Console.ReadKey();
		}
	}
}

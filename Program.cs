using System;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите диапазон");
			int m = int.Parse(Console.ReadLine());


			int[] agro = new int[5];
			Random ran = new Random();
			for (int i = 0; i < 5; i++)
			{
				agro[i] = ran.Next(m);
				Console.Write(agro[i] + " ");
			}
			for (int i = 0; i < 5; i++)
			{
				for (int j = 1; j < 5 - i; j++)
					if (agro[j] > agro[j-1])
					{
						int t = agro[j];
						agro[j] = agro[j - 1];
						agro[j - 1] = t;
					}
			}
			Console.WriteLine("");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(agro[i] + " ");
			}
			Console.WriteLine();
		}
	}
}

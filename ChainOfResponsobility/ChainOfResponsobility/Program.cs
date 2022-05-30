using System;
using System.Threading;

namespace ChainOfResponsobility
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лабораторная работа номер 18 выполнена Горьковым Алексеем";
			
			Bank WesternUnion = new Bank("Western Union");
			Bank UniStream = new Bank("UniStream");
			Bank PayPal = new Bank("PayPal");

			Reciever[] recievers = new Reciever[]
			{
				new Reciever("Петров", WesternUnion),
				new Reciever("Сергеев", UniStream), new Reciever("Лавров", PayPal)
			};

			char cancel = 'n';

			while (cancel == 'n')
			{
				start:
				Console.WriteLine("Выберите пользователя:");
				for (int i = 0; i < recievers.Length; i++)
				{
					var reciever = recievers[i];
					Console.WriteLine((i+1) + " - " + reciever.name);
				}

				int choice = Convert.ToInt32(Console.ReadLine());
				choice--;
				if (choice <= recievers.Length)
				{
					Console.Write("Введите сумму - ");
					int sum = Convert.ToInt32(Console.ReadLine());
					recievers[choice].makeTransaction(sum);
				}
				else
				{
					Console.WriteLine("Такого пользователя не существует");
					goto start;
				}

				Console.WriteLine("Завершить программу? y/n");
				cancel = Convert.ToChar(Console.ReadLine());
			}
		}
	}
}
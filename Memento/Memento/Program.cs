using System;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лабораторная работа номер 20 выполнена Горьковым Алексеем";

			Console.Write("Выберите начальное число - ");
			
			Number number = new Number(Convert.ToInt32(Console.ReadLine()));
			CareTaker care_taker = new CareTaker(number);
			care_taker.backup();
			ConsoleKey key = Console.ReadKey().Key;
			
			do
			{
				if (key == ConsoleKey.PageUp)
				{
					number.increase();
					care_taker.backup();
				}
				
				else if (key == ConsoleKey.PageDown)
				{
					care_taker.undo();
				}
				
				key = Console.ReadKey().Key;
			} while (key != ConsoleKey.Escape);
			
		}
	}
}
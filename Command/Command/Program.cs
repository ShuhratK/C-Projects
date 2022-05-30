using System;
using System.IO;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лабораторная работа №14 выполнил Горьков Алексей";
			
			EasyCommand getNumbers = new EasyCommand();

			HardCommand write = new HardCommand(getNumbers.num1,getNumbers.num2);
			
			write.execute();
			
			
		}
	}
}
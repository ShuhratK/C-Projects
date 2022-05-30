using System;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			IMathOperationStrategy[] strategies = new IMathOperationStrategy[] 
				{new AdditonStrategy(), new MultiplicationStrategy(), new PowerStrategy()};


			for (int i = 0; i < strategies.Length; i++)
			{
				Console.WriteLine($" {strategies[i].opName} 2 и 2 {strategies[i].operation(2, 2)}");
			}
		}
	}
}
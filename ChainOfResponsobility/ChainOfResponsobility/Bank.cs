using System;

namespace ChainOfResponsobility
{
	public class Bank
	{
		private string name;

		public Bank(string name)
		{
			this.name = name;
		}

		public void confirmTransaction(string name, int sum)
		{
			Console.WriteLine($"Переведено пользователю {name}, {sum}$, через {this.name}");
		}
	}
}
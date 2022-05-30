using System;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лабораторная работа номер 21 выполнена Горьковым Алексеем";

			IClient[] clients = new IClient[] {new House(), new Bank(), new Plant()};
			Visitor visitor = new Visitor();
			for (int i = 0; i < clients.Length; i++)
			{
				clients[i].accept(visitor);
			}
		}
	}
}
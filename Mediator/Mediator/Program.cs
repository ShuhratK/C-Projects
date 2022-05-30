using System;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лабораторная работа номер 19 выполнена Горьковым Алексеем";
			Mediator mediator = new Mediator();
			NumberGenerator number_generator = new NumberGenerator(mediator);
			number_generator.generateNumbers();
			
		}
	}
}
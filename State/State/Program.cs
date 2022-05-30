using System;

namespace State
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = "Лаюораторная работа номер 17 выполнена Горьковым Алексеем";
		
			Matter matter = new Matter(State.gas);
			matter.cool();
			matter.cool();
			matter.cool();
			matter.warm();
			matter.cool();
			matter.warm();
			matter.warm();

			Console.WriteLine($"Состояние объекта - {matter.getState()}");
		}
	}
	
	
}


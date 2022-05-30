using System;

namespace Visitor
{
	public class Visitor
	{
		public void visit(House house)
		{
			Console.WriteLine($"Для {house.name} - медицинская страховка");
		}
		
		public void visit(Bank bank)
		{
			Console.WriteLine($"Для {bank.name} - страховка от ограбления");
		}
		
		public void visit(Plant plant)
		{
			Console.WriteLine($"Для {plant.name} - страховка от пожара и наводнения");
		}
	}
}
using System;

namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library(new String[]
			{
				"Война и мир", "Алхимик", "Гиперболоид инженера Гарина",
				"Остров Сокровищ", "Гамлет", "Тобол", "Продавец Воздуха"
			});
			Console.WriteLine("Перебор по алфавитному порядку");
			Library.iterate(library.alphabateic_iterator);
			Console.WriteLine();
			Console.WriteLine("Перебор по обратному алфавитному порядку");
			Library.iterate(library.reverse_alphabetic_iterator);
			Console.WriteLine();
			Console.WriteLine("Перебор по порядку заполнения");
			Library.iterate(library.order_iterator);
			Console.WriteLine();
		}
	}
}
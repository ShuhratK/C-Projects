using System;
using System.IO;

namespace Command
{
	abstract public class Command
	{
		public abstract void execute();
	}

	public class EasyCommand : Command
	{
		public int num1;
		public int num2;

		public EasyCommand()
		{
			execute();
		}
		
		public override void execute()
		{
			Console.Write("Введите первое число - ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число - ");
			num2 = Convert.ToInt32(Console.ReadLine());
		}
	}
	
	
	public class HardCommand : Command
	{
		private int num1, num2;

		
		public HardCommand(int num1,int num2)
		{
			this.num1 = num1;
			this.num2 = num2;
		}

		public override void execute()
		{
			string path = @"С:\command.txt";
			/*
			FileInfo file_info = new FileInfo(path);
			file_info.Create();
			FileStream file_stream = new FileStream(path,FileMode.Create);
			*/
			int product = num1 * num2;

			Console.WriteLine($"Произведение чисел равно {product}");

			string text = Convert.ToString(product);
            
			using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
			{
				byte[] array = System.Text.Encoding.Default.GetBytes(text);
				fstream.Write(array, 0, array.Length);
				Console.WriteLine(@"Результат смотри в файле C:\command.txt");
			}
		}
	}
}
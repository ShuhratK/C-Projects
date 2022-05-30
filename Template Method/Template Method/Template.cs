using System;
using System.Linq;

namespace Template_Method
{
	public abstract class Template
	{
		public void output_text(string text)
		{
			Console.WriteLine(text);
		}

		public void end()
		{
			Console.WriteLine("Работа программы завершена");
		}

		public abstract void output_reverse_text(string text);
		public abstract void replace_vowels(string text);
		public abstract void replace_words(string text);
		public abstract void add_underlines(string text);

	}

	public class ConcreteTemplate : Template
	{
		public override void output_reverse_text(string text)
		{
			string new_text = "";

			for (int i = text.Length - 1; i >= 0; i--)
			{
				new_text += text[i];
			}
			
			output_text(new_text);
		}

		public override void replace_vowels(string text)
		{
			char[] vowels = new char[] {'а','у','е','ы','о','э','я','и','ю'};

			string new_text = "";

			for (int i = 0; i < text.Length; i++)
			{
				if (vowels.Contains(text[i]))
				{
					new_text += "*";
				}
				else
				{
					new_text += text[i] ;
				}
			}
			
			output_text(new_text);
		}

		public override void replace_words(string text)
		{
			string[] words = text.Split(' ');
			words.Reverse();

			foreach (string word in words)
			{
				Console.Write(word);
				Console.Write(' ');
			}

			Console.WriteLine();
		}

		public override void add_underlines(string text)
		{
			char[] vowels = new char[] {'в','д'};

			string new_text = "";

			for (int i = 0; i < text.Length; i++)
			{
				if (vowels.Contains(text[i]))
				{
					new_text += '_';
				}
				else
				{
					new_text += text[i];
				}
			}
			
			output_text(new_text);
		}
	}
}
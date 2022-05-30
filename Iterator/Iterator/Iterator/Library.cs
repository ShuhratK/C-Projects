using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Iterator;

namespace Iterator
{
	public class Library
	{
		public string[] books;

		public AlphabeticIterator alphabateic_iterator { get; private set;}
		public AlphabeticIterator reverse_alphabetic_iterator{ get; private set;}
		public OrderIterator order_iterator{ get; private set;}

		public Library(string[] books)
		{
			this.books = books;
			
			alphabateic_iterator = new AlphabeticIterator(this);
			reverse_alphabetic_iterator = new AlphabeticIterator(this, true);
			order_iterator = new OrderIterator(this);
		}

		public static void iterate(IIterator iterator)
		{
			while (iterator.moveNext())
			{
				Console.WriteLine(iterator.current());
			}
		}
		
	}


	public class AlphabeticIterator : IIterator
	{
		private Library library;
		private bool reverse;
		private List<string> books;

		private int position = -1;


		public AlphabeticIterator(Library library, bool reverse = false)
		{
			this.library = library;
			this.reverse = reverse;

			books = library.books.ToList();
			books.Sort();
			
			
			if (reverse)
			{
				position = books.Count;
			}
		}

		public string current()
		{
			return books[position];
		}

		public bool moveNext()
		{
			int updatedPosition = position + (reverse ? -1 : 1);

			if (updatedPosition >= 0 && updatedPosition < books.Count)
			{
				position = updatedPosition;
				return true;
			}
			else
			{
				return false;
			}
			
			
		}

		public void reset()
		{
			position = reverse ? books.Count - 1 : 0;
		}
	}

	public class OrderIterator : IIterator
	{
		
		private Library library;
		private int position = 0;


		public OrderIterator(Library library)
		{
			this.library = library;
		}

		public string current()
		{
			return library.books[position];
		}

		public bool moveNext()
		{
			int updatedPosition = position += 1;

			if (updatedPosition < library.books.Length)
			{
				position = updatedPosition;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void reset()
		{
			position = 0;
		}
	}
}
	

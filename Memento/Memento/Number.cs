using System;
using System.Collections.Generic;

namespace Memento
{
	public class Number
	{
		public int value;
		private int iterations = 0;

		public Number(int value)
		{
			this.value = value;
		}

		public void increase()
		{
			iterations++;
			value *= 2;
			Console.WriteLine($"Шаг номер {iterations}, результат {value}");
		}

		public Memento save()
		{
			return new Memento(value, iterations);
		}

		public void restore(Memento memento)
		{
			this.value = memento.value;
			this.iterations = memento.iterations;
			Console.WriteLine($"Шаг номер {iterations}, результат {value}");
		}

		public class Memento
		{
			public int value;
			public int iterations;
			
			public Memento(int value, int iterations)
			{
				this.value = value;
				this.iterations = iterations;
			}
		}
	}

	public class CareTaker
	{
		List<Number.Memento> history = new List<Number.Memento>();

		private Number originator;
		
		public CareTaker(Number originator)
		{
			this.originator = originator;
		}

		public void backup()
		{
			history.Add(originator.save());
		}

		public void undo()
		{
			if (history.Count > 1)
			{
				originator.restore(history[history.Count-2]);
				history.RemoveAt(history.Count-1);
			}
		}
	}
}
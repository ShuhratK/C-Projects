using System;

namespace Mediator
{
	public interface IMediator
	{
		
		public void notify(int[] nums);
	}

	public class Mediator : IMediator
	{
		private IStrategy[] strategies = new IStrategy[]{new SumStrategy(), new MedianStrategy(), 
			new MaxStrategy(), new MinStrategy()};

		public void notify(int[] nums)
		{
			Console.WriteLine("Выберите метод из четырёх 1-4");
			int index = Convert.ToInt32(Console.ReadLine()) - 1;
			Console.WriteLine(strategies[index].name + " " + strategies[index].operation(nums));
		}
	}

	public class NumberGenerator
	{
		private IMediator mediator;
		
		public NumberGenerator(IMediator mediator)
		{
			this.mediator = mediator;
		}

		public void generateNumbers()
		{
			int[] nums = new int[10];

			Random random = new Random();
			
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = random.Next(0, 10);
			}
			
			mediator.notify(nums);
		}
	}
}
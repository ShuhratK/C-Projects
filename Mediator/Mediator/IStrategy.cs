using System.Linq;

namespace Mediator
{
	public interface IStrategy
	{
		public string name { get; set; }
		
		public int operation(int[] nums);
	}
	
}

namespace Mediator
{
	public class SumStrategy:IStrategy
	{
		public string name { get; set; } = "Сумма";
		
		public int operation(int[] nums)
		{
			int sum = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];

			}

			return sum;
		}
	}

	public class MedianStrategy:IStrategy
	{

		public string name { get; set; } = "Среднее значение";
		public int operation(int[] nums)
		{
			int sum = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];

			}

			return sum / nums.Length;
		}
	}

	public class MaxStrategy:IStrategy
	{
		public string name { get; set; } = "Максимальное значение";
		
		public int operation(int[] nums)
		{
			return nums.Max();
		}
	}

	public class MinStrategy:IStrategy
	{
		public string name { get; set; } = "Минимальное значение";
		
		public int operation(int[] nums)
		{
			return nums.Min();
		}
	}
}
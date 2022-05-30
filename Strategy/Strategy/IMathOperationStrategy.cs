using System;

namespace Strategy
{
	public abstract class IMathOperationStrategy
	{
		public virtual string opName { get;protected set; }
		public abstract double operation(double num1, double num2);
	}

	public class AdditonStrategy : IMathOperationStrategy
	{
		public override string opName { get; protected set; } = "Сложение";

		public override double operation(double num1, double num2)
		{
			return num1 + num2;
		}
	}
	
	public class MultiplicationStrategy : IMathOperationStrategy
	{
		
		public override string opName { get; protected set; } = "Умножение";
		public override double operation(double num1, double num2)
		{
			return num1 * num2;
		}
	}
	
	public class PowerStrategy : IMathOperationStrategy
	{
		public override string opName { get; protected set; } = "Степень";
		
		public override double operation(double num1, double num2)
		{
			return Math.Pow(num1,num2);
		}
	}
}
namespace ChainOfResponsobility
{
	public class Reciever
	{
		private Bank bank;
		public string name { get; private set; }
		
		public Reciever(string name,Bank bank)
		{
			this.name = name;
			this.bank = bank;
		}

		public void makeTransaction(int sum)
		{
			bank.confirmTransaction(name, sum);
		}
	}
}
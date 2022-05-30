namespace Visitor
{
	public interface IClient
	{
		public string name { get; set; }
		public void accept(Visitor visitor);
	}

	public class House : IClient
	{
		public string name { get;  set; } = "House";
		
		public void accept(Visitor visitor)
		{
			visitor.visit(this);
		}
	}

	public class Bank : IClient
	{
		public string name { get;  set; } = "Bank";
		
		public void accept(Visitor visitor)
		{
			visitor.visit(this);
		}
	}

	public class Plant : IClient
	{
		public string name { get; set; } = "Plant";
		
		public void accept(Visitor visitor)
		{
			visitor.visit(this);
		}
	}
}
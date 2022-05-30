namespace Iterator
{
	public interface IIterator
	{
		public string current();
		public bool moveNext();
		public void reset();
	}
}
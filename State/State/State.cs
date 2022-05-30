using System;

namespace State
{
	public class Matter
	{
		private State state;

		public Matter(State state) => this.state = state;

		public void warm()
		{
			switch (state)
			{
				case State.liguid:
					state = State.gas;
					break;
				case State.solid:
					state = State.liguid;
					break;
				case State.gas:
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			Console.WriteLine("Объект подогрет");
		}

		public void cool()
		{
			switch (state)
			{
				case State.liguid:
					state = State.solid;
					break;
				case State.solid:
					break;
				case State.gas:
					state = State.liguid;
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}

			Console.WriteLine("Объект охлаждён");
		}

		public string getState()
		{
			switch (state)
			{
				case State.liguid:
					return "Жидкое";
				case State.solid:
					return "Твёрдое";
				case State.gas:
					return "Газообразное";
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}

	public enum State
	{
		solid,
		liguid,
		gas
	}
}
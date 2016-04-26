using System;

namespace Xerox
{
	interface IMachine
	{
		public bool print(List<Item> item);
		public bool staple(List<Item> item);
		public bool fax(List<Item> item);
	}
	public class Machine
	{
		public Machine ()
		{
		}
	}
}


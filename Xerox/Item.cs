using System;

namespace Xerox
{
	public class Item
	{
		int _numberOfItems;
		public Item (int numberOfItems)
		{
			_numberOfItems = numberOfItems;
		}
		public int Count() {
			return _numberOfItems;
		}
	}
}


using System;

namespace Xerox
{
	// (The following interfaces are called as &ldquo;Role Interfaces&rdquo; as they serve their roles :))

	public interface IPrinter
	{
		bool Print(List<Item> Items);
	}

	class Printer : IPrinter
	{
		public bool Print(List<Item> Items)
		{
			foreach(var item in Item)
				print(item);
		}

		//Other definitions...
	}

	public interface IStaple
	{
		bool DoStaple(List<Item> Items);
	}

	class Staple : IStaple
	{
		public bool DoStaple(List<Item> Items)
		{
			foreach(var item in Items) 
				Staple(item);
		}

		//Other definitions...
	}
	public interface IFax
	{    
		bool DoFax(List<Item> Items);
	}

	class Fax : IFax
	{
		public bool DoFax(List<Item> Items)
		{
			foreach(var item in Items) 
				Fax(item);
		}

		//Other definitions...
	}

	public interface IScan
	{
		bool DoScan(List<Item> Items);
	}

	class Scan : IScan
	{
		public bool DoScan(List<Item> Items)
		{
			foreach(var item in Items)
				Scan(item);
		}

		//Other definitions...
	}

	public interface IPhotoCopy
	{
		bool DoPhotoCopy(List<Item> Items);
	}

	class PhotoCopy : IPhotoCopy
	{
		public bool DoPhotoCopy(List<Item> Items)
		{
			foreach(var item in Items)
				PhotoCopy(item);
		}

		//Other definitions...
	}

	public interface IMachine : IPrinter, IFax, IScan, IPhotoCopy,IStaple
	{
		bool print(List<Item> item);
		bool Dostaple(List<Item> item);
		bool Dofax(List<Item> item);
		bool Doscan(List<Item> item);
		bool DophotoCopy(List<Item> item);
	}

	class Machine : IMachine
	{
		private IPrinter printer {get;set;}
		private IFax fax {get;set;}
		private IScan scan  {get;set;}
		private IPhotoCopy photoCopy {get;set;}
		private IStaple staple {get;set;}

		// Notice how the dependencies are injected through constructor (constructor dependency injection)
		public  Machine(IPrinter printer, IFax fax, IScan scan, IPhotoCopy photoCopy, IStaple staple)
		{
			this.printer = printer;
			this.fax = fax;    
			this.scan = scan;
			this.photoCopy = photoCopy;
			this.staple = staple;
		}

		public bool print(List<Item> item)
		{ 
			printer.Print (item);
		}

		public bool Dostaple(List<Item> item) 
		{
		}

		public bool Dofax(List<Item> item) 
		{
			// Fax the items.
			Console.WriteLine("All Items Faxed" + item.Count());
		}

		public bool Doscan(List<Item> item) 
		{
			// Scan the items.
			Console.WriteLine("All Items Scanned" + item.Count());
		}

		public bool DophotoCopy(List<Item> item) 
		{
			// Xerox the items.
			Console.WriteLine("All Items Photo copied" + item.Count()); 
		}
	}
}


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
			foreach (Item item in Items) {
				Console.WriteLine ("All Items printed" + item.Count ()); 
			}
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
			foreach (Item item in Items) {
				Console.WriteLine ("All Items Stapled" + item.Count ()); 
			}
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

			// Fax the items.
			foreach (Item item in Items) {
				Console.WriteLine ("All Items Faxed" + item.Count ());
			}
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

			foreach (Item item in Items) {
				Console.WriteLine ("All Items Scanned" + item.Count ());
			}
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

			foreach (Item item in Items) {
				Console.WriteLine ("All Items Photo copied" + item.Count ()); 
			}
		}

		//Other definitions...
	}

	public interface IPrinterScanner : IPrinter, IScan {
		
	}

	public interface I : IPrinter, IScan {

	}


	class Machine
	{
		public IPrinter printer {get;set;}
		public IFax fax {get;set;}
		public IScan scan  {get;set;}
		public IPhotoCopy photoCopy {get;set;}
		public IStaple staple {get;set;}

		//(constructor dependency injection)
		public  Machine(IPrinter printer, IFax fax, IScan scan, IPhotoCopy photoCopy, IStaple staple)
		{
			this.printer = printer;
			this.fax = fax;    
			this.scan = scan;
			this.photoCopy = photoCopy;
			this.staple = staple;
		}

	}
}


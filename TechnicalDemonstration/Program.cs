using System;
using System.IO;

namespace Medica.Uk.TechnicalDemonstration
{
    public static class Program
	{
		static void Main(string[] args)
		{

			string? readFile = null;
			if (args.Length == 0) {
				while(readFile == null) {
					Console.WriteLine("Enter File to open.");
					readFile = Console.ReadLine();
				}
			} else
				readFile = args[0];
			
			if (readFile.ToLower().EndsWith("json"))
				new ReadJson(readFile);
			else
				new ReadCSV(readFile);
		}
	}
}

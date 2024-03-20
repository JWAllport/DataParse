using System;
using System.IO;

namespace Medica.Uk.TechnicalDemonstration
{
	public static class Program
	{
		static void Main(string[] args)
		{
			ReadJson readJson = new ReadJson("users_1k.json");

			ReadCSV readCSV = new ReadCSV("customers.csv");
		}
	}
}

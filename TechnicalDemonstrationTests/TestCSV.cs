using System.Text;
using System.Text.Unicode;
using CsvHelper.Configuration.Attributes;
using NUnit;

namespace TechnicalDemonstrationTests
{
	public class TestPlaceholderCSV
	{
		// Single Row CSV w/ Heading
		[Test]
		public void OneRecordCSVTest()
		{
			FileStream var = File.Create("test.csv");
			byte[] headings = new UTF8Encoding(true).GetBytes("Name, Age, Marital Status, Housing, Employment Status");
			byte[] newLine = new UTF8Encoding(true).GetBytes("\n");
        	byte[] generalInfo = new UTF8Encoding(true).GetBytes("Bob, 44, Married, Home-Owner, Employed");

			var.Write(headings);
			var.Write(newLine);
			var.Write(generalInfo);
			var.Close();
			
			ReadCSV rCSV = new ReadCSV(var.Name);
           	Assert.That(rCSV.getRecordCount, Is.EqualTo(1));

			File.Delete("test.csv");
		}

		// Single Row CSV w/OUT Heading
		[Test]
		public void DefaultFailingPlaceholderTest2()
		{
			
			
		}

		[Test]
		public void EmptyRecordTest()
		{
			FileStream var = File.Create("test.csv");
			var.Close();
			
			ReadCSV rCSV = new ReadCSV(var.Name);
           	Assert.That(rCSV.getRecordCount(), Is.EqualTo(0));

			File.Delete("test.csv");
		}

		[Test]
		public void BadFileTest()
		{
			FileStream var = File.Create("test.xml");

			byte[] data = new UTF8Encoding(true)
			.GetBytes("<note>" + "\n" +
					"<to>Tove</to>" + "\n" +
					"<from>Jani</from>" + "\n"  +
					"<heading>Reminder</heading>" + "\n" +
					"<body>Don't forget me this weekend!</body>" + "\n" +
					"</note>");
			var.Write(data);
			var.Close();
			
			Assert.Throws<InvalidDataException>(() => new ReadCSV(var.Name));


			File.Delete("test.xml");
		}
	}
}
using System.Text;

namespace TechnicalDemonstrationTests
{
	public class TestJSON
	{
		[Test]
		public void OneRecordJSONTest()
		{
			FileStream var = File.Create("test.json");
			byte[] data = new System.Text.UTF8Encoding(true).GetBytes("[{\"id\":0,\"name\":\"Daniel\",\"city\":\"San Diego\",\"age\":48,"
			+ "\"friends\":[{\"name\":\"Charlotte\",\"hobbies\":[\"Quilting\",\"Writing\",\"Music\"]},"
			+ "{\"name\":\"Levi\",\"hobbies\":[\"Gardening\",\"Music\"]},{\"name\":\"Elijah\",\"hobbies\":[\"Video Games\",\"Writing\"]},"
			+"{\"name\":\"Isabella\",\"hobbies\":[\"Writing\",\"Gardening\",\"Video Games\"]}]}]");

			var.Write(data);
			var.Close();
			
			ReadJson rJSON = new ReadJson(var.Name);
           	Assert.That(rJSON.getRecordCount(), Is.EqualTo(1));

			File.Delete("test.csv");

		}

		[Test]
		public void EmptyJSONTest()
		{
			FileStream var = File.Create("test.json");
			var.Close();
			
			ReadJson rJSON = new ReadJson(var.Name);
           	Assert.That(rJSON.getRecordCount(), Is.EqualTo(0));
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
			
			Assert.Throws<InvalidDataException>(() => new ReadJson(var.Name));


			File.Delete("test.xml");		}

		[Test]
		public void DataWithNullValuesTest()
		{

			FileStream var = File.Create("test.json");
			
			byte[] data = new System.Text.UTF8Encoding(true).GetBytes(
				"[{\"id\":null,\"name\":null,\"city\":null,\"age\":null}]");

			var.Write(data);
			var.Close();
			ReadJson rJSON = new ReadJson(var.Name);
			Assert.That(rJSON.getRecordCount(), Is.EqualTo(1));

			File.Delete("test.xml");
		
		}
	}
}
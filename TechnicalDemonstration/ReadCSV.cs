using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

public class ReadCSV {

    public ReadCSV(string csvFile) {
        
        StreamReader sr = new StreamReader(csvFile);
    
		var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<Customer>().ToList();
    }
}
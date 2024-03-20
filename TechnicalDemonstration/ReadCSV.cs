using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

public class ReadCSV {

    private int recordCount;

    public ReadCSV(string readFile) {
        if (!readFile.ToLower().EndsWith("csv"))
            throw new InvalidDataException("File is not a CSV");
        
        var records = SetRecords(readFile);

        records.ForEach(foo =>{

            IDictionary<string, object?> dict = foo;
            foreach (var key in dict.Keys) {
                Console.WriteLine(key + ": " + dict[key]);
            }
          
            Console.WriteLine("\n");
        });
    }

    public List<dynamic> SetRecords(string readFile) {
        StreamReader sr = new StreamReader(readFile);
	
        var csv = new CsvReader(sr, CultureInfo.InvariantCulture);

        var records = csv.GetRecords<dynamic>().ToList();
        setRecordSize(records);
        return records;
    }

    private void setRecordSize(List<dynamic> records)
    {
        this.recordCount = records.Count;
    }

    public int getRecordCount() {
        return recordCount;
    } 
}
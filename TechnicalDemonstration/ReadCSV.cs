using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

public class ReadCSV {

    private string readFile;
    private List<dynamic>? records;

    public ReadCSV(string readFile) {
        if (!readFile.ToLower().EndsWith("csv"))
            throw new InvalidDataException("File is not a CSV");
        
        this.readFile = readFile;
        setRecords();
    }

    public void setRecords() {
        StreamReader sr = new StreamReader(readFile);
		try {
        var csv = new CsvReader(sr, CultureInfo.InvariantCulture);

        this.records = csv.GetRecords<dynamic>().ToList();
        } catch(Exception e) {
             Console.WriteLine(e.Message);
        }
       

    }

    public int getRecordCount() {
        if (records == null)
            return 0;
        return records.Count;
    } 

    public void setReadFile(string readFile) {
        this.readFile = readFile;
    }
    private string getReadFile() {
        return this.readFile;
    }
}
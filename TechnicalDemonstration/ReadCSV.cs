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
        this.readFile = readFile;
        setRecords();
    }

    public void setRecords() {
        StreamReader sr = new StreamReader(readFile);
		var csv = new CsvReader(sr, CultureInfo.InvariantCulture);

        records = csv.GetRecords<dynamic>().ToList();

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
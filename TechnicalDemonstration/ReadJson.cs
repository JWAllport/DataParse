using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ReadJson {
    
    private int recordCount = 0;
    public ReadJson(string readFile) {
        
         if (!readFile.ToLower().EndsWith("json"))
            throw new InvalidDataException("File is not a JSON");
        

        string text = File.ReadAllText(readFile);
        var results = JsonConvert.DeserializeObject<List<dynamic>>(text);
        if (results != null)
            recordCount = results.Count;
        
        results.ForEach(foo => {
            Console.WriteLine(foo);
        });

    }

    public int getRecordCount() {
        return recordCount;
    }


}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        // var settings = new JsonSerializerSettings
        // {
        //     NullValueHandling = NullValueHandling.Ignore
        // };

        var results = JsonConvert.DeserializeObject<List<dynamic>>(text);
        parseFile(results);
        setRecordCount(results);

        string log = parseFile(results);
        File.WriteAllText("json_"+"log.txt", log);

    }

    private string parseFile(List<dynamic>? results)
    {
          StringBuilder sb = new StringBuilder();
          results?.ForEach(foo => {
                IDictionary<string, JToken> dic = foo;
                foreach(var key in dic.Keys) {
                    var value = dic[key];
                    sb.Append(key + ": " + dic[key] + " ");

                }
                sb.AppendLine();
            });
        return sb.ToString();
    }

    private void setRecordCount(List<dynamic>? results)
    {
        if (results != null)
            this.recordCount = results.Count;
        else 
            this.recordCount = 0;
    }

    public int getRecordCount() {
        return recordCount;
    }


}
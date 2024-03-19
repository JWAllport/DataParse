using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class ReadJson {
    
    public ReadJson(string json) {
        
        var results = JsonConvert.DeserializeObject<List<dynamic>>(json);
        
        
    }


}
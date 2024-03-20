using System;
using System.Collections.Generic;

[Obsolete] // transitioned to using dynaic type when reading data from file
    public class Friend
    {
        public string name { get; set; }
        public List<string> hobbies { get; set; }
    }

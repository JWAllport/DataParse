using System;
using System.Collections.Generic;

[Obsolete] // using dynamic type in reading of data file
public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public List<Friend> friends { get; set; }
    }
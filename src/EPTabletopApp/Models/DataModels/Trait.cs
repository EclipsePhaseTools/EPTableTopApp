﻿using System.Collections.Generic;

namespace EPTabletopApp.Models
{
    public class Trait
    {
        public string name { get; set; }
        public string type { get; set; }
        public List<int> cost { get; set; }
        public bool ego { get; set; }
        public bool morph { get; set; }
        public string summary { get; set; }
        public string description { get; set; }
        public bool auto { get; set; }
        public bool noted { get; set; }
        public string resource { get; set; }
        public string reference { get; set; }
        public string id { get; set; }
    }
}

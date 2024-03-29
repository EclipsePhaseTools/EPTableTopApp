﻿namespace EPTabletopApp.Models
{
    public class GearCategories
    {
        public string name { get; set; }
        public string text { get; set; }
        public GearSubcategories subcategories { get; set; }
        public string id { get; set; }
        public string reference { get; set; }
        public string resource { get; set; }
    }

    public class GearSubcategories
    {
        public string name { get; set; }
        public string text { get; set; }
    }
}

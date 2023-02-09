namespace EPTools.Models
{
    public class GearCategories
    {
        public string name { get; set; } = String.Empty;
        public string text { get; set; } = String.Empty;
        public GearSubcategories subcategories { get; set; } = new GearSubcategories();
        public string id { get; set; } = String.Empty;
        public string reference { get; set; } = String.Empty;
        public string resource { get; set; } = String.Empty;
    }

    public class GearSubcategories
    {
        public string name { get; set; } = String.Empty;
        public string text { get; set; } = String.Empty;
    }
}

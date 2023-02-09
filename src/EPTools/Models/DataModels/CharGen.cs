namespace EPTools.Models
{
    public class CharGen
    {
        public string step_name { get; set; } = String.Empty;
        public CharGenGuidance guidance { get; set; } = new CharGenGuidance();
        public string resource { get; set; } = String.Empty;
        public string reference { get; set; } = String.Empty;
        public string id { get; set; } = String.Empty;
    }

    public class CharGenGuidance
    {
        public string heading { get; set; } = String.Empty;
        public string text { get; set; } = String.Empty;
    }
}

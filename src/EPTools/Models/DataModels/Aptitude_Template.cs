namespace EPTools.Models
{
    public class Aptitude_Template
    {
        public string name { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
        public Aptitude_Template_Aptitude aptitudes { get; set; } = new Aptitude_Template_Aptitude();
        public string resource { get; set; } = String.Empty;
        public string reference { get; set; } = String.Empty;
        public string id { get; set; } = String.Empty;
    }

    public class Aptitude_Template_Aptitude
    {
        public int cognition { get; set; }
        public int intuition { get; set; }
        public int reflexes { get; set; }
        public int savvy { get; set; }
        public int somatics { get; set; }
        public int willpower { get; set; }
    }
}

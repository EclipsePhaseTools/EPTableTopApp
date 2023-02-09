namespace EPTools.Models
{
    public class Career
    {
        public string name { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
        public List<InterestSkill> skills { get; set; } = new List<InterestSkill>();
        public string resource { get; set; } = String.Empty;
        public string reference { get; set; } = String.Empty;
        public string id { get; set; } = String.Empty;
    }
}

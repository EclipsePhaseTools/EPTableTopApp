namespace EPTools.Models
{
    public abstract class Gear
    {
        public string category { get; set; } = String.Empty;
        public string subcateory { get; set; } = String.Empty;
        public string name { get; set; } = String.Empty;
        public string complexity { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
        public string id { get; set; } = String.Empty;
        public string reference { get; set; } = String.Empty;
        public string resource { get; set; } = String.Empty;
        public string summary { get; set; } = String.Empty;
    }
}
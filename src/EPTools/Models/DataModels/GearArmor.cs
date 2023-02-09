namespace EPTools.Models
{
    public class GearArmor : Gear
    {
        public string waretype { get; set; } = String.Empty;
        public int energy { get; set; }
        public int kenetic { get; set; }
        public bool stackable { get; set; }
    }
}

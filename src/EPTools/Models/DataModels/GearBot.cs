namespace EPTools.Models
{
    public class GearBot : Gear
    {
        public int vigor { get; set; }
        public int vigor2 { get; set; }
        public int flex { get; set; }
        public int armor_energy { get; set; }
        public int armor_kenetic { get; set; }
        public int wound_threshold { get; set; }
        public int durability { get; set; }
        public int death_rating { get; set; }
        public MorphMovementRates movement_rate { get; set; } = new MorphMovementRates();
        public string size { get; set; } = String.Empty;
        public List<string> ware { get; set; } = new List<string>();
    }
}

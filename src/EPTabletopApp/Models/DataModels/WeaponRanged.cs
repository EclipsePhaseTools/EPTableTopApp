﻿namespace EPTabletopApp.Models
{
    public class WeaponRanged : Gear
    {
        public string waretype { get; set; }
        public string damage { get; set; }
        public string damage_avg { get; set; }
        public string firemodes { get; set; }
        public int ammo { get; set; }
        public int range { get; set; }
        public string notes { get; set; }

    }
}

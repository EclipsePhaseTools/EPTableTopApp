﻿using System.Collections.Generic;

namespace EPTabletopApp.Models
{
    public class GearVehicle : Gear
    {
        public int passengers { get; set; }
        public int vigor { get; set; }
        public int flex { get; set; }
        public int armor_energy { get; set; }
        public int armor_kenetic { get; set; }
        public int wound_threshold { get; set; }
        public int durability { get; set; }
        public int death_rating { get; set; }
        public MorphMovementRates movement_rate { get; set; }
        public string size { get; set; }
        public List<string> ware { get; set; }
    }
}

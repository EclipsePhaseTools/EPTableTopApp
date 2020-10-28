using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPTabletopApp.Blazor.Models
{
    public class GearWare : Gear
    {
        public bool bioware { get; set; }
        public bool cyberware { get; set; }
        public bool hardware { get; set; }
        public bool meshware { get; set; }
        public bool nanoware { get; set; }
    }
}

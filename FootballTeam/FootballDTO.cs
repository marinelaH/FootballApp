using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam.FootballTeam
{
    // inherit all properties from SharedClass
    public class FootballDTO: SharedClass
    {
        public int ShortNumber { get; set; } // add new properties only for Football team
        
    }
}

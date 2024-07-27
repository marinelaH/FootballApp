using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam.CoachTeam
{
    // inherit all properties from SharedClass
    internal class CoachDTO: SharedClass
    {
        public int YearsOfExperience { get; set; } // add new property for CoachDTO
    }
}

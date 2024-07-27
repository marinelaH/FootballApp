using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam.CoachTeam
{
    internal interface ICoach
    {
        List<CoachDTO> GetCoaches();
    }
}

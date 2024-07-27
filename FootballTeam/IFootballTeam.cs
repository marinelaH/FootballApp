using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam.FootballTeam
{
    // create an interface for football team
    internal interface IFootballTeam
    {
        List<FootballDTO> GetFootballs();
        void InputPlayers(List<FootballDTO> players);
        List<FootballDTO> GetMaximumSalary();
    }
}

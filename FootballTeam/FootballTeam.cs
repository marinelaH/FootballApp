using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTeam.FootballTeam
{// this is a concret class, that it will implement all methods from interface (IFootballTeam)
    public class FootballTeam : IFootballTeam
    {
        // initialize a list of object that will contain all values that can add
        private List<FootballDTO> finalList = new List<FootballDTO>();
        public void InputPlayers(List<FootballDTO> players) 
        {
            finalList.AddRange(players);
        }
        public List<FootballDTO> GetFootballs()
        {
            return finalList;
        }

        public List<FootballDTO> GetMaximumSalary()
        {
            // display the 3 highest paid football player
            // first sort list using OrderByDescending()
            // take 3 values using Take()
            var data = finalList.OrderByDescending(x => x.Salary).Take(3).ToList();
            return data;
        }
    }
}

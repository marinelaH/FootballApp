using FootbalTeam.CoachTeam;
using FootbalTeam.FootballTeam;
using System.Numerics;

namespace FootbalTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CoachDTO
            CoachDTO coachDTO1 = new CoachDTO()
            {
                Name = "Coach1",
                Salary = 1522.00,
                Address = "Tirane",
                Code = "Abc",
                Position = "Coach",
                YearsOfExperience = 15
            };
            CoachDTO coachDTO2 = new CoachDTO()
            {
                Name = "Coach2",
                Salary = 1522.00,
                Address = "Tirane",
                Code = "Abc",
                Position = "Coach",
                YearsOfExperience = 25
            };

            List<CoachDTO> coachDTOs = new List<CoachDTO>();
            coachDTOs.Add(coachDTO1);
            coachDTOs.Add(coachDTO2);
            #endregion
            #region Football
            // create 2 object for FootballDTO
            FootballDTO footballDTO = new FootballDTO()
            {
                Name = "Football1",
                Code = "aaa",
                Salary = 16.2,
                Address = "Tirane",
                ShortNumber = 1,
                Position = "Sulmues",
            };

            FootballDTO footballDTO1 = new FootballDTO()
            {

                Name = "Football2",
                Code = "aaabb",
                Salary = 16.2,
                Address = "Tirane",
                ShortNumber = 2,
                Position = "Sulmues",

            };

            // create a new list of football and add object that created 
            List<FootballDTO> listOfFootball = new List<FootballDTO>();
            listOfFootball.Add(footballDTO1);
            listOfFootball.Add(footballDTO);


            // initialize FootballTeam class
            FootballTeam.FootballTeam footballTeam = new FootballTeam.FootballTeam();
            // call methods from FootballTeam class
            footballTeam.InputPlayers(listOfFootball); // this method will add values in a List
            footballTeam.GetFootballs(); // this method will display all football players that are created in InputPlayers() method
            #endregion


        }
    }
}

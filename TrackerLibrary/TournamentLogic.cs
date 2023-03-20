using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        //random order
        //checking if its big enough - if not, some of the teams get free entry to next stage
        //create matchups
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> RandomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(RandomizedTeams.Count);
            int empties = NumberOfEmpties(rounds, RandomizedTeams.Count);
        }
        private static List<MatchupModel> CreateFirstRound(int empties, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel currentModel = new MatchupModel();

            foreach (TeamModel team in teams)
            {

            }
            return output;
        }
        private static int NumberOfEmpties(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            //TODO check which logic is better
            //for (int i = 1; i <= rounds; i++)
            //{
            //    totalTeams *= 2;
            //}
            //output = totalTeams - numberOfTeams;
            output = 2 ^ rounds - numberOfTeams;
            return output;
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;

            while (val < teamCount)
            {
                output += 1;
                val *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder (List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}

﻿using System;
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

            model.Rounds.Add(CreateFirstRound(empties, RandomizedTeams));

            CreateOtherRounds(model, rounds);
        }
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            //round we start on
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match } );

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;

            }
        }
        private static List<MatchupModel> CreateFirstRound(int empties, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (empties > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (empties > 0)
                    {
                        empties -= 1;
                    }
                }
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

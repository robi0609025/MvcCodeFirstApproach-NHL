using CodeFirstPrimer.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstPrimer.Data
{
    public class DummyData
    {
        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team ()
                {
                    TeamName = "Canucks",
                    City = "Vancouver",
                    Province = "BC"
                },
                new Team()
                {
                    TeamName = "Oilers",
                    City = "Edmonton",
                    Province = "Alberta"
                },
                new Team()
                {
                    TeamName = "Flames",
                    City = "Calgary",
                    Province = "Alberta"
                }
            };
            return teams;
        }

        public static List<Player> GetPlayers(NhlContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    FirstName = "SVEN",
                    LastName = "BAERTSCHI",
                    TeamName = context.Teams.Find("Canucks").TeamName,
                    Position = "Forward"
                },
                new Player()
                {
                    FirstName = "HENRIK",
                    LastName = "SEDIN",
                    TeamName = context.Teams.Find("Canucks").TeamName,
                    Position = "Left Wing"
                },
                new Player()
                {
                    FirstName = "JOHN",
                    LastName = "ROOSTER",
                    TeamName = context.Teams.Find("Flames").TeamName,
                    Position = "Right Wing"
                },
                new Player()
                {
                    FirstName = "BOB",
                    LastName = "PLUMBER",
                    TeamName = context.Teams.Find("Oilers").TeamName,
                    Position = "Defense"

                }
            };
            return players;
        }
    }
}
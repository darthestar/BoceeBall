using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BoceeBall.Data;
using BoceeBall.Models;

namespace BoceeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbPlayers = new PlayersContext();

            //var player1 = new Players
            //{
            //    FullName = "Joe Jones",
            //    NickName = "JJ",
            //    PlayerNumber = "2",
            //    ThrowingArm = "Right",
            //};
            //var player2 = new Players
            //{
            //    FullName = "Moe Money",
            //    NickName = "MM",
            //    PlayerNumber = "3",
            //    ThrowingArm = "Left",
            //};

            //var stpeteteam = new Teams
            //{
            //    Mascot = "Seagulls",
            //    Colors = "Black and Yellow",
            //};
            //var tampateam = new Teams
            //{
            //    Mascot = "Monkeys",
            //    Colors = "Mustard",
            //};

            //dbPlayers.Players.Add(player1);
            //dbPlayers.Players.Add(player2);
            //dbPlayers.Teams.Add(stpeteteam);
            //dbPlayers.Teams.Add(tampateam);

            // assign a existing team ID to a new Player
            // query for team mascot
            // update Teams ID
            //var playerTeams = dbPlayers.Teams.First(team => team.Mascot == "Seagulls");

            //var player3 = new Models.Players
            //{
            //    FullName = "Kate Money",
            //    NickName = "KM",
            //    PlayerNumber = "13",
            //    ThrowingArm = "Left",
            //    TeamsID = playerTeams.Id
            //};

            //dbPlayers.Players.Add(player3);


            //var game1 = new Models.Games
            //{
            //    HomeTeamID = 1,
            //    AwayTeamID = 2,
            //    HomeScore = 20,
            //    AwayScore = 12,
            //    Date = new DateTime(2018, 04, 05),
            //    Notes = "Home Team advantage"
            //};
            //var game2 = new Models.Games
            //{
            //    HomeTeamID = 2,
            //    AwayTeamID = 1,
            //    HomeScore = 15,
            //    AwayScore = 12,
            //    Date = new DateTime(2018, 04, 15),
            //    Notes = "Home Team was on point tonight"
            //};

            //var game3 = new Models.Games
            //{
            //    HomeTeamID = 2,
            //    AwayTeamID = 1,
            //    HomeScore = 0,
            //    AwayScore = 0,
            //    Date = new DateTime(2018, 04, 28),
            //    Notes = ""
            //};
            //var game4 = new Models.Games
            //{
            //    HomeTeamID = 1,
            //    AwayTeamID = 2,
            //    HomeScore = 0,
            //    AwayScore = 0,
            //    Date = new DateTime(2018, 05, 08),
            //    Notes = ""
            //};

            //dbPlayers.Games.Add(game1);
            //dbPlayers.Games.Add(game2);
            //dbPlayers.Games.Add(game3);
            //dbPlayers.Games.Add(game4);

            dbPlayers.SaveChanges();

            //Update Player with Team ID
            var player4 = dbPlayers.Players.First(f => f.PlayerNumber == "2");

            player4.TeamsID = 2;
            dbPlayers.SaveChanges();

            var playerupdate = dbPlayers.Players.Where(p => p.FullName == "Moe Money");
            foreach (var player in playerupdate)
            {
                player.TeamsID = 1;
            }
            dbPlayers.SaveChanges();

            //Team Wins and Losses
            var teamWins = dbPlayers.Teams.Select(games => new { games.Wins, games.Losses, games.Mascot });

            foreach (var team in teamWins)
            {
                Console.WriteLine("Team Record for The " + team.Mascot + " is " + "Wins: " + team.Wins + " Losses, " + team.Losses);
            }

            //All Players and Team they are on

            var playerTeamList = dbPlayers.Players.Include(i => i.Teams).Select(teams => new { teams.Teams, teams.FullName });
            foreach (var player in playerTeamList)
            {
                Console.WriteLine("Player: " + player.FullName + " is on Team: " + player.Teams.Mascot);
            }

            //Upcoming Games
            //this part is still not working ...

            var futureGames = dbPlayers.Games.Include(i => i.Teams).Select(teams => new { teams.Teams, teams.Date });
            //futureGames.Where(d => d.Date > DateTime.Today);
            foreach(var futuregame in futureGames)
            {
                Console.WriteLine("Date of upcoming game: " + futuregame.Date);
                //Console.WriteLine("Home Team: " + futuregame.HomeTeamsID + " Away Team: " + futuregame.AwayTeamsID);
            }
        }
    }
}


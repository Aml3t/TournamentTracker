using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TrackerLibrary.Models;

// Save the List<string> to the text file

namespace TrackerLibrary.Data_Access.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] columns= line.Split(',');
                PrizeModel prize = new PrizeModel();
                prize.Id = int.Parse(columns[0]);
                prize.PlaceNumber =int.Parse(columns[1]);
                prize.PlaceName = columns[2];
                prize.PrizeAmount = decimal.Parse(columns[3]);
                prize.PrizePercentage = double.Parse(columns[4]);
                output.Add(prize);
            }
            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                PersonModel person = new PersonModel();
                person.Id = int.Parse(columns[0]);
                person.FirstName = columns[1];
                person.LastName = columns[2];
                person.EmailAddress = columns[3];
                person.CellphoneNumber = columns[4];
                output.Add(person);
            }
            return output;
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse((columns[0]));
                t.TeamName = columns[1];

                string[] personIds = columns[2].Split('|');
                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }
        public static List<TournamentModel> ConvertToTournamentModels (this List<string> lines,
                                    string teamFileName,
                                    string peopleFileName,
                                    string prizeFileName)
        {
            // id = 0
            // TournamentName = 1
            // EntryFee = 2
            // EnteredTeams = 3
            // Prizes = 4
            // Rounds = 5 
            //id,TournamentName,EntryFee,(id|id|id = Entered Teams), (id|id|id = Prizes), (Rounds = id^id^id|id^id^id|id^id^id)

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<List<MatchupModel>> rounds = new List<List<MatchupModel>>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(columns[0]);
                tm.TournamentName = columns[1];
                tm.EntryFee = decimal.Parse(columns[2]);

                string[] teamdIds = columns[3].Split('|');

                foreach (string id in teamdIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                string[] prizeIds = columns[4].Split('|');

                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                // TODO - Capture rounds information

                output.Add(tm);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id },{p.PlaceNumber },{p.PlaceName },{p.PrizeAmount },{p.PrizePercentage }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id },{p.FirstName },{p.LastName },{p.EmailAddress },{p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id },{t.TeamName }, {ConvertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName}," +
                    $"{tm.EntryFee}," +
                    $"{ConvertTeamListToString(tm.EnteredTeams)}," +
                    $"{ConvertPrizeListToString(tm.Prizes)}," +
                    $"{ConvertedRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this TournamentModel model ,string matchupFile, string matchupEntryFile)
        {
            // Loop through each Round
            // Loop through each Matchup
            // Get the id for the new matchup and save the record
            // Loop through each entry, get the id and save it

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup  in round)
                {
                    matchup.SaveToMatchupFile(matchupFile);
                }
            }
        }

        public static void SaveToMatchupFile(this MatchupModel matchup, string matchupFile)
        {
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }
            
        }
        private static string ConvertedRoundListToString(List<List<MatchupModel>> rounds)
        {
            // Rounds = id^id^id|id^id^id|id^id^id
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r) }|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
        public static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}

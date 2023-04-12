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

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFile)
        {
            List<TeamModel> output = new List<TeamModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                TeamModel team = new TeamModel();
                team.Id = int.Parse((columns[0]));
                team.TeamName = columns[1];
                team.TeamMembers = columns[2];

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
    }
}

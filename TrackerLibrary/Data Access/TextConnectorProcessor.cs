using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TrackerLibrary.Models;

namespace TrackerLibrary.Data_Access.TextConnector
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
                
            }
            return output;
        }
    }
}

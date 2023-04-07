using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.Data_Access.TextHelpers;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method to actually save text files.

        private const string PrizeFile = "PrizeModels.csv"; //Pascal notation cause const variable
        private const string PeopleFile = "PersonModels.csv";

        public string Information { get; private set; } = "Text File";

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file und convert the text to List<PersonModel>
            List<PersonModel> person = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the max ID
            int currentId = 1;

            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max +1)
            person.Add(model);

            // Convert the person(List<PersonModel>) to List<string>
            person.SaveToPersonFile(PeopleFile);


            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file und convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            
            model.Id = currentId;

            // Add the new record with the new ID (max +1)
            prizes.Add(model);

            // Convert the prizes(List<PrizeModel>) to List<string>
            prizes.SaveToPrizeFile(PrizeFile);

            return model;
        }
    }
}

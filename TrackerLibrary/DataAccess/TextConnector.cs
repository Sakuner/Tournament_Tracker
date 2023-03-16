using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        //TODO make the create prize actually do something
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // load the text file
            // convert the text to list<prizemodel>
            //find the ID
            //add the new record with the new id
            //convert the prizes to list<string>
            //save the list<string> to the text file
            return model;
        }
    }
}

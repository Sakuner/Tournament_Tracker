using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string CellphoneNumber { get; set; }

        public PersonModel()
        {

        }
        public PersonModel(string firstName, string lastName, string emailAdress, string cellphoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = emailAdress;
            CellphoneNumber = cellphoneNumber;
        }

    }

}

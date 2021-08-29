using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClasses
{
    public class Customer
    {
        // Automatic properties for the Customer object
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Address { set; get; }

        // List of strings is used to store the interest of customers 
        // that is returned by the database.
        public List<string> InterestList { get; set; }

        // default constructor of the Customer class.
        // It initializes the properties
        public Customer()
        {
            InterestList = new List<string>();
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
        } 
        
        // Overloaded constructor of the Customer class.
        // It creates a new Customer object with the parameters passed to it.
        public Customer(string fname, string lname, string address, List<string> interests)
        {
            InterestList = new List<string>();
            InterestList = interests;
            FirstName = fname;
            LastName = lname;
            Address = address;
        }
    }
}

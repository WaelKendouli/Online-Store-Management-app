using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Events
{
    public class clsCustomerEventsArgs : EventArgs
    {
        public int CustomerID { get; }
        public string First_name { get;  }
        public string Second_name { get;  }
        public string Third_name { get;  }
        public string Last_name { get;  }
        public string Phone { get;  }
        public string Email { get; }
        public string Password { get;  }

        // Parameterless constructor

        public clsCustomerEventsArgs( string firstName, string secondName,
                          string thirdName, string lastName, string phone,
                          string email, string password)
        {
            
            First_name = firstName;
            Second_name = secondName;
            Third_name = thirdName;
            Last_name = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        public clsCustomerEventsArgs(int customerId, string firstName, string secondName,
                           string thirdName, string lastName, string phone,
                           string email)
        {
            CustomerID = customerId;
            First_name = firstName;
            Second_name = secondName;
            Third_name = thirdName;
            Last_name = lastName;
            Phone = phone;
            Email = email;
            
        }
    }
}

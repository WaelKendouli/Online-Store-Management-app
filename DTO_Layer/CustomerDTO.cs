using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Layer
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Third_name { get; set; }
        public string Last_name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Parameterless constructor
        public CustomerDTO()
        {
            First_name = string.Empty;
            Second_name = string.Empty;
            Third_name = string.Empty;
            Last_name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
        }

        // Parameterized constructor
        public CustomerDTO(int customerId, string firstName, string secondName,
                           string thirdName, string lastName, string phone,
                           string email, string password)
        {
            CustomerID = customerId;
            First_name = firstName;
            Second_name = secondName;
            Third_name = thirdName;
            Last_name = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

    }
}

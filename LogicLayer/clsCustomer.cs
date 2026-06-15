using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Layer;
using DataAccessLayer;
using System.Data;
using LogicLayer.Events;

namespace LogicLayer
{
    public class clsCustomer
    {
        enum Mode
        {
            eAddNew = 1 , eUpdate = 2
        }

        Mode _Mode = Mode.eAddNew;
       public CustomerDTO DTO = null;
        public int CustomerID { get; set; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Third_name { get; set; }
        public string Last_name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        // Parameterless constructor
        

        private clsCustomer(int customerId, string firstName, string secondName,
                           string thirdName, string lastName, string phone,
                           string email, string password)
        {
            DTO = new CustomerDTO(customerId, firstName, secondName,
                            thirdName, lastName, phone,
                            email, password);
            _Mode = Mode.eUpdate;
            CustomerID = customerId;
            First_name = firstName;
            Second_name = secondName;
            Third_name = thirdName;
            Last_name = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        public clsCustomer (string firstName, string secondName,
                           string thirdName, string lastName, string phone,
                           string email, string password)
        {
            _Mode = Mode.eAddNew;
            DTO = new CustomerDTO(this.CustomerID, firstName, secondName,
                            thirdName, lastName, phone,
                            email, password);
            First_name = firstName;
            Second_name = secondName;
            Third_name = thirdName;
            Last_name = lastName;
            Phone = phone;
            Email = email;
            Password = password;
        }

        private bool AddNewCustomer(string firstName, string secondName, string thirdName, string lastName,
    string phone, string email, string password)
        {
            return clsCustomersDA.AddNewCustomer(firstName, secondName, thirdName, lastName, phone, email, password) > 0;
        }
        private  bool UpdateCustomer(int customerID, string firstName, string secondName, string thirdName, string lastName,
   string phone, string email, string password)
        {
            return clsCustomersDA.UpdateCustomer(customerID, firstName, secondName, thirdName, lastName,
    phone, email, password);
        }

        public static DataTable GetCustomersLis()
        {
            return clsCustomersDA.GetListOfCustomers();
        }
        public static clsCustomer FindCustomerByID(int customerID)
        {
            CustomerDTO DTO = clsCustomersDA.FindCustomerByID(customerID);
            if (DTO==null)
            {
                return null;
            }
            return new clsCustomer(DTO.CustomerID, DTO.First_name, DTO.Second_name, DTO.Third_name, DTO.Last_name, DTO.Phone, DTO.Email, DTO.Password);
        }

        public static DataTable GetRatingHistory(int customerID)
        {
            return clsCustomersDA.GetRatingHistory(customerID);
        }

        public static DataTable GetCustomerPurchaseHistory(int customerID)
        {
            return clsCustomersDA.GetCustomerPurchaseHistory(customerID);
        }
        public static bool DeleteCustomer(int customerID)
        {
            return clsCustomersDA.DeleteCustomer(customerID);
        }

        public void EditAttributes(clsCustomerEventsArgs e)
        {
            this.First_name = e.First_name;
            this.Second_name = e.Second_name;
            this.Third_name = e.Third_name;
            this.Last_name = e.Last_name;
            this.Phone = e.Phone;
            this.Email = e.Email;
            this.Password = e.Password;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.eAddNew:
                   
                        if (AddNewCustomer(this.First_name, this.Second_name, this.Third_name, this.Last_name, this.Phone, this.Email, this.Password)) 
                        {
                            _Mode = Mode.eUpdate;
                            return true;
                        }
                    break;

                case Mode.eUpdate:
                    return UpdateCustomer(this.CustomerID, this.First_name, this.Second_name, this.Third_name, this.Last_name, this.Phone, this.Email, this.Password);
                    
            }
            return false;
        }

    }
}

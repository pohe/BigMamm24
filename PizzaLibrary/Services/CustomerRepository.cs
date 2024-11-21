using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        #region Instance fields
        private Dictionary<string, Customer> _customers;
        #endregion

        #region Properties
        public int Count 
        {
            get { return _customers.Count; }
        }
        #endregion

        #region Constructors
        public CustomerRepository()
        {
            //_customers = new Dictionary<string, Customer>();
            _customers = MockData.CustomerData;
        }
        #endregion

        #region Methods
        public void AddCustomer(Customer customer)
        {
            if (!_customers.ContainsKey(customer.Mobile))
            {
                _customers.Add(customer.Mobile, customer);
            }
        }
        public List<Customer> GetAll()
        {
            //List<Customer> clist = new List<Customer>();
            //foreach (Customer customer in _customers.Values.)
            //{
            //    clist.Add(customer);
            //}
            return _customers.Values.ToList();
        }

        public Customer GetCustomerByMobile(string mobile)
        {
            if (mobile != null && _customers.ContainsKey(mobile) )
            {
                return _customers[mobile];
            }
            else
            {
                return null;
            }
        }

        public void RemoveCustomer(string mobile)
        {
            if (mobile != null && _customers.ContainsKey(mobile))
            {
                _customers.Remove(mobile);
            }
        }

        public void PrintAllCustomers() 
        { 
            foreach (Customer customer in _customers.Values)
            {
                Console.WriteLine(customer);
            }
        }

        public override string ToString()
        {
            string returnString = "";
            foreach (Customer customer in _customers.Values)
            {
                returnString= customer.Name;
            }
            return returnString;
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                foreach (var cus in _customers.Values)
                {
                    if (cus.Id == customer.Id)
                    {
                        //cus.Id = customer.Id; //ikke muligt, da id anvendes som key
                        cus.Name = customer.Name;
                        cus.Address = customer.Address;
                        cus.Mobile = customer.Mobile;
                        cus.ClubMember = customer.ClubMember;
                        return;
                    }
                }
            }
        }

        public void UpdateCustomer(int id, string name, string mobile, string address)
        {
            foreach (var cus in _customers.Values)
            {
                if (cus.Id == id)
                {
                    cus.Mobile = mobile; // burde ikke kunne ændres
                    //cus.Id = customer.Id; //ikke muligt, da id anvendes som key
                    cus.Name = name;
                    cus.Address = address;
                    cus.Mobile = mobile; // burde ikke kunne ændres
                    return;
                }
            }
        }





        public List<Customer> FilterCustomers(string name)
        {
            List<Customer> filteredList = new List<Customer>();
            foreach (var cu in _customers.Values)
            {
                if (cu.Name.Contains(name))
                {
                    filteredList.Add(cu);
                }
            }
            return filteredList;

        }

        public Customer GetCustomerById(int id)
        {
            foreach (var cu in _customers.Values)
            {
                if (cu.Id == id)
                    return cu;
            }
            return new Customer();
        }

        

        #endregion
    }
}

using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaLibrary.Interfaces
{
    public interface ICustomerRepository
    {
        public int Count { get;}
        List<Customer> GetAll();
        void AddCustomer(Customer customer);
        Customer GetCustomerByMobile(string mobile);
        void RemoveCustomer(string mobile);
        void PrintAllCustomers();
        List<Customer> FilterCustomers(string name);
        Customer GetCustomerById(int id);
        void UpdateCustomer(Customer customer);

        void UpdateCustomer(int id, string name, string mobile, string address);
    }
}

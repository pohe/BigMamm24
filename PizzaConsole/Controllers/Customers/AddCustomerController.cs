using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole.Controllers.Customers
{
    public class AddCustomerController
    {
        ICustomerRepository _customerRepository;
        public Customer Customer { get; set; }
        
        public AddCustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public void ReadCustomerData()
        {
            Console.WriteLine("Indlæs navn:");
            string name = Console.ReadLine();
            Console.WriteLine("Indlæs mobil nr:");
            string mobile = Console.ReadLine();
            Console.WriteLine("Indlæs adresse:");
            string address = Console.ReadLine();
            Console.WriteLine("Vil du være clubmember y/n");
            Customer = new Customer(name, mobile, address);
            string clubMemberString = Console.ReadLine().ToLower();
            Customer.ClubMember = (clubMemberString[0] == 'y') ? true : false;
        }

        public void AddCustomer()
        {
            _customerRepository.AddCustomer(Customer);
        }


    }
}

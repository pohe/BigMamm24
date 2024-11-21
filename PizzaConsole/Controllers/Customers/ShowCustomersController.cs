using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole.Controllers.Customers
{
    public class ShowCustomersController
    {
        private ICustomerRepository _customerRepository;
        public ShowCustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void ShowAllCustomers()
        {
            _customerRepository.PrintAllCustomers();
        }
    }
}

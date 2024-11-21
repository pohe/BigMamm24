using PizzaLibrary.Helpers;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class JsonCustomerRepository : ICustomerRepository
    {
        private string JsonFileName = @"JsonCustomers.json";

        private Dictionary<string, Customer> _customers;

        public JsonCustomerRepository()
        {
            _customers = new Dictionary<string, Customer>();
            
        }

        public int Count
        {
            get { return _customers.Count; }
        }


        public void AddCustomer(Customer customer)
        {
            _customers = GetAll();
            //events.Add(ev);
            //JsonFileWriter.WritetoJson(events, JsonFileName);
        }

        public List<Customer> FilterCustomers(string name)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Customer> GetAll()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByMobile(string mobile)
        {
            throw new NotImplementedException();
        }

        public void PrintAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(string mobile)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, string name, string mobile, string address)
        {
            throw new NotImplementedException();
        }

        List<Customer> ICustomerRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

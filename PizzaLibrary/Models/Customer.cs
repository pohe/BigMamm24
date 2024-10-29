using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;
using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Models
{
    public class Customer : ICustomer
    {
        #region Instance fields
        private static int _counter = 0;
        private int _id;
        #endregion

        #region Properties
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int Id { get { return _id; } }

        public bool ClubMember { get; set; }
        #endregion

        #region Constructors

        public Customer()
        {
            _counter++;
            _id = _counter;
        }
        public Customer(string name, string mobile, string address)
        {
            _counter++;
            _id = _counter;
            Name = name;
            Mobile = mobile;
            Address = address;
            ClubMember = false;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{_id} {Name} {Mobile} {Address} {(ClubMember ? "er medlem" : "Er ikke medlem")}";
        }
        #endregion
    }
}
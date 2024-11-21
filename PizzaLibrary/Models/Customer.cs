using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
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
        public string CustomerImage { get; set; }
        
        [Required(ErrorMessage = "Write you name"), MaxLength(30), DisplayName("Customer name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Write your phone number"), DisplayName("Mobile number")]
        [StringLength(18, ErrorMessage ="Phonenumber can not be longer than 18 chars")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Write your address"), DisplayName("Home address")]
        public string Address { get; set; }
        public int Id { get { return _id; } set { _id = value; } }

        public bool ClubMember { get; set; }
        #endregion

       

        #region Constructors

        public Customer()
        {
            CustomerImage = "default.jpeg";
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
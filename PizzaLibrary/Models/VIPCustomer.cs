using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public class VIPCustomer:Customer
    {

        //Der kan forhandles en discount for særlige kunder
        //discount kan sættes imellem 1 og 25 %
        public int Discount { get; set; }

        public VIPCustomer(string name, string mobile, string address, int discount) : base(name, mobile, address)
        {
            Discount = discount;
        }
    }
}

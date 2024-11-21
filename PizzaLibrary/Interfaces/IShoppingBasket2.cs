using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Interfaces
{
    public interface IShoppingBasket2
    {
        public Order CurrentOrder { get; set; }
        public Customer CurrentCustomer { get; set; }

        //public int Count { get; }
        //List<OrderLine> GetAll();
        //void AddOrderLine(OrderLine orderLine);
        //public OrderLine? GetOrderLineById(int id);
        //void RemoveOrderLine(int id);
        //void ClearAll();
        //public Customer CurrentCustomer { get; set; }
        //bool ToBeDelivered { get; set; }
    }
}

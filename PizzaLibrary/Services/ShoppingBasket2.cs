using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class ShoppingBasket2 : IShoppingBasket2
    {
        public Order CurrentOrder { get; set; }
        public Customer CurrentCustomer { get;set; }


        public ShoppingBasket2()
        {
            
        }
        //public int Count => throw new NotImplementedException();

        //public Customer CurrentCustomer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public bool ToBeDelivered { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void AddOrderLine(OrderLine orderLine)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ClearAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<OrderLine> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public OrderLine? GetOrderLineById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveOrderLine(int id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}

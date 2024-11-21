using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class ShoppingBasket : IShoppingBasket
    {


        //private Order _currentOrder;

        //public Order CurrentOrder
        //{
        //    get { return _currentOrder; }
        //    set { _currentOrder = value; }
        //}

        //public Customer Customer { get; set; }

        //public ShoppingBasket()
        //{
        //    _currentOrder = new Order();
        //}

        private List<OrderLine> _orderLines;
        public int Count { get { return _orderLines.Count; } }

        public Customer CurrentCustomer { get; set; }

        public bool ToBeDelivered { get; set; }

        public void ClearAll()
        {
            _orderLines = new List<OrderLine>();
        }
        public ShoppingBasket()
        {
            _orderLines = new List<OrderLine>();
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            _orderLines.Add(orderLine);
        }

        public List<OrderLine> GetAll()
        {
            return _orderLines;
        }

        public OrderLine? GetOrderLineById(int id)
        {
            foreach (OrderLine ol in _orderLines)
            {
                if (ol.Id == id)
                {
                    return ol;
                }
            }
            return null;
        }

        public void RemoveOrderLine(int id)
        {
            OrderLine? orderLineToBeDeleted = GetOrderLineById(id);
            if (orderLineToBeDeleted != null)
            {
                _orderLines.Remove(orderLineToBeDeleted);
            }
        }
    }
}

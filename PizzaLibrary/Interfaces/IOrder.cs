using PizzaLibrary.Models;

namespace PizzaLibrary.Interfaces
{
    public interface IOrder
    {
        int Id { get; }
        bool ToBeDelivered { get; }
        void AddOrderLine(OrderLine line);
        double CalculateTotal();
        void PrintReciept();
    }
}
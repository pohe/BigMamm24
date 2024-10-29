using PizzaLibrary.Models;

namespace PizzaLibrary.Interfaces
{
    public interface IOrderLine
    {
        int Amount { get; set; }
        string Comment { get; set; }
        int Id { get; }
        MenuItem MenuItem { get; }
        void AddExtraAccessory(Accessory accessory);
        double OrderlineTotal();
        string ToString();
    }
}
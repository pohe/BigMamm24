using PizzaLibrary.Models;

namespace PizzaLibrary.Interfaces
{
    public interface IMenuItem
    {
        string Description { get; set; }
        string Name { get; set; }
        int No { get; }
        double Price { get; set; }
        MenuType TheMenuType { get; set; }

    }
}
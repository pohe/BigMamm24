namespace PizzaLibrary.Interfaces
{
    public interface IAccessory
    {
        int Id { get; }
        string Name { get; }
        double Price { get; }

        string ToString();
    }
}
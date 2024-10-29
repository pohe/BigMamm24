
using PizzaConsole.Menu;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Velkommen Big Mamma Pizzaria!");
        Menu menu = new Menu();
        menu.ShowMenu();
        //Console.WriteLine("Customer katalog");
        //CustomerRepository customerRepository = new CustomerRepository();
        //Customer c1 = new Customer("Poul", "56565656", "Gade 56");
        //customerRepository.AddCustomer(c1);
        //customerRepository.PrintAllCustomers();

        //Console.WriteLine("Pizza katalog");

        //Pizza p1 = new Pizza("Pepperoni", 78, "Tomat, ost, pepperoni");
        //Pizza p2 = new Pizza("Bolognese", 78, "Tomat, ost, meat sause, onions");
        //Topping t1 = new Topping("Gorgonzola", 10);
        //Topping t2 = new Topping("Jalapenos", 8);

        //Order o1 = new Order(customerRepository.GetCustomerByMobile("56565656"), true);
        //OrderLine ol1 = new OrderLine(p1, 2, "Minus ost");
        //ol1.AddExtraTopping(t2);
        //o1.AddOrderLine(ol1);
        //OrderLine ol2 = new OrderLine(p1, 1, "");
        //ol2.AddExtraTopping(t1);
        //o1.AddOrderLine(ol2);
        //o1.PrintReciept();
    }
}
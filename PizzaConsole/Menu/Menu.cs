using PizzaConsole.Controllers.Customers;
using PizzaConsole.Controllers.MenuItems;
using PizzaLibrary.Models;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole.Menu
{
    public class Menu
    {
        private static string mainMenuChoices = "\t1.Vis Pizzamenu\n\t2.Vis Kunder\n\t3.Add Customer\n\t4.Lav bestilling\n\tQ.Afslut\n\n\tIndtast valg:";
        private static string orderMenuChoices = "\t1.Tilføj bestilling\n\t2.Vis total\n\t3.Tilføj kunde\n\tQ.Afslut ordermenu\n\n\tIndtast valg:";

        private CustomerRepository _customerRepository = new CustomerRepository();
        private MenuItemRepository _menuItemRepository = new MenuItemRepository();
        private static string ReadChoice(string choices)
        {
            Console.Clear();
            Console.Write(choices);
            string choice = Console.ReadLine();
            Console.Clear();
            return choice.ToLower();
        }
        public void ShowMenu()
        {

            string theChoice = ReadChoice(mainMenuChoices);
            while (theChoice != "q")
            {

                switch (theChoice)
                {
                    case "1":
                        Console.WriteLine("Valg 1");
                        ShowMenuItemController showMenuItemController = new ShowMenuItemController(_menuItemRepository);
                        showMenuItemController.ShowAllMenuItems();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Valg 2");
                        _customerRepository.PrintAllCustomers();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Valg 3");
                        AddCustomerController addMenuItemController = new AddCustomerController( _customerRepository);
                        addMenuItemController.ReadCustomerData();
                        addMenuItemController.AddCustomer();
                        break;
                    case "4":
                        Console.WriteLine("Valg 4");
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..4 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(mainMenuChoices);
            }
        }

        public void ShowOrderMenu()
        {
            Order theOrder = null;
            Customer theCustomer = null;
            string theChoice = ReadChoice(orderMenuChoices);
            while (theChoice != "q")
            {
                switch (theChoice)
                {
                    case "1":
                        Console.WriteLine("Valg 1");
                        
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Valg 2");
                       
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Valg 3");
                        Console.WriteLine("Indlæs kunde mobil nr:");
                        string mobile = Console.ReadLine();
                        theCustomer = _customerRepository.GetCustomerByMobile(mobile);  
                        if (theCustomer == null)
                        {
                            Console.WriteLine("Mobil nr eksisterer ikke");
                        }
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Angiv et tal fra 1..4 eller q for afslut");
                        break;
                }
                theChoice = ReadChoice(orderMenuChoices);
            }
        }
    }
}

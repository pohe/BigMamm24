// See https://aka.ms/new-console-template for more information
using PizzaLibrary.Helpers;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

//Console.WriteLine("Velkommen til eksamen");


//MenuItemRepository miRep = new MenuItemRepository();    

//miRep.PrintAllMenuItems();

//Dictionary<string, Customer> customers = new Dictionary<string, Customer>();

//customers.Add("1234567890", new Customer("John Doe", "1234567890", "123 Elm St"));
//customers.Add("0987654321", new Customer("Jane Smith", "0987654321", " Oak St"));

//JsonFileWriter.WriteCustomerToJson(customers, "customers.json");

//var customers = new Dictionary<string, Customer>
//{
//    { "1", new Customer("John Doe", "1234567890", "123 Elm St") },
//    { "2", new Customer("Jane Smith", "0987654321", "456 Oak St") }
//};
//string jsonFileName = "C:\\Users\\pohe\\OneDrive - Zealand\\UV23\\SWC2024E\\Opgaver\\BigMamm24\\PizzaLibrary\\Data\\JsonCustomers.json";
//JsonFileWriter.WriteCustomerToJson(customers, jsonFileName);
//Console.WriteLine($"File saved to {jsonFileName}");

ICustomerRepository customerRepository = new CustomerRepository();
IMenuItemRepository menuRepository = new MenuItemRepository();
IAccessoriesRepository accessoriesRepository = new AccessoriesRepository();
//opret order
Console.WriteLine("Angiv kunde mobil nr");
string customerMobile= Console.ReadLine();
Customer customer= customerRepository.GetCustomerByMobile(customerMobile);
if (customer == null)
{
    Console.WriteLine("ugyldigt mobil nr"); 
}
else
{
    Console.WriteLine("Skal det leveres (j/n)");
    string deliveringString = Console.ReadLine().ToLower();
    bool toBeDelivered = deliveringString[0]=='y'? true : false;
    Order order = new Order(customer, toBeDelivered);
    Console.WriteLine("Angiv menu nummer eller 0 for afslut bestilling)");
    string menuNoString = Console.ReadLine();
    int menuNo = int.Parse(menuNoString);
    while (menuNo != '0')
    {
        MenuItem menuItem = menuRepository.GetMenuItemByNo(menuNo);
        if (menuItem != null)
        {
            Console.WriteLine("Angiv antal");
            string amountString = Console.ReadLine();
            int amount = int.Parse(amountString);
            Console.WriteLine("Kommentar (noget der skal udelades/ændres?)");
            string comment = Console.ReadLine();
            OrderLine orderLine = new OrderLine(menuItem, amount, comment);
            Console.WriteLine("Ønskes ekstra tilbehør (j/n)");
            string accessoryString = Console.ReadLine().ToLower();
            while (accessoryString != null && accessoryString[0] == 'y')
            {
                Console.WriteLine("Angiv tilbehørsnummer");
                string accessoryNoString = Console.ReadLine();
                int accessoryNo = int.Parse(accessoryNoString);
                Accessory accessory = accessoriesRepository.GetAccessoryById(accessoryNo);
                orderLine.AddExtraAccessory(accessory);
                Console.WriteLine("Ønskes mere ekstra tilbehør (j/n)");
                accessoryString = Console.ReadLine().ToLower();
                Console.WriteLine("Angiv menu nummer eller 0 for afslut bestilling)");
                menuNoString = Console.ReadLine();
                menuNo = int.Parse(menuNoString);
            }
            order.AddOrderLine(orderLine);
        }
    }
    Console.WriteLine($"Den samlede order er: ");
    order.PrintReciept();
}


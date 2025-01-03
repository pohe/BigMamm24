﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary.Models;

namespace PizzaLibrary.Data
{
    public static class MockData
    {
        #region Instance fields
        private static Dictionary<string, Customer> _customerData =
            new Dictionary<string, Customer>() 
            {
                { "12121212", new Customer("Mikkel", "12121212", "Street 123") },
                { "13131313", new Customer("Charlotte", "13131313", "Avenue 321") },
                { "14141414", new Customer("Carina", "14141414", "High Street 234") },
                { "15151515", new Customer("Muhammed", "15151515", "North Street 345") }
            };

        private static List<MenuItem> _menuItemData =
            new List<MenuItem>()
            {
                new MenuItem("Margherita", 85, "Tomat, ost", MenuType.PIZZECLASSSICHE),
                new MenuItem("Vesuvio", 95, "Tomat, ost & skinke", MenuType.PIZZECLASSSICHE),
                new MenuItem("Capricciosa", 98, "Tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
                new MenuItem("Calzone", 98, "Indbagt pizza med tomat, ost, skinke & champignon", MenuType.PIZZECLASSSICHE),
                new MenuItem("Quattro Stagioni", 98, "Tomat, ost, skinke, champignon, rejer & paprika", MenuType.PIZZECLASSSICHE),
                new MenuItem("Marinara", 97, "Tomat, ost, rejer, muslinger & hvidløg", MenuType.PIZZECLASSSICHE),
                new MenuItem("Vegetariana", 98, "Tomat, ost & grønsager", MenuType.PIZZECLASSSICHE),
                new MenuItem("Italiana", 97, "Tomat, ost, løg & kødsauce", MenuType.PIZZECLASSSICHE)

            };

        private static List<Accessory> _AccessoryData =
            new List<Accessory>()
            {
                new Accessory("Ananas", 10),
                new Accessory("Artiskok", 10),
                new Accessory("løg", 10),
                new Accessory("Ost", 15),
                new Accessory("Gorgonzola", 20),
                new Accessory("pepperoni", 20),
                new Accessory("kødstrimler", 20),
                new Accessory("rejer", 20)
            };


        private static List<User> _userData = new List<User> {
                new User { UserId = 1, Name = "Test", Password = "123" }
                ,new User { UserId = 2, Name = "Poul", Password = "123" }
                ,new User { UserId = 3, Name = "Charlotte", Password = "123" }};
        #endregion

        #region Properties
        public static Dictionary<string, Customer> CustomerData
        {
            get { return _customerData; }
        }


        public static List<MenuItem> MenuItemData
        {
            get { return _menuItemData; }
        }

        public static List<Accessory> AccessoryData
        {
            get { return _AccessoryData; }
        }

        public static List<User> UserData
        {
            get { return _userData; }
        }

        #endregion
    }
}

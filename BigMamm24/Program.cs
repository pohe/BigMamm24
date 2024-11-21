// See https://aka.ms/new-console-template for more information
using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;
using System.ComponentModel;

Console.WriteLine("Hello, World!");

MenuItemRepository menuItemRepository = new MenuItemRepository();

IMenuItem mostExpensivePizza = menuItemRepository.FindMostExpensivePizza();
Console.WriteLine($"Dyreste pizza er {mostExpensivePizza}");


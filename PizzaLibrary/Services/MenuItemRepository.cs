﻿using PizzaLibrary.Data;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Services
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private List<MenuItem> _menuItemList;

        public int Count { get { return _menuItemList.Count; } }

        public MenuItemRepository()
        {
            //_menuItemList = new List<MenuItem>();
            _menuItemList = MockData.MenuItemData;
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            _menuItemList.Add(menuItem);
        }

        public List<MenuItem> GetAll()
        {
            return _menuItemList;
        }

        public MenuItem GetMenuItemByNo(int no)
        {
            foreach (MenuItem menuItem in _menuItemList)
            {
                if (menuItem.No == no)
                    return menuItem;
            }
            return null;
        }

        public void RemoveMenuItem(int no)
        {
            MenuItem foundMenuItem = GetMenuItemByNo(no);
            if (foundMenuItem != null)
            {
                _menuItemList.Remove(foundMenuItem);
            }
        }

        public void PrintAllMenuItems()
        {
            foreach (MenuItem menuItem in _menuItemList)
            {
                Console.WriteLine(menuItem);
            }
        }

        public IMenuItem FindMostExpensivePizza()
        {
            IMenuItem mostExpensive = null;
            if (_menuItemList == null)
                return null;
            if (_menuItemList.Count > 0)
                mostExpensive = _menuItemList[0];
            foreach (MenuItem menuItem in _menuItemList)
            {
                if ((menuItem.TheMenuType == MenuType.PIZZECLASSSICHE || menuItem.TheMenuType == MenuType.PIZZESPECIALI) && menuItem.Price > mostExpensive.Price)
                    mostExpensive = menuItem;
            }
            return mostExpensive;
        }
        public MenuItem MostExpensivePizza()
        {
            if (_menuItemList == null || _menuItemList.Count == 0)
            {
                return null;
            }
            MenuItem mostExpensive = new MenuItem();
            mostExpensive.Price = 0;//Er default 0
            foreach (MenuItem menuItem in _menuItemList)
            {
                if (menuItem.TheMenuType == MenuType.PIZZECLASSSICHE
                    || menuItem.TheMenuType == MenuType.PIZZESPECIALI
                    && menuItem.Price > mostExpensive.Price)
                {
                    mostExpensive = menuItem;
                }

            }
            return mostExpensive;
        }

        public List<MenuItem> FilterMenuItems(string filterCriteria)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenuItem(MenuItem currentMenuItem)
        {
            if (currentMenuItem != null)
            {
                foreach (var menuItem in _menuItemList)
                {
                    if (menuItem.No == currentMenuItem.No)
                    {
                        //menuItem.No = currentMenuItem.No;
                        menuItem.Name = currentMenuItem.Name;
                        menuItem.Description = currentMenuItem.Description;
                        menuItem.Price = currentMenuItem.Price;
                        menuItem.TheMenuType = currentMenuItem.TheMenuType;
                        return;
                    }
                }
            }

        }
    }
}

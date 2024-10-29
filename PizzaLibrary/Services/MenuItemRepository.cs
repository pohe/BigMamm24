using PizzaLibrary.Data;
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
    }
}

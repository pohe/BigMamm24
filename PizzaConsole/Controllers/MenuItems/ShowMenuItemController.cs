using PizzaLibrary.Interfaces;
using PizzaLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaConsole.Controllers.MenuItems
{
    public class ShowMenuItemController
    {
        private IMenuItemRepository _menuItemRepository;
        public ShowMenuItemController(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public void ShowAllMenuItems()
        {
            _menuItemRepository.PrintAllMenuItems();
        }
    }
}

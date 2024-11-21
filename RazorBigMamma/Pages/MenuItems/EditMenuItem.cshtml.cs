using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace RazorBigMamma.Pages.MenuItems
{
    public class EditMenuItemModel : PageModel
    {
        private IMenuItemRepository repo;

        [BindProperty]
        public MenuItem CurrentMenuItem { get; set; }

        [BindProperty]
        public MenuType UpDatedMenuType { get; set; }

        public EditMenuItemModel(IMenuItemRepository menuItemRepository)
        {
            this.repo = menuItemRepository;
        }

        public IActionResult OnGet(int editNo)
        {
            CurrentMenuItem = repo.GetMenuItemByNo(editNo);
            return Page();
        }

        public IActionResult OnPostEdit()
        {
            
            CurrentMenuItem.TheMenuType = UpDatedMenuType;
            repo.UpdateMenuItem(CurrentMenuItem);
            return RedirectToPage("ShowMenuItems");
        }
    }
}

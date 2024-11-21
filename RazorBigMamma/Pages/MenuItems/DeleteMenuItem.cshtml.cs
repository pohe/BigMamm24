using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace RazorBigMamma.Pages.MenuItems
{
    public class DeleteMenuItemModel : PageModel
    {
        private IMenuItemRepository repo;

        [BindProperty]
        public MenuItem MenuItem { get; set; }

        public DeleteMenuItemModel(IMenuItemRepository menuItemRepository)
        {
            this.repo = menuItemRepository;
        }

        public void OnGet(int deleteNo)
        {
            MenuItem = repo.GetMenuItemByNo(deleteNo);
        }

        public IActionResult OnPost()
        {
            repo.RemoveMenuItem(MenuItem.No);
            return RedirectToPage("ShowMenuItems");
        }
    }
}

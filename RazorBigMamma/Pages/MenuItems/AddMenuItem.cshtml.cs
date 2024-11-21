using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System.Diagnostics.Metrics;

namespace RazorBigMamma.Pages.MenuItems
{
    public class AddMenuItemModel : PageModel
    {
        private IMenuItemRepository repo;


        [BindProperty]
        public MenuItem MenuItem { get; set; }

        public AddMenuItemModel(IMenuItemRepository menuItemRepository)
        {
            repo = menuItemRepository;
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        public IActionResult OnPost()
        {
           
            repo.AddMenuItem(MenuItem);
            return RedirectToPage("ShowMenuItems");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using System.Diagnostics.Metrics;

namespace RazorBigMamma.Pages.Customers
{
    public class AddCustomerModel : PageModel
    {
        private ICustomerRepository repo;

        
        [BindProperty]
        public Customer Customer { get; set; }

        
        public AddCustomerModel(ICustomerRepository cRepo)
        {
            repo = cRepo;
            
        }

        public IActionResult OnGet()
        {
            return Page();

        }

        public IActionResult OnPost()
        {
            repo.AddCustomer(Customer);
            return RedirectToPage("ShowCustomers");
        }

        
    }
}

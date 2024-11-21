using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace RazorBigMamma.Pages.Customers
{
    public class DeleteCustomerModel : PageModel
    {
        private ICustomerRepository repo;

        [BindProperty]
        public Customer Customer { get; set; }

        public DeleteCustomerModel(ICustomerRepository customerRepository)
        {
            this.repo = customerRepository;
        }

        public void OnGet(int deleteId)
        {
            Customer = repo.GetCustomerById(deleteId);
        }

        public IActionResult OnPost()
        {
            repo.RemoveCustomer(Customer.Mobile);
            return RedirectToPage("ShowCustomers");
        }
    }
}

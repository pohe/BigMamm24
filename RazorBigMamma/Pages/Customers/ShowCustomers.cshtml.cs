using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace RazorBigMamma.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private ICustomerRepository _repo;

        public List<Customer> Customers { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexModel(ICustomerRepository customerRepository)
        {
            _repo = customerRepository;
        }
        public void OnGet()
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                //Customers = _repo.FilterEvents(FilterCriteria);
            }
            else
            {
                Customers = _repo.GetAll();
            }

        }
    }
}

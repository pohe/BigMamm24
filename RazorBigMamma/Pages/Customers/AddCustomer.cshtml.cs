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


        private IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public IFormFile Photo { get; set; }



        public AddCustomerModel(ICustomerRepository cRepo, IWebHostEnvironment webHost)
        {
            repo = cRepo;
            webHostEnvironment = webHost;

        }

        public IActionResult OnGet()
        {
            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Photo != null)
            {
                if (Customer.CustomerImage != null && Customer.CustomerImage != "default.jpeg")
                {
                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "/images/customerImages", Customer.CustomerImage);
                    System.IO.File.Delete(filePath);
                }

                Customer.CustomerImage = ProcessUploadedFile();
            }

            //Customer newCustomer = new Customer(Customer.Name, Customer.Mobile, Customer.Address);
            //repo.AddCustomer(newCustomer);
            repo.AddCustomer(Customer);
            return RedirectToPage("ShowCustomers");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;
            if (Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/customerImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}

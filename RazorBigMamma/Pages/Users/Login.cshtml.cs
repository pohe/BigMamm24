using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;

namespace RazorBigMamma.Pages.Users
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string PassWord { get; set; }

        public string Message { get; set; }

        private IUserService _userService;
        public LoginModel(IUserService userservice)
        {
            _userService = userservice;
        }

        public void OnGet()
        {
        }

        public void OnGetLogout()
        {
            HttpContext.Session.Remove("Name");
        }

        public IActionResult OnPost()
        {
            User loginUser = _userService.VerifyUser(Name, PassWord);
            if (loginUser != null)
            {

                HttpContext.Session.SetString("Name", loginUser.Name);
                return RedirectToPage("/MenuItems/ShowMenuItems");
            }
            else
            {
                Message = "Invalid username or password";
                Name = "";
                PassWord = "";
                return Page();
            }


            //private IUserService userService;
            //private LogInService logInService;
            //public string AccessDenied = "";
            //[BindProperty]
            //public User User { get; set; }

            //public LoginModel(IUserService service, LogInService logIn)
            //{
            //    userService = service;
            //    logInService = logIn;

            //}
            //public IActionResult OnGet()
            //{
            //    return Page();
            //}
            //public IActionResult OnPost()
            //{
            //    foreach (User user in userService.GetAllUsers())
            //    {
            //        if (user.Name == User.Name)
            //        {
            //            if (user.Password == User.Password)
            //            {
            //                logInService.UserLogIn(user);
            //                return RedirectToPage("/Index");
            //            }
            //        }
            //        AccessDenied = "Email/kodeord er ikke korrekt";
            //    }
            //    return Page();
            //}


        }
    }
}


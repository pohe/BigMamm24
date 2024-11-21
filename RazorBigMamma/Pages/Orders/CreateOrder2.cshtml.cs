using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;

namespace RazorBigMamma.Pages.Orders
{
    public class CreateOrder2Model : PageModel
    {
        private ICustomerRepository _cRepo;
        private IShoppingBasket2 _shoppingBasket2;
        private IMenuItemRepository _mRepo;

        [BindProperty]
        public string SearchCustomerMobile { get; set; }
        public Customer TheCustomer { get; set; }

        public List<SelectListItem> MenuItemSelectList { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public List<OrderLine> OrderLines { get; set; }

        [BindProperty]
        public int ChoosenMenuItem { get; set; }

        public CreateOrder2Model(ICustomerRepository customerRepository, IShoppingBasket2 shoppingBasket2, IMenuItemRepository menuItemRepository)
        {
            _cRepo = customerRepository;
            _shoppingBasket2 = shoppingBasket2;
            _mRepo = menuItemRepository;
            CreateMenuSelectList();
        }

        public void OnGet()
        {
        }

        public void OnPostCustomer()
        {
            //CreateSelectList();
            TheCustomer = _cRepo.GetCustomerByMobile(SearchCustomerMobile);
            _shoppingBasket2.CurrentCustomer = TheCustomer;
        }

        public void OnPostAddToOrder()
        {
            if (Amount > 0)
            {
                MenuItem menuItemToOrder = _mRepo.GetMenuItemByNo(ChoosenMenuItem);
                if (menuItemToOrder != null)
                {
                    OrderLine ol = new OrderLine(menuItemToOrder, Amount, Comment);
                    //OrderLines.Add(ol);
                    _shoppingBasket2.CurrentOrder.AddOrderLine(ol);
                }
            }
            OrderLines = _shoppingBasket2.CurrentOrder.GetAllOrderLines();
        }
        private void CreateMenuSelectList()
        {
            MenuItemSelectList = new List<SelectListItem>();
            MenuItemSelectList.Add(new SelectListItem("Select an item", "-1"));
            foreach (var item in _mRepo.GetAll())
            {
                SelectListItem sli = new SelectListItem(item.Name, item.No.ToString());
                MenuItemSelectList.Add(sli);
            }
        }
    }
}

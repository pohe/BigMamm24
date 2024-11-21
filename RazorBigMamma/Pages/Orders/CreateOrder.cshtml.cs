using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaLibrary.Interfaces;
using PizzaLibrary.Models;
using PizzaLibrary.Services;
using System.Security.Cryptography;

namespace RazorBigMamma.Pages.Orders
{
    public class CreateOrderModel : PageModel
    {
        private ICustomerRepository _cRepo;
        private IMenuItemRepository _mRepo;
        private IShoppingBasket _shoppingBasket;
        private IAccessoriesRepository _aRepo;

        [BindProperty]
        public string SearchCustomerMobile { get; set; }
        public Customer TheCustomer { get; set; }

        public List<SelectListItem> MenuItemSelectList { get; set; }

        [BindProperty]
        public int ChoosenMenuItem { get; set; }

        [BindProperty]
        public int Amount { get; set; }

        [BindProperty]
        public string Comment { get; set; }

        public List<OrderLine> OrderLines { get; set; }

        public List<SelectListItem> AsseccorySelectList { get; set; }

        [BindProperty]
        public int ChoosenAsseccory { get; set; }

        [BindProperty]
        public bool Delivery { get; set; }

        public string[] WhereToEat = new string[] { "Deliver", "Eat here" };

        public CreateOrderModel(ICustomerRepository customerRepository,
                                IMenuItemRepository menuItemRepository, 
                                IShoppingBasket shoppingBasket, 
                                IAccessoriesRepository accessoriesRepository)
        {
            _cRepo = customerRepository;
            _mRepo = menuItemRepository;
            _shoppingBasket = shoppingBasket;
            _aRepo = accessoriesRepository;
            CreateMenuSelectList();
            CreateAsseccorySelectList();
            if (_shoppingBasket.CurrentCustomer != null)
                TheCustomer = _shoppingBasket.CurrentCustomer;

            //Delivery = _shoppingBasket.ToBeDelivered;


        }
        public void OnGet()
        {
            //_shoppingBasket= new ShoppingBasket();
            OrderLines = _shoppingBasket.GetAll();
            //CreateSelectList();
        }

        public void OnPostAddToOrder()
        {
            if (Amount>0)
            {
                MenuItem menuItemToOrder = _mRepo.GetMenuItemByNo(ChoosenMenuItem);
                if (menuItemToOrder != null)
                {
                    OrderLine ol = new OrderLine(menuItemToOrder, Amount, Comment);
                    //OrderLines.Add(ol);
                    _shoppingBasket.AddOrderLine(ol);
                }
            }
            OrderLines = _shoppingBasket.GetAll();
        }

        public void OnPostCustomer()
        {
            //CreateSelectList();
            TheCustomer = _cRepo.GetCustomerByMobile(SearchCustomerMobile);
            _shoppingBasket.CurrentCustomer=TheCustomer;
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
        private void CreateAsseccorySelectList()
        {
            AsseccorySelectList = new List<SelectListItem>();
            AsseccorySelectList.Add(new SelectListItem("Select an item", "-1"));
            foreach (var item in _aRepo.GetAll())
            {
                SelectListItem sli = new SelectListItem(item.Name, item.Id.ToString());
                AsseccorySelectList.Add(sli);
            }
        }
        public void OnPostDeleteOrderLine(int orderLineId)
        {
            _shoppingBasket.RemoveOrderLine(orderLineId);
            OrderLines = _shoppingBasket.GetAll();
        }

        public void OnPostAddAccessories(int orderLineId)
        {
            if (ChoosenAsseccory > -1)
            {
                OrderLine currentOrderline = _shoppingBasket.GetOrderLineById(orderLineId);
                Accessory addAccessoryToOrderLine = _aRepo.GetAccessoryById(ChoosenAsseccory);

                if (currentOrderline != null)
                {
                    currentOrderline.AddExtraAccessory(addAccessoryToOrderLine);
                }
            }
            OrderLines = _shoppingBasket.GetAll();
            
        }

        public void OnPostDelivery()
        {
            _shoppingBasket.ToBeDelivered = Delivery;
            OrderLines = _shoppingBasket.GetAll();
        }


    }
}

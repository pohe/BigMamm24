using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaLibrary.Interfaces;

namespace PizzaLibrary.Models
{
    public class MenuItem : IMenuItem
    {
        #region Instance fields
        private static int counter = 0;
        private int _no;
        #endregion

        #region Properties
        public int No { get { return _no; } set { _no = value; } }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public MenuType TheMenuType { get; set; }
        #endregion

        #region Constructors

        public MenuItem()
        {
            counter++;
            _no = counter;
        }
        public MenuItem(string name, double price, string description, MenuType menuType)
        {
            counter++;
            _no = counter;
            Name = name;
            Price = price;
            Description = description;
            TheMenuType = menuType;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Nr {No} Navn {Name} Beskrivelse {Description} Price {Price} MenuType {TheMenuType.ToString()}";
        }

       
        #endregion
    }
}

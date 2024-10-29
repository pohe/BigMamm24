using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary.Models
{
    public static class CompanyInfo
    {
        public static string Name { get; set; }
        public static double Vat { get; set; }
        public static string CVR { get; set; }

        public static int ClubDiscount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaProject.Models
{
    public class Order
    {
        // purpose of this file is to describe the order
        public  string PizzaSize { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerPhone { get; set; }
    }
}
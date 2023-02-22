using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaProject.Models;

namespace PizzaProject.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }

        //GET : /Pizza/Order
        public ActionResult Order()
        {
            return View();
        }
        //POST : /Pizza/Receipt
        [HttpPost]
        public ActionResult Receipt(string PizzaSize,string OwnerAddress,string OwnerPhone)
        {
            Order NewOrder=new Order();
            NewOrder.OwnerAddress = OwnerAddress;
            NewOrder.OwnerPhone = OwnerPhone;   
            NewOrder.PizzaSize= PizzaSize;
            return View(NewOrder);
        }
    }
}
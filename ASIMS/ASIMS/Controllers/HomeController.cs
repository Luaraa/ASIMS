using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASIMS.Models.Method;
using ASIMS.Models.Methods;
using ASIMS.Models.Tables;
using Microsoft.AspNetCore.Mvc;

namespace ASIMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UserManagement method = new UserManagement();
            List<User> users = method.ListAllUser();
            OrderManagement order = new OrderManagement();
            order.GetOneUserMarket("13279451762", 1);
            order.GetSomeUserMarket("13279441762");
            order.CheckMarket(1);
            return View();
        }
    }
}
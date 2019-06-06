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
            VehicleManagement method = new VehicleManagement();
            method.GetAllVehicle();
            method.CheckVehicleThoughId(121);
            method.CheckVehicleThoughType("皮卡");
            StaffManagement staff = new StaffManagement();
            staff.DeleteStaff("13305068852");
            staff.SearchStaffThoughName("陈英");
            return View();
        }
    }
}
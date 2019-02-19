using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insurance_premium_calculator.ViewModels;
using insurance_premium_calculator.lib;

namespace insurance_premium_calculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(InsuranceViewModel model)
        {
            InsuranceService service = new InsuranceService();

            ViewBag.age = model.age;
            ViewBag.gender = model.gender;
            ViewBag.premium = service.CalcPremium(model.age, model.gender);

            return View();
        }
    }
}
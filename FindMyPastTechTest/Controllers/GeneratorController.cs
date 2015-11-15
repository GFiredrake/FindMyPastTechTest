using FindMyPastTechTest.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindMyPastTechTest.Controllers
{
    public class GeneratorController : Controller
    {
        public JsonResult GenerateListOfNumbers(int NumberRequired)
        {
            var list = PrimeNumberListGenerator.Generate(NumberRequired);

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BMICalculator.Models;
namespace BMICalculator.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel bm)
        {
            string strOutput = bm.Weight;
            ViewBag.BMIResult = strOutput;
            return View();
        }
    }
}
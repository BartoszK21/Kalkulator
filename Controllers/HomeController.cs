using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Calculate(double number1, double number2, string operation)
        {
            double result = 0;

           
            switch (operation)
            {
                case "Add":
                    result = number1 + number2;
                    break;
                case "Subtract":
                    result = number1 - number2;
                    break;
                case "Multiply":
                    result = number1 * number2;
                    break;
                case "Divide":
                    if (number2 != 0)
                        result = number1 / number2;
                    else
                        ViewBag.ErrorMessage = "Nie mo¿na dzieliæ przez zero!";
                    break;
                default:
                    ViewBag.ErrorMessage = "Nieznana operacja.";
                    break;
            }

            ViewBag.Result = result;
            return View("Index");
        }
    }
}

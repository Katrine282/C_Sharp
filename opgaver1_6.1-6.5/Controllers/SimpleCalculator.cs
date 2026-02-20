using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class SimpleCalculator : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    //POST
    [HttpPost]
    public IActionResult Index(IFormCollection formCollection)
    {
        int num1 = Convert.ToInt32(formCollection["Number1"]);
        int num2 = Convert.ToInt32(formCollection["Number2"]);
        string op = formCollection["operator"];

        int result = 0;
        
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num2 != 0)
                    result = num1 / num2;
                else
                    ViewBag.Error = "Cannot divide by zero";
                break;

            default:
                ViewBag.Error = "Unknown operator";
                break;
        }
        
        ViewBag.Result = result;
        // return View("TimeCalculatorResult");
        return View();

    }
}
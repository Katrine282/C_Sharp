using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Exercise1.Controllers;

public class Exercise01Controller : Controller
{
    private List<SelectListItem> countryList = new List<SelectListItem>();
    // GET
    [HttpGet]
    public IActionResult Index(string Countries)
    {
        if (HttpContext.Session.GetString("countryList") == null) {
            countryList.Add(new SelectListItem { Text = "China", Value = "CN" });
            countryList.Add(new SelectListItem { Text = "Denmark", Value = "DK" });
            countryList.Add(new SelectListItem { Text = "France", Value = "FR" });
            countryList.Add(new SelectListItem { Text = "USA", Value = "US" });
            HttpContext.Session.SetString("countryList", JsonConvert.SerializeObject(countryList));
        }
        else
        {
            countryList = JsonConvert.DeserializeObject<List<SelectListItem>>
                            (HttpContext.Session.GetString("countryList"));
        }
        
        ViewBag.Countries = countryList;
        ViewBag.CountryCode = Countries;
        
        return View();
    }

    [HttpPost]
    public ActionResult Index(IFormCollection formData)
    {
        countryList = JsonConvert.DeserializeObject<List<SelectListItem>>
            (HttpContext.Session.GetString("countryList"));
        
        String c = formData["Country"];
        String code = formData["Code"];
        countryList.Add(new SelectListItem { Text = c, Value = code });
        
        ViewBag.Countries = countryList;
        return View();
    }
    
}
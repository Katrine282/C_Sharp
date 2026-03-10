using Exercise1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise1.Controllers;

public class ParkingController : Controller
{
    
    // GET
    public IActionResult Index()
    {
        ParkingTicketMachine ptm =  new ParkingTicketMachine();
        return View(ptm);
    }
    
    [HttpPost]
    public ActionResult Index(IFormCollection formData) {
        // create a new instance of ParkingTicketMachine
        ParkingTicketMachine ptm = new ParkingTicketMachine();
        ViewBag.cancelTekst = null;
        // declare a variable of type int which keeps track of the amount inserted
        int amountInserted = 0;
       
        // if the form field representing the amount is not null
        int antalKr = Convert.ToInt32(formData["AmountInserted"]);
        if (antalKr > 0) // read the value the amount inserted and assign it to AmountInserted
        {
            amountInserted = antalKr;
            ptm.insertCoin(amountInserted);
        }
        // else // else set the initial value of AmountInserted to 0
        // {
        //     AmountInserted = 0;
        // }
        
        var coin = Convert.ToInt32(formData["insertedCoin"]);
        if (coin != 0) {
            // AmountInserted += coin;
            ptm.insertCoin(coin);
        }
        
        if (formData.ContainsKey("cancel")) {
            // reset the model to its initial state
            ptm = new ParkingTicketMachine();
            ViewBag.cancelTekst = amountInserted + " kr is paid back";
        }
        
        if  (formData.ContainsKey("confirm")) {
            // ptm.insertCoin(AmountInserted);
            // load the receipt view named "confirm" with the model as parameter
            return View("confirm", ptm);
        }
        
        // load the default view with the model as parameter
        return View(ptm);
    }
}
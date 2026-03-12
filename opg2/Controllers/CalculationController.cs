using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using opg2.DAL;

namespace opg2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private Context context = new Context();
        
        [HttpPost]
        [Route("add")]
        public Calculation AddCalculation(Calculation cal)
        {
            context.calculations.Add(cal);
            context.SaveChanges();
            
            return cal;
        }  
        
        [HttpGet]
        [Route("getAll")]
        public IEnumerable<Calculation> GetCalculations()
        {
            return context.calculations.ToList();;
        }
    }
}

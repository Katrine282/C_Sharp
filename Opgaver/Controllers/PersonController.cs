using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Opgaver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private static List<Person> personer = new List<Person>()
        {
            new Person("Mads",25),
            new Person("Anna",30),
            new Person("Jonas",19),
            new Person("Sofie",22),
            new Person("Lukas",28)
        };

        [HttpGet]
        [Route("getAll")]
        public IEnumerable<Person> GetPersoner()
        {
            return personer;
        }
        
        [HttpGet]
        [Route("getbyid/{id}")]
        public Person GetPersonById(int id)
        {
            return personer.FirstOrDefault(p => p.ID == id);
        }

        [HttpPost]
        [Route("add")]
        public Person AddPerson(Person person)
        {
            personer.Add(person);
            return person;
        }
    }
}

using exercise8._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace exercise8._2.Components;

public class VisEnPerson : ViewComponent
{
    public IViewComponentResult Invoke(Person person)
    {
        var modificeret = new Person(person.Efternavn, person.Fornavn);

        return View(modificeret); 
    }
}
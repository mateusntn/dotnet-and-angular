using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    public EventController()
    {
    }

    [HttpGet(Name = "GetEvent")]
    public Event Get()
    {
        return new Event() {
            Id = 1,
            Title = ".NET 5",
            Local = "Udemy",
            Date = DateTime.Now.AddMonths(1),
            Lot = "Firs Lot",
            AmountPeople = 100,
            UrlImage = "https://www.udemy.com/staticx/udemy/images/v7/logo-udemy.svg"
        };
    }
}

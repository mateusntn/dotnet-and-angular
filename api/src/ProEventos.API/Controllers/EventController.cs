using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly DataContext _context;
    public EventController(DataContext context)
    {
        this._context = context;
    }

    [HttpGet(Name = "GetEvent")]
    public IEnumerable<Event> Get()
    {        
        return _context.Events;
    }

    [HttpPost(Name = "CreateEvent")]
    public Event Create(Event dto) 
    {
        _context.Events.Add(dto);
        _context.SaveChanges();
        return dto;
    }
}

using Microsoft.AspNetCore.Mvc;
using OrderAPI.Helper;

namespace OrderAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController: ControllerBase
{
    private readonly Notification _notif;

    public OrderController(Notification not)
    {
        this._notif = not;
    }

    [HttpPost]
    public IActionResult CreateOrder(string msg)
    {
        _notif.AddMessageToQueue(msg);
        return Ok();
    }
}
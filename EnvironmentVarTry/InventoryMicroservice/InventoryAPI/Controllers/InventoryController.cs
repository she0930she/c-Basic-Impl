using InventoryAPI.Helper;
using Microsoft.AspNetCore.Mvc;

namespace InventoryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController:ControllerBase
{
    private RabbitMqQueue _queue;

    public InventoryController(RabbitMqQueue queue)
    {
        _queue = queue;
    }

    [HttpGet]
    public IActionResult GetMessage(string msg)
    {
        //_queue.ReadMessage();
        return Ok();
    }
    
    
}
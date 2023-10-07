using Microsoft.AspNetCore.Mvc;

namespace SupportAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    [HttpGet(Name = "GetAgentChats")]
    public IActionResult Get()
    {
        return NoContent();
    }
    
}
using Microsoft.AspNetCore.Mvc;
using SupportAPI.Interfaces;

namespace SupportAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }


    [HttpGet(Name = "GetAgentChats")]
    public IActionResult Get()
    {
        
        return NoContent();
    }
    
    [HttpPost]
    [Route("InitiateSupportRequest/{customerId}")]
    public IActionResult PostChat(string customerId)
    {
        var model = _chatService.InitiateSupportRequest(customerId);
        if (model is null)
        {
            return NoContent();
        }
        return Ok(model);
        
    }
    
}
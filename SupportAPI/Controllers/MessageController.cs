using Microsoft.AspNetCore.Mvc;
using SupportAPI.Common.Models;
using SupportAPI.Interfaces;

namespace SupportAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private IMessageService _messageService;

    public MessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    [HttpPost]
    [Route("{chatId}/user/{userId}")]
    public async Task<IActionResult> PostMessage(Guid chatId, string userId, [FromBody]MessageInsertModel insertModel)
    {
        var isComplete = await _messageService.PostMessageToChat(chatId, userId, insertModel);
        if (isComplete)
        {
            return NoContent();
        }
        return BadRequest();
        
    }
}
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


    [HttpGet]
    [Route("Agent/{agentId}")]
    public async Task<IActionResult> GetAllChatsForAgent(string agentId)
    {
        var chats = await _chatService.FetchAllChatsForAgent(agentId);
        return Ok(chats);
    }
    
    [HttpGet]
    [Route("{chatId}")]
    public async Task<IActionResult> GetChat(string chatId)
    {
        var chat = await _chatService.GetChat(Guid.Parse(chatId));
        if (chat is null)
        {
            return NotFound();
        }
        return Ok(chat);
    }
    
    [HttpPost]
    [Route("InitiateSupportRequest/{customerId}")]
    public async Task<IActionResult> PostChat(string customerId)
    {
		
        var model = await _chatService.InitiateSupportRequest(customerId);
        return Ok(model);
    }
    
}
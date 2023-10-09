using SupportAPI.Common.Entities;
using SupportAPI.Common.Models;
using SupportAPI.DAL;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class MessageService : IMessageService
{
    private IMessageRepository _messageRepository;

    public MessageService(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task<bool> PostMessageToChat(Guid chatId, string userId, MessageInsertModel insertModel)
    {
        try
        {
            var newMessage = new Message()
            {
                Text = insertModel.Text,
                UserId = userId
            };
            _messageRepository.InsertMessage(newMessage);
            await _messageRepository.SaveAsync();

            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}
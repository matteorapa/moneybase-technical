using SupportAPI.Common.Entities;
using SupportAPI.Common.Models;

namespace SupportAPI.Helpers;

public class AutoMapperProfile : AutoMapper.Profile
{
    
    public AutoMapperProfile()
    {
        CreateMap<Chat, ChatResultModel>();
    }
    
}
using SupportAPI.Common.Entities;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class TeamService : ITeamService
{
    
    public Team GetCurrentTeam(DateTime currentDateTime)
    {
        throw new NotImplementedException();
    }

    public int CalculateCapacityForTeam(Guid teamId)
    {
        throw new NotImplementedException();
    }
}
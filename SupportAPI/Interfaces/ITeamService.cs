using SupportAPI.Common.Entities;

namespace SupportAPI.Interfaces;

public interface ITeamService
{
    public Team GetCurrentTeam(DateTime currentDateTime);

    public int CalculateCapacityForTeam(Guid teamId);
}
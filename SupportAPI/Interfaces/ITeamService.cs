using SupportAPI.Common.Entities;

namespace SupportAPI.Interfaces;

public interface ITeamService
{
    public Task<Team> GetCurrentTeam(DateTime currentDateTime);
    public Task<Team> GetOverflowTeam();

    public int CalculateCapacityForTeam(Team team);

    public Task RequestOverflowTeam();
    public Task<bool> CheckIsOverflowTeamWorking();
}
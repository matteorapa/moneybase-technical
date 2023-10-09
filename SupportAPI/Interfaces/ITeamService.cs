using SupportAPI.Common.Entities;
using SupportAPI.Common.Enums;

namespace SupportAPI.Interfaces;

public interface ITeamService
{
    public Task<Team> GetCurrentTeam(DateTime currentDateTime);
    public Task<Team> GetOverflowTeam();

    public int CalculateCapacityForTeam(Team team);

    public int GetCapacityForSeniority(Seniority seniority);

    public Task RequestOverflowTeam();
    public Task<bool> CheckIsOverflowTeamWorking();
}
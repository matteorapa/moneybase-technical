using SupportAPI.Common.Entities;

namespace SupportAPI.DAL;

public interface ITeamRepository
{
    IQueryable<Team> GetTeams();
    Team GetTeamById(int TeamId);
    void InsertTeam(Team TeamObj);
    void DeleteTeam(int TeamId);
    void UpdateTeam(Team TeamObj);
    void Save();
}
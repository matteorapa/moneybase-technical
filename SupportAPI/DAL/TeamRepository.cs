using SupportAPI.Common.Entities;

namespace SupportAPI.DAL;

public class TeamRepository : ITeamRepository
{
    public IQueryable<Team> GetTeams()
    {
        throw new NotImplementedException();
    }

    public Team GetTeamById(int TeamId)
    {
        throw new NotImplementedException();
    }

    public void InsertTeam(Team TeamObj)
    {
        throw new NotImplementedException();
    }

    public void DeleteTeam(int TeamId)
    {
        throw new NotImplementedException();
    }

    public void UpdateTeam(Team TeamObj)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
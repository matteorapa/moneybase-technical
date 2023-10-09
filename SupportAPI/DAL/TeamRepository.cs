using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.Helpers;

namespace SupportAPI.DAL;

public class TeamRepository : ITeamRepository
{
    
    private ApplicationDbContext context;

    public TeamRepository(ApplicationDbContext context)
    {
        this.context = context;
    }
    
    public IQueryable<Team> GetTeamsIncludeAgentsAndChats()

    {
        return context.Teams.AsQueryable();
        // context.Teams.Include(t => t.Agents).ThenInclude(a => a.Chats).Select(t =>
        // {
        //     Agents = t.Agents.ForEach()
        // });
        // throw new NotImplementedException();
        //
        // var q = from d in Model.Discussions
        //     select new DiscussionPresentation
        //     {
        //         Subject = d.Subject,
        //         MessageCount = d.Messages.Count(),
        //     };
    }

    public IQueryable<Team> GetTeams()

    {
        return context.Teams.AsQueryable();
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
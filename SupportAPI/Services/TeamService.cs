using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Enums;
using SupportAPI.DAL;
using SupportAPI.Interfaces;

namespace SupportAPI.Services;

public class TeamService : ITeamService
{
    
    private ITeamRepository _teamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }
 
    public async Task<Team> GetCurrentTeam(DateTime currentDateTime)
    {
        var currentTeam = await _teamRepository
            .GetTeams()
            .Where(t => t.IsOverflow == false)
            .Include(t => t.Agents)
            .FirstOrDefaultAsync(t => currentDateTime.Hour >= t.StartAt.Hour && currentDateTime.Hour < t.FinishAt.Hour);
        return currentTeam;
    }

    public async Task<Team> GetOverflowTeam()
    {
        var overflowTeam = await _teamRepository
            .GetTeams()
            .Where(t => t.IsOverflow).FirstOrDefaultAsync();
        return overflowTeam;
    }

    public int CalculateCapacityForTeam(Team team)
    {
        int teamCapacity = 0;
        foreach (var agent in team.Agents)
        {
            if (agent.IsOnline)
            {
                var agentCapacity = GetCapacityForSeniority(agent.Seniority);
                teamCapacity += agentCapacity;
            }
        }
        return teamCapacity;
    }

    public async Task RequestOverflowTeam()
    {
        // get overflow team
        var overflowTeam = await _teamRepository.GetTeams().Where(t => t.IsOverflow == false).FirstAsync();
        overflowTeam.IsOnline = true;
        _teamRepository.UpdateTeam(overflowTeam);
        _teamRepository.Save();
    }

    public async Task<bool> CheckIsOverflowTeamWorking()
    {
        return await _teamRepository.GetTeams()
            .Where(t => t.IsOverflow == true)
            .Select(t => t.IsOnline)
            .FirstAsync();
    }

    private int GetCapacityForSeniority(Seniority seniority)
    {
        double actualCapacity = 0;
        var baseCapacity = 10;
        switch (seniority)
        {
            case Seniority.Junior:
                actualCapacity = baseCapacity * 0.4;
                break;
            case Seniority.MidLevel:
                actualCapacity = baseCapacity * 0.6;
                break;
            case Seniority.Senior:
                actualCapacity = baseCapacity * 0.8;
                break;
            case Seniority.TeamLead:
                actualCapacity = baseCapacity * 0.5;
                break;
        }

        return (int)actualCapacity;
    }
}
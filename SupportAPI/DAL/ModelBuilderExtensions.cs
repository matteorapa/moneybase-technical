using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.Common.Enums;

namespace SupportAPI.DAL;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id = Guid.Parse("e491ffff-b197-4cdf-859c-a103bdf63fc5"),
                TeamName =  "Team A",
                StartAt = new DateTime(2023, 12, 31, 6, 0, 0),
                FinishAt = new DateTime(2023, 12, 31, 14, 0, 0)
            },
            new Team
            {
                Id = Guid.Parse("675d7017-f2f6-4460-9405-36bcf16fbc1e"),
                TeamName = "Team B",
                StartAt = new DateTime(2023, 12, 31, 14, 0, 0),
                FinishAt = new DateTime(2023, 12, 31, 22, 0, 0)
            },
            new Team
            {
                Id = Guid.Parse("e6f027fb-2f6d-4f45-8d95-a53f1e813bec"),
                TeamName = "Team C",
                IsNightShift = true,
                StartAt = new DateTime(2023, 12, 31, 22, 0, 0),
                FinishAt = new DateTime(2023, 12, 31, 6, 0, 0)
            },
            new Team
            {
                Id = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"),
                TeamName = "Overflow Team",
                IsOverflow = true,
                StartAt = new DateTime(2023, 12, 31, 6, 0, 0),
                FinishAt = new DateTime(2023, 12, 31, 22, 0, 0)
            }
        );
        
        
        modelBuilder.Entity<Agent>().HasData(
            // agents for team A
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e491ffff-b197-4cdf-859c-a103bdf63fc5"), Seniority = Seniority.TeamLead, IsOnline = true},
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e491ffff-b197-4cdf-859c-a103bdf63fc5"), Seniority = Seniority.MidLevel, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e491ffff-b197-4cdf-859c-a103bdf63fc5"), Seniority = Seniority.MidLevel, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e491ffff-b197-4cdf-859c-a103bdf63fc5"), Seniority = Seniority.Junior, IsOnline = true },
            
            // agents for team B
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("675d7017-f2f6-4460-9405-36bcf16fbc1e"), Seniority = Seniority.Senior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("675d7017-f2f6-4460-9405-36bcf16fbc1e"), Seniority = Seniority.MidLevel, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("675d7017-f2f6-4460-9405-36bcf16fbc1e"), Seniority = Seniority.MidLevel, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("675d7017-f2f6-4460-9405-36bcf16fbc1e"), Seniority = Seniority.Junior, IsOnline = true },
            
            // agents for team C
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e6f027fb-2f6d-4f45-8d95-a53f1e813bec"), Seniority = Seniority.MidLevel, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("e6f027fb-2f6d-4f45-8d95-a53f1e813bec"), Seniority = Seniority.MidLevel, IsOnline = true },
            
            // agents for overflow team
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true },
            new Agent { Id = Guid.NewGuid().ToString(), TeamId = Guid.Parse("1199495b-9684-4ab3-84f3-d6ff04ac8d83"), Seniority = Seniority.Junior, IsOnline = true }
        );


        modelBuilder.Entity<Customer>().HasData(new Customer { Id = Guid.Parse("3d2f8c6a-a206-4f99-a2ff-c5206c41741b").ToString(), AccountId = Guid.Parse("7100d2c8-918f-4d12-809b-28995482d85d") });
    }
}
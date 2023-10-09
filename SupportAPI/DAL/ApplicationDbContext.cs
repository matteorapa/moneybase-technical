using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;
using SupportAPI.DAL;

namespace SupportAPI.Helpers;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
       
    }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Agents { get; set; }
    public DbSet<Agent> Customers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
    
    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
    
}
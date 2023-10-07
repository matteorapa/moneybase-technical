using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SupportAPI.Common.Entities;

namespace SupportAPI.Helpers;

public class ApplicationDbContext : IdentityDbContext<User>
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
    
}
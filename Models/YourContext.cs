using Microsoft.EntityFrameworkCore;
namespace Belt.Models
{
    public class YourContext :DbContext
    {
        public YourContext(DbContextOptions<YourContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<ActivityEvent> Activites {get;set;}
        public DbSet <Guest> Links {get;set;}
    }
}
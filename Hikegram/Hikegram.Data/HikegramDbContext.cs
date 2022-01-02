using Hikegram.Data.Repositories.Events.Models;
using Hikegram.Data.Repositories.EventUsers.Models;
using Hikegram.Data.Repositories.Roles.Models;
using Hikegram.Data.Repositories.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hikegram.Data
{
  public class HikegramDbContext : IdentityDbContext<User, Role, int>
  {
    public HikegramDbContext(DbContextOptions<HikegramDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventUser> EventUsers {get;set;}
  }
}
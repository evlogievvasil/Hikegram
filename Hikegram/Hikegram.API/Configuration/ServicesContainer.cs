using Hikegram.Data;
using Hikegram.Data.Repositories.Common;
using Hikegram.Data.Repositories.Roles.Models;
using Hikegram.Data.Repositories.Users;
using Hikegram.Data.Repositories.Events;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Hikegram.Services.Events;
using Hikegram.Services.Users;

namespace Hikegram.API.Configuration
{
  public static class ServicesContainer
  {
    public static void RegisterServices(WebApplicationBuilder builder)
    {
      builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

      builder.Services.AddDbContext<HikegramDbContext>(options =>
      {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), options =>
          {
            options.MigrationsAssembly(typeof(HikegramDbContext).Assembly.FullName?.Split(',')[0]);
          });
      });

      builder.Services.AddControllers();

      builder.Services.AddIdentity<User, Role>(options =>
        {
          options.SignIn.RequireConfirmedAccount = false;
          options.Password.RequiredLength = 8;
          options.Password.RequireNonAlphanumeric = false;
          options.Password.RequireUppercase = false;
          options.User.RequireUniqueEmail = true;
        })
        .AddEntityFrameworkStores<HikegramDbContext>();


      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();
      builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      // Repositories
      builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
      builder.Services.AddScoped<IEventRepository, EventRepository>();

      //Services
      builder.Services.AddScoped<IEventService, EventService>();
      builder.Services.AddScoped<IUserService, UserService>();
    }
  }
}

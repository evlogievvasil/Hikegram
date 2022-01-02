using Hikegram.Services.Users.Models;

namespace Hikegram.Services.Users
{
  public interface IUserService
  {
    Task CreateAsync(UserCreateRequestModel model);
  }
}
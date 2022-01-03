using AutoMapper;
using Hikegram.Data.Repositories.Users;
using Hikegram.Services.Common;
using Hikegram.Services.Users.Models;
using Microsoft.AspNetCore.Identity;

namespace Hikegram.Services.Users
{
  public class UserService : BaseService, IUserService
  {
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager) : base(mapper)
    {
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public async Task RegisterAsync(UserCreateRequestModel model)
    {
      var user = _mapper.Map<User>(model);

      var result = await _userManager.CreateAsync(user, model.Password);

      if (result.Succeeded)
      {
        await _signInManager.SignInAsync(user, isPersistent: false);
      }
      else
      {
        throw new ArgumentException("Неуспешна регистрация.");
      }
    }
  }
}

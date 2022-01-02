using AutoMapper;
using Hikegram.Services.Common;
using Hikegram.Services.Users.Models;

namespace Hikegram.Services.Users
{
  public class UserService : BaseService, IUserService
  {
    public UserService(IMapper mapper) : base(mapper)
    {
    }

    public Task CreateAsync(UserCreateRequestModel model)
    {
      throw new NotImplementedException();
    }

    //public Task CreateAsync(UserCreateRequestModel model)
    //{
    //  if (model.Password != model.ConfirmPassword)
    //  {
    //    throw new ArgumentException("Въведените пароли не съвпадат.");
    //  }

    //  var user = _mapper.Map<User>(model);


    //}
  }
}

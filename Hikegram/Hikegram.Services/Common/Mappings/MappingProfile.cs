using AutoMapper;
using Hikegram.Data.Repositories.Events.Models;
using Hikegram.Data.Repositories.Users;
using Hikegram.Services.Events.Models;
using Hikegram.Services.Users.Models;

namespace Hikegram.Services.Common.Mappings
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<User, UserCreateModel>().ReverseMap();
      CreateMap<User, UserCreateRequestModel>().ReverseMap();
      CreateMap<Event, EventCreateRequestModel>().ReverseMap();

    }
  }
}

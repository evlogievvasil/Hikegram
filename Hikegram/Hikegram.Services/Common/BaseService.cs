using AutoMapper;

namespace Hikegram.Services.Common
{
  public abstract class BaseService
  {
    protected readonly IMapper _mapper;

    public BaseService(IMapper mapper)
    {
      _mapper = mapper;
    }

    //public HikegramDbContext Context => _context;
  }
}
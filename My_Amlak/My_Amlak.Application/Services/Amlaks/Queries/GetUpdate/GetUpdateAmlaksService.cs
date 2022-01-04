using My_Amlak.Application.Interfaces;

namespace My_Amlak.Application.Services.Amlaks.Queries.GetUpdate
{
    public class GetUpdateAmlaksService : IGetUpdateAmlaksService
    {
        public readonly IDatabaseContext _context;
        public GetUpdateAmlaksService(IDatabaseContext context)
        {
            _context = context;
        }
        public GetUpdateAmlaksResDto Execute(GetUpdateAmlaksReqDto request)
        {
            var User = _context.Amlaks.Find(request.Id);
            return new GetUpdateAmlaksResDto { Id=request.Id, Name = User.Name, Address = User.Address, Price = User.Price, Area = User.Area, Facilities = User.Facilities };
        }
    }

}

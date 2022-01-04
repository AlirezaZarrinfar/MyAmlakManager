using My_Amlak.Application.Interfaces;

namespace My_Amlak.Application.Services.Users.Queries.GetUsersUpdate
{
    public class GetUsersUpdateService : IGetUsersUpdateService
    {
        public readonly IDatabaseContext _context;
        public GetUsersUpdateService(IDatabaseContext context)
        {
            _context = context;
        }
        public GetUsersUpdateResDto Execute(GetUsersUpdateReqDto request)
        {
            var Users = _context.Users.Find(request.Id);
            return new GetUsersUpdateResDto { Name = Users.Name, LastName = Users.LastName, NationalCode = Users.NationalCode ,Id=Users.Id};
        }
    }
}

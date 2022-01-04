using My_Amlak.Application.Interfaces;
using System.Linq;

namespace My_Amlak.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        public readonly IDatabaseContext _context;
        public GetUsersService(IDatabaseContext context)
        {
            _context = context;
        }
        public GetUsersResultDto Execute(GetUsersRequestDto requests)
        {
            var Users = _context.Users.AsQueryable();
            if (!string.IsNullOrEmpty(requests.Searchkey))
            {
                Users = Users.Where(p => p.Name.Contains(requests.Searchkey) || p.LastName.Contains(requests.Searchkey) || p.NationalCode.Contains(requests.Searchkey));
            }
            var user = Users.Select(p => new GetUsersDto
            {
                Id = p.Id,
                Name = p.Name,
                LastName = p.LastName,
                NationalCode = p.NationalCode
            }).ToList();
            return new GetUsersResultDto {
                getUsers = user
        };
        }
    }

}

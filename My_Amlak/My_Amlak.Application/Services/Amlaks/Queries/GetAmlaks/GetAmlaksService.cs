using My_Amlak.Application.Interfaces;
using System.Linq;

namespace My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks
{
    public class GetAmlaksService : IGetAmlaksService
    {
        public readonly IDatabaseContext _context;
        public GetAmlaksService(IDatabaseContext context)
        {
            _context = context;
        }
        public GetAmlaksResultDto Execute(GetAmlaksRequestDto requests)
        {
            var Amlaks = _context.Amlaks.Where(p => p.UserId == requests.UserId);
            var Owner = _context.Users.Find(requests.UserId);
            if (!string.IsNullOrEmpty(requests.Searchkey))
            {
                Amlaks = Amlaks.Where(p => p.Name.Contains(requests.Searchkey) || p.Address.Contains(requests.Searchkey) || p.Area.Contains(requests.Searchkey) || p.Price.Contains(requests.Searchkey) || p.Facilities.Contains(requests.Searchkey));
            }

            var amlak = Amlaks.Select(p => new GetAmlaksDto
            {
                MelkId = p.Id,
                UserId = p.UserId,
                Name = p.Name,
                Address = p.Address,
                Area = p.Area,
                Facilities = p.Facilities,
                Price = p.Price
            }).ToList();
                return new GetAmlaksResultDto { getAmlaks = amlak , OwnerName = Owner.Name,OwnerLastName = Owner.LastName , OwnerId = requests.UserId};
        }
    }
}

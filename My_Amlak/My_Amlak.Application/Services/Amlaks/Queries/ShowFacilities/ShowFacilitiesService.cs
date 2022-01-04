using My_Amlak.Application.Interfaces;
using System.Linq;

namespace My_Amlak.Application.Services.Amlaks.Queries.ShowFacilities
{
    public class ShowFacilitiesService : IShowFacilitiesService
    {
        public readonly IDatabaseContext _context;
        public ShowFacilitiesService(IDatabaseContext context)
        {
            _context = context;
        }
    
        public ShowFacilitiesResDto Execute(ShowFacilitiesReqDto requests)
        {
            var melkfacilities = _context.Amlaks.Where(p => p.Id == requests.MelkId && p.UserId == requests.UserId).ToList();
            var melkfas = melkfacilities.Select(p => new ShowFacilitiesResDto { Facilities = p.Facilities});
            return melkfas.FirstOrDefault();
        }
    }
}

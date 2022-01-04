using My_Amlak.Application.Interfaces;
using My_Amlak.Domain.Entities.Users;

namespace My_Amlak.Application.Services.Amlaks.Commands.AddMelk
{
    public class AddMelkService : IAddMelkService
    {
        public readonly IDatabaseContext _context;
        public AddMelkService(IDatabaseContext context)
        {
            _context = context;
        }
        public AddMelkResultDto Execute(AddMelkRequestDto request)
        {
            try
            {
                if (request.UserID != 0 && !string.IsNullOrEmpty(request.Name) && !string.IsNullOrEmpty(request.Address) && !string.IsNullOrEmpty(request.Area) && !string.IsNullOrEmpty(request.Facilities) && !string.IsNullOrEmpty(request.Price))
                {
                    Amlak amlak = new Amlak
                    {
                        Name = request.Name,
                        Address = request.Address,
                        Area = request.Area,
                        Price = request.Price,
                        Facilities = request.Facilities,
                        UserId = request.UserID
                    };
                    _context.Amlaks.Add(amlak);
                    _context.SaveChanges();
                    return new AddMelkResultDto { IsSuccess = true };
                }
                else
                {
                    return new AddMelkResultDto { IsSuccess = false };
                }
            }
            catch
            {
                return new AddMelkResultDto { IsSuccess = false };
            }
        }
    }
}

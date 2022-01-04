using My_Amlak.Application.Interfaces;

namespace My_Amlak.Application.Services.Amlaks.Commands
{
    public class DeleteAmlakService : IDeleteAmlakService
    {

        public readonly IDatabaseContext _context;
        public DeleteAmlakService(IDatabaseContext context)
        {
            _context = context;
        }

        public DeleteAmlakResultDto Execute(DeleteAmlakRequestDto requests)
        {
            try
            {
                if (requests != null)
                {
                    var Melk = _context.Amlaks.Find(requests.MelkId);
                    _context.Amlaks.Remove(Melk);
                    _context.SaveChanges();
                    return new DeleteAmlakResultDto { IsSuccess = true };
                }
                else
                {
                    return new DeleteAmlakResultDto { IsSuccess = false };
                }
            }
            catch
            {
                return new DeleteAmlakResultDto { IsSuccess = false };
            }
        }
    }
}

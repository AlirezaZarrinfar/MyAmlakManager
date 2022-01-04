using My_Amlak.Application.Interfaces;
using System;

namespace My_Amlak.Application.Services.Users.Commands.DeleteUsers
{
    public class DeleteUsersService : IDeleteUsersService
    {
        public readonly IDatabaseContext _context;
        public DeleteUsersService(IDatabaseContext context)
        {
            _context = context;
        }

       public DeleteUsersResultDto Execute(DeleteUsersRequestDto request)
        {
            try
            {
                var Users = _context.Users.Find(request.Id);
                if (Users != null)
                {
                    _context.Users.Remove(Users);
                    _context.SaveChanges();
                    return new DeleteUsersResultDto { IsSuccess = true };
                }
                else
                {
                    return new DeleteUsersResultDto { IsSuccess = false };
                }
            }
            catch(Exception ex)
            {
                return new DeleteUsersResultDto { IsSuccess = false };
            }
        }
    }
}

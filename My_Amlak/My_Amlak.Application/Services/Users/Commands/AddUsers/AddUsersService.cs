using My_Amlak.Application.Interfaces;
using My_Amlak.Domain.Entities.Users;
using System;

namespace My_Amlak.Application.Services.Users.Commands.AddUsers
{
    public class AddUsersService : IAddUsersService
    {

        public readonly IDatabaseContext _context;
        public AddUsersService(IDatabaseContext context)
        {
            _context = context;
        }
        public AddUsersResultDto Execute(AddUsersRequestDto requests)
        {
            try {
                if (!string.IsNullOrEmpty(requests.Name) && !string.IsNullOrEmpty(requests.LastName) && !string.IsNullOrEmpty(requests.NationalCode))
                {
                    User user = new User
                    {
                        Name = requests.Name,
                        LastName = requests.LastName,
                        NationalCode = requests.NationalCode
                    };
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    return new AddUsersResultDto { IsSuccess = true };
                }
                else
                {
                    return new AddUsersResultDto { IsSuccess = false };
                }
            }
            catch(Exception ex)
            {
                return new AddUsersResultDto { IsSuccess = false };
            }
        }
    }

}

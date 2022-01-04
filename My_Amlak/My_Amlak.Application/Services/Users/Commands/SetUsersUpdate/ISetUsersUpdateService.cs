using My_Amlak.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Users.Commands.SetUsersUpdate
{
    public interface ISetUsersUpdateService
    {
        public SetUsersUpdateResDto Execute(SetUsersUpdateReqDto requests);
    }
    public class SetUsersUpdateService : ISetUsersUpdateService
    {
        public readonly IDatabaseContext _context;
        public SetUsersUpdateService(IDatabaseContext context)
        {
            _context = context;
        }

        public SetUsersUpdateResDto Execute (SetUsersUpdateReqDto requests)
        {
            try
            {
                if (!string.IsNullOrEmpty(requests.Name)&& !string.IsNullOrEmpty(requests.LastName)&& !string.IsNullOrEmpty(requests.NationalCode))
                {
                    var Users = _context.Users.Find(requests.Id);
                    Users.Name = requests.Name;
                    Users.LastName = requests.LastName;
                    Users.NationalCode = requests.NationalCode;
                    _context.SaveChanges();
                    return new SetUsersUpdateResDto { IsSuccess = true };
                }
                else
                {
                    return new SetUsersUpdateResDto { IsSuccess = false };
                }
            }
            catch
            {
                return new SetUsersUpdateResDto { IsSuccess = false };
            }
        }
    }
    public class SetUsersUpdateReqDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
    public class SetUsersUpdateResDto
    {
        public bool IsSuccess { get; set; }
    }
}

using System;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUsersService
    {
        public GetUsersResultDto Execute(GetUsersRequestDto requests);
    }

}

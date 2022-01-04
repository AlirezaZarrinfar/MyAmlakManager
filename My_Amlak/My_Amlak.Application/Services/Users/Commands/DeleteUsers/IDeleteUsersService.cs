using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Users.Commands.DeleteUsers
{
    public interface IDeleteUsersService
    {
         DeleteUsersResultDto Execute(DeleteUsersRequestDto request);
    }
}

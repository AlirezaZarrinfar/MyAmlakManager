using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Users.Commands.AddUsers
{
    public interface IAddUsersService
    {
        public AddUsersResultDto Execute(AddUsersRequestDto requests);
    }

}

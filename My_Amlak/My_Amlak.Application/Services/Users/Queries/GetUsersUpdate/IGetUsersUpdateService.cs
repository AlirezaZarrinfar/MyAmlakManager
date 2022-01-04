using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Users.Queries.GetUsersUpdate
{
    public interface IGetUsersUpdateService
    {
        public GetUsersUpdateResDto Execute(GetUsersUpdateReqDto request);
    }
}

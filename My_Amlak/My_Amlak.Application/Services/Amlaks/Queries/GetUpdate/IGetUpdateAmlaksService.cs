using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Amlaks.Queries.GetUpdate
{
    public interface IGetUpdateAmlaksService
    {
        public GetUpdateAmlaksResDto Execute(GetUpdateAmlaksReqDto request);

    }

}

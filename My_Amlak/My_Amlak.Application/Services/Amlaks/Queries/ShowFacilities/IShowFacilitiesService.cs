using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Amlaks.Queries.ShowFacilities
{
    public interface IShowFacilitiesService
    {
        public ShowFacilitiesResDto Execute(ShowFacilitiesReqDto requests);

    }
}

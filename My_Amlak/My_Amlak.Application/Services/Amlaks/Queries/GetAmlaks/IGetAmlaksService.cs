using System;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks
{
    public interface IGetAmlaksService
    {
        public GetAmlaksResultDto Execute(GetAmlaksRequestDto requests);
    }
}

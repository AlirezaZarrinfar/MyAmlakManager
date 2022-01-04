using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Amlaks.Commands.AddMelk
{
    public interface IAddMelkService
    {
        public AddMelkResultDto Execute(AddMelkRequestDto request);
    }
}

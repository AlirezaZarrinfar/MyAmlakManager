using System.Collections.Generic;

namespace My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks
{
    public class GetAmlaksResultDto
    {
        public List<GetAmlaksDto> getAmlaks { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName { get; set; }
        public long OwnerId { get; set; }
    }
}

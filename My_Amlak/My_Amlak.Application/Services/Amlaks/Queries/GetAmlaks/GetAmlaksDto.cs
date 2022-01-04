namespace My_Amlak.Application.Services.Amlaks.Queries.GetAmlaks
{
    public class GetAmlaksDto
    {
        public long MelkId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Area { get; set; }
        public string Facilities { get; set; }
        public long UserId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName { get; set; }

    }
}

namespace My_Amlak.Application.Services.Amlaks.Commands.AddMelk
{
    public class AddMelkRequestDto
    {
        public long UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Area { get; set; }
        public string Facilities { get; set; }
    }
}

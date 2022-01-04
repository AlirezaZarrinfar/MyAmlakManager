using My_Amlak.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Application.Services.Amlaks.Commands
{
    public interface ISetUpdateAmlaksService
    {
        public SetUpdateAmlaksResDto Execute(SetUpdateAmlaksReqDto request);
    }
    public class SetUpdateAmlaksService : ISetUpdateAmlaksService
    {
        public readonly IDatabaseContext _context;
        public SetUpdateAmlaksService(IDatabaseContext context)
        {
            _context = context;
        }
        public SetUpdateAmlaksResDto Execute(SetUpdateAmlaksReqDto request)
        {
            try
            {
                if (request.MelkId != 0 && !string.IsNullOrEmpty(request.Name) && !string.IsNullOrEmpty(request.Address) && !string.IsNullOrEmpty(request.Area) && !string.IsNullOrEmpty(request.Facilities) && !string.IsNullOrEmpty(request.Price))
                {
                    var user = _context.Amlaks.Find(request.MelkId);
                    user.Name = request.Name;
                    user.Address = request.Address;
                    user.Area = request.Area;
                    user.Price = request.Price;
                    user.Facilities = request.Facilities;
                    _context.SaveChanges();
                    return new SetUpdateAmlaksResDto { IsSuccess = true };
                }
                else
                {
                    return new SetUpdateAmlaksResDto { IsSuccess = false };
                }
            }
            catch
            {
                return new SetUpdateAmlaksResDto { IsSuccess = false };
            }
        }
    }
    public class SetUpdateAmlaksReqDto
    {
        public long MelkId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Area { get; set; }
        public string Facilities { get; set; }
    }
    public class SetUpdateAmlaksResDto
    {
        public bool IsSuccess { get; set; }
    }
}

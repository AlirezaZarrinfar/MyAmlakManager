using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Amlak.Domain.Entities.Users
{
   public  class Amlak
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
        public string Area { get; set; }
        public string Facilities { get; set; }
        public virtual User User { get; set; }
        public long UserId { get; set; }

    }
}

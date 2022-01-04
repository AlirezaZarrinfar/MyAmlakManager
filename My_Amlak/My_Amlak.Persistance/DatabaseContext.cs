using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Amlak.Domain.Entities.Users;
using My_Amlak.Application.Interfaces;

namespace My_Amlak.Persistance
{
    public class DatabaseContext : DbContext , IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options) : base (options)
        {
                
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Amlak> Amlaks { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using My_Amlak.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Amlak.Application.Interfaces
{
    public interface IDatabaseContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Amlak> Amlaks { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}

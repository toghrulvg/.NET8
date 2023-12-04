using Application.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            await Table.AddAsync(model);
        }

        public Task<bool> AddRangeAsync(List<T> model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}

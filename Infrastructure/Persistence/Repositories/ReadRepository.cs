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
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();


        public IQueryable<T> GetAll() => Table;


        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method) => Table.Where(method);
        

        public async Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method) =>await Table.FirstOrDefaultAsync(method);




        public async Task<T> GetById(int id) =>await Table.FirstOrDefaultAsync(m => m.Id == id);
        
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistrations
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=DESKTOP-6C1B05Q\\SQLEXPRESS;Database=UniversalDB;Trusted_Connection=True;"));
        }
    }
}

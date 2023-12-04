using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstarctions
{
    public interface IProductService
    {
        public List<Product> GetProducts();
    }
}

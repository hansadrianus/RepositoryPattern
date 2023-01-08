using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Products;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Products
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IApplicationContext context) : base(context)
        {
        }
    }
}

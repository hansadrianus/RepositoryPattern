﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Persistence.Products
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
    }
}

using System;
using System.Collections.Generic;

namespace ASPNET.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

    }
}

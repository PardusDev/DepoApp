using DepoApp.DAL.Gateway;
using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Manager
{
    public class ProductManager
    {
        ProductGateway _productGateway = new ProductGateway();
        public bool Add(Product product)
        {
            return _productGateway.Add(product);
        }

        public DbSet<Product> GetAll()
        {
            return _productGateway.GetAll();
        }

        public bool Update(Product product)
        {
            return _productGateway.Update(product);
        }

        public bool Remove(Product product)
        {
            return _productGateway.Remove(product);
        }
    }
}

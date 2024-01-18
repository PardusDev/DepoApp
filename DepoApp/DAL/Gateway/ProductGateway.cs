using DepoApp.DAL.Context;
using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Gateway
{
    public class ProductGateway
    {
        DepoDbContext db = new DepoDbContext();

        public bool Add(Product product)
        {
            try
            {
                db.Products.Add(product);
                return (db.SaveChanges() > 0);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public DbSet<Product> GetAll()
        {
            try
            {
                return db.Products;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Update(Product product)
        {
            try
            {
                var existingProduct = db.Products.Find(product);
                existingProduct.name = product.name;
                return (db.SaveChanges() > 0);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Remove(Product product)
        {
            try
            {
                var existingProduct = db.Products.Find(product.id);
                db.Products.Remove(existingProduct);
                return (db.SaveChanges() > 0);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

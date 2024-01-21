using DepoApp.DAL.Context;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Gateway
{
    public class CategoryGateway
    {
        DepoDbContext db = new DepoDbContext();

        public bool Add(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }

        public bool Update(Category category)
        {
            db.Categories.Update(category);
            return db.SaveChanges() > 0;
        }

        public bool Remove(Category category)
        {
            db.Categories.Remove(category);
            return db.SaveChanges() > 0;
        }

        public bool RemoveById(int id)
        {
            var category = db.Categories.Find(id);
            db.Categories.Remove(category);
            return db.SaveChanges() > 0;
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
    }
}

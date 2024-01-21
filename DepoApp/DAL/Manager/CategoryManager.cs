using DepoApp.DAL.Gateway;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Manager
{
    public class CategoryManager
    {
        CategoryGateway _categoryGateway = new CategoryGateway();

        public bool Add(Category category)
        {
            return _categoryGateway.Add(category);
        }

        public bool Update(Category category)
        {
            return _categoryGateway.Update(category);
        }

        public bool Remove(Category category)
        {
            return _categoryGateway.Remove(category);
        }

        public bool RemoveById(int id)
        {
            return _categoryGateway.RemoveById(id);
        }

        public List<Category> GetAll()
        {
            return _categoryGateway.GetAll();
        }
    }
}

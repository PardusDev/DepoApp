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
    public class StorageItemManager
    {
        StorageItemGateway _storageItemGateway = new StorageItemGateway();

        public bool Add(StorageItem storageItem)
        {
            return _storageItemGateway.Add(storageItem);
        }

        public DbSet<StorageItem> GetAll()
        {
            return _storageItemGateway.GetAll();
        }

        public bool Update(StorageItem storageItem)
        {
            return _storageItemGateway.Update(storageItem);
        }
    }
}

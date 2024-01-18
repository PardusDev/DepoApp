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
    public class StorageItemGateway
    {
        DepoDbContext db = new DepoDbContext();

        public bool Add(StorageItem storageItem)
        {
            try
            {
                db.StorageItems.Add(storageItem);
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public DbSet<StorageItem> GetAll()
        {
            try
            {
                return db.StorageItems;
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Update(StorageItem storageItem)
        {
            try
            {
                var existingStorageItem = db.StorageItems.Find(storageItem.id);
                existingStorageItem.count = storageItem.count;
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

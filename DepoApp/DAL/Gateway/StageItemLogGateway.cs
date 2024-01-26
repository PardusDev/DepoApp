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
    public class StorageItemLogGateway
    {
        DepoDbContext db = new DepoDbContext();

        public bool Add(StorageItemLog stageItemLog)
        {
            try
            {
                db.StorageItemLogs.Add(stageItemLog);
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<StorageItemLog> GetAll()
        {
            try
            {
                return db.StorageItemLogs.ToList();
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<StorageItemLog> GetAllByStorageItem(StorageItem storageItem)
        {
            try
            {
                return db.StorageItemLogs.Where(s => s.storageItemId == storageItem.id).ToList();
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Update (StorageItemLog storageItemLog)
        {
            try
            {
                var existingStageItemLog = db.StorageItemLogs.Find(storageItemLog.id);
                existingStageItemLog.count = storageItemLog.count;
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public StorageItem getStorageItem(StorageItemLog storageItemLog)
        {
            StorageItem storageItem = db.StorageItems.Include(si => si.product).FirstOrDefault(si => si.id == storageItemLog.storageItemId);
            if (storageItem != null)
                return storageItem;
            else
                return new StorageItem();
                
        }
    }
}

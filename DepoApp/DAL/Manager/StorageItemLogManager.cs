using DepoApp.DAL.Gateway;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Manager
{
    public class StorageItemLogManager
    {
        StorageItemLogGateway _storageItemLogGateway = new StorageItemLogGateway();

        public bool Add(StorageItemLog storageItemLog)
        {
            return _storageItemLogGateway.Add(storageItemLog);
        }

        public List<StorageItemLog> GetAll()
        {
            return _storageItemLogGateway.GetAll();
        }

        public List<StorageItemLog> GetAllByStorageItem(StorageItem storageItem)
        {
            return _storageItemLogGateway.GetAllByStorageItem(storageItem);
        }

        public bool Update(StorageItemLog storageItemLog)
        {
            return _storageItemLogGateway.Update(storageItemLog);
        }

        public StorageItem getStorageItem(StorageItemLog storageItemLog)
        {
            return _storageItemLogGateway.getStorageItem(storageItemLog);
        }

    }
}

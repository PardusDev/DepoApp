using DepoApp.DAL.Gateway;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Manager
{
    public class StorageManager
    {
        StorageGateway _storageGateway = new StorageGateway();

        public bool Add(Storage storage)
        {
            return _storageGateway.Add(storage);      
        }

        public List<Storage> GetAll()
        {
            return _storageGateway.GetAll();
        }

        public bool Update(Storage storage)
        {
            return _storageGateway.Update(storage);
        }

        public bool Remove(Storage storage)
        {
            return _storageGateway.Remove(storage.id);
        }
    }
}

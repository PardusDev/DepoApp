using DepoApp.DAL.Context;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Gateway
{
    public class StorageGateway
    {
        DepoDbContext db = new DepoDbContext();

        public bool Add(Storage storage)
        {
            try
            {
                db.Storages.Add(storage);
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Storage> GetAll()
        {
            try
            {
                return db.Storages.ToList();
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Update(Storage storage)
        {
            try
            {
                var existingStorage = db.Storages.Find(storage.id);
                existingStorage.name = storage.name;
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Remove(int id)
        {
            try
            {
                var existingStorage = db.Storages.Find(id);
                db.Storages.Remove(existingStorage);
                return (db.SaveChanges() > 0);
            } catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}

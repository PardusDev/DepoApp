using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Context
{
    public class DepoDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageItem> StorageItems { get; set; }
        

        public string DbPath { get; }

        //string databaseName = ConfigurationManager.AppSettings["databaseName"];
        string databaseName = "Depo8.db";
        
        

        public DepoDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, databaseName);
            Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource="+databaseName);
        }
    }
}

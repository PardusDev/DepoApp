using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Models
{
    public class Sale
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public StorageItem storageItem { get; set; }

        public int count { get; set; }

        public double price { get; set; }
        
    }
}

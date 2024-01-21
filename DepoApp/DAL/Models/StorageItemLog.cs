using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Models
{
    public class StorageItemLog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int storageItemId { get; set; }

        public int count { get; set; }

        public DateTime date { get; set; }

        // Attention: 1 - Addition, 2 - Sale
        public int transactionType { get; set; }


        // Constructor for Addition
        public StorageItemLog(int storageItemId, int count, int transactionType)
        {
            this.storageItemId = storageItemId;
            this.count = count;
            
            this.transactionType = transactionType;
            this.date = DateTime.Now;
        }

        public StorageItemLog()
        {
            // For Entity Framework
        }
    }
}

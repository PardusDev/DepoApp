using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoApp.UI
{
    public partial class InventoryReport : Form
    {
        StorageItemLogManager _storageItemLogManager = new StorageItemLogManager();

        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            List<StorageItemLog> logs = _storageItemLogManager.GetAll();

            List<StorageItemLog> saleLogs = logs.Where(l => l.transactionType == l.getTransactionIntTypeFromString("Sale")).ToList();
            foreach (StorageItemLog log in saleLogs)
            {
                Product relationalProduct = _storageItemLogManager.getStorageItem(log).product;
                dataGridViewSales.Rows.Add(log.id, relationalProduct.name, log.count, log.date);
            }


            List<StorageItemLog> purchaseLogs = logs.Where(l => l.transactionType == l.getTransactionIntTypeFromString("Purchase")).ToList();
            foreach (StorageItemLog log in purchaseLogs)
            {
                var relationalProduct = _storageItemLogManager.getStorageItem(log);
                if (relationalProduct.product != null)
                    dataGridViewRestock.Rows.Add(log.id, relationalProduct.product.name, log.count, log.date);
                else
                    dataGridViewRestock.Rows.Add(log.id, "<! ÜRÜN BULUNAMADI !>", log.count, log.date);
            }
        }

    }
}

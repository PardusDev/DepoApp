using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        ProductManager _productManager = new ProductManager();

        List<StorageItemLog> allLogs;

        public InventoryReport()
        {
            InitializeComponent();


        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            allLogs = _storageItemLogManager.GetAll();

            List<StorageItemLog> saleLogs = allLogs.Where(l => l.transactionType == l.getTransactionIntTypeFromString("Sale")).ToList();
            foreach (StorageItemLog log in saleLogs)
            {
                Product relationalProduct = _storageItemLogManager.getStorageItem(log).product;
                dataGridViewSales.Rows.Add(log.id, relationalProduct.name, log.count, log.date);
            }

            List<StorageItemLog> purchaseLogs = allLogs.Where(l => l.transactionType == l.getTransactionIntTypeFromString("Purchase")).ToList();
            foreach (StorageItemLog log in purchaseLogs)
            {
                var relationalProduct = _storageItemLogManager.getStorageItem(log);
                if (relationalProduct.product != null)
                    dataGridViewRestock.Rows.Add(log.id, relationalProduct.product.name, log.count, log.date);
                else
                    dataGridViewRestock.Rows.Add(log.id, "<! ÜRÜN BULUNAMADI !>", log.count, log.date);
            }

            List<Product> products = _productManager.GetAll().ToList();
            cmbBxProducts.DataSource = products;
            cmbBxProducts.DisplayMember = "name";
            cmbBxProducts.ValueMember = "id";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)cmbBxProducts.SelectedItem;
            int itemCount = 0;

            DateTime min_date;
            DateTime max_date;

            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            // Month 1-12
            //objChart.AxisX.Minimum = 1;
            //objChart.AxisX.Maximum = 12;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            //objChart.AxisY.Minimum = -50;
            //objChart.AxisY.Maximum = 50;

            chart1.Series.Clear();
            Random random = new Random();

            chart1.Series.Add(selectedProduct.name);
            chart1.Series[selectedProduct.name].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[selectedProduct.name].Legend = "Legend1";
            chart1.Series[selectedProduct.name].ChartArea = "ChartArea1";
            chart1.Series[selectedProduct.name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            foreach (StorageItemLog log in allLogs)
            {
                StorageItem relationalStorageItem = _storageItemLogManager.getStorageItem(log);
                Product relationalProduct = relationalStorageItem.product;
                if (relationalProduct != null) {
                    if (relationalProduct.id == selectedProduct.id)
                    {
                        if (log.transactionType == log.getTransactionIntTypeFromString("Sale"))
                            itemCount -= log.count;
                        else if (log.transactionType == log.getTransactionIntTypeFromString("Purchase"))
                            itemCount += log.count;
                        chart1.Series[relationalProduct.name].Points.AddXY(log.date.Day, itemCount);
                    }
                }
            }
        }
    }
}

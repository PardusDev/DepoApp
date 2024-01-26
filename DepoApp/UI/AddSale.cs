using DepoApp.CustomControls;
using DepoApp.DAL.Context;
using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddSale : Form
    {
        DepoDbContext db = new DepoDbContext();
        CurrencyTextBox currencyTextBox = new CurrencyTextBox();
        StorageItemLogManager storageItemLogManager = new StorageItemLogManager();

        Home home;

        public AddSale(Home home)
        {
            InitializeComponent();

            this.home = home;

            currencyTextBox.Location = new Point(48, 251);
            this.Controls.Add(currencyTextBox);

            if (home.videoCaptureDevice.IsRunning)
            {
                home.videoCaptureDevice.SignalToStop();
            }
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            cmbBxStorages.ValueMember = "id";
            cmbBxStorages.DisplayMember = "name";
            cmbBxStorages.DataSource = db.Storages.ToList();
        }

        private void cmbBxStorages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxStorages.SelectedIndex == -1)
            {
                return;
            }
            cmbBxProducts.Enabled = true;
            var selectedStorage = cmbBxStorages.SelectedValue;

            var products = db.StorageItems.Include(si => si.product).Include(si => si.storage).Where(si => si.storage.id == (int)cmbBxStorages.SelectedValue).ToList();

            // Create a new list for display
            var productDisplayList = products.Select(si => new
            {
                id = si.product.id,
                name = si.product.name
            }).ToList();

            cmbBxProducts.DataSource = productDisplayList;
            cmbBxProducts.ValueMember = "id";
            cmbBxProducts.DisplayMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check comboboxes are selected
            if (cmbBxStorages.SelectedIndex == -1 || cmbBxProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen geçerli bir ürün ve depo seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StorageItem existingStorageItem = db.StorageItems.Include(si => si.product).Include(si => si.storage).Where(si => ((si.product.id == (int)cmbBxProducts.SelectedValue) && (si.storage.id == (int)cmbBxStorages.SelectedValue))).FirstOrDefault();

            // Check if storage item exists
            if (existingStorageItem == null)
            {
                MessageBox.Show("Belirtilen ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if count is valid
            if (existingStorageItem.count < numericUpDown1.Value)
            {
                MessageBox.Show("Belirtilen ürünün stokta yeterli sayıda bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if count is greater than 0
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // did sale
            Sale sale = new Sale();
            sale.storageItem = existingStorageItem;
            sale.count = Convert.ToInt32(numericUpDown1.Value);
            sale.date = DateTime.Now;
            sale.price = Convert.ToDouble(currencyTextBox.Text);

            try
            {
                // Update storage item count. If count is 0, delete storage item
                // But we have a problem. We are using storage item for a sale. So we need to update it.
                // We have to consider this situation. If we delete storage item, we will lose our sale.
                // That's why we are not deleting storage item. We are just updating it. But is it really good idea to hold a StorageItem in the Sale object?
                existingStorageItem.count -= sale.count;
                /*if (existingStorageItem.count == 0)
                {
                    db.StorageItems.Remove(existingStorageItem);
                } else
                {
                    db.StorageItems.Update(existingStorageItem);
                }*/
                db.StorageItems.Update(existingStorageItem);
                db.Sales.Add(sale);
                // Add Log
                StorageItemLog storageItemLog = new StorageItemLog(existingStorageItem.id, sale.count, 2);

                if (db.SaveChanges() > 0 && storageItemLogManager.Add(storageItemLog))
                {
                    MessageBox.Show("Satış başarıyla gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void cmbBxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if combobox is selected
            if (cmbBxProducts.SelectedIndex == -1)
            {
                return;
            }

            // Get selected product
            var selectedProduct = cmbBxProducts.SelectedValue;
            if (selectedProduct != null && selectedProduct.GetType() == typeof(int))
            {
                label3.Text = db.Products.Where(p => p.id == (int)selectedProduct).FirstOrDefault().getMeasurementType() + ":";
            }
        }

        private void txtBxBarcode_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            this.home.scannerTextBox = ((TextBox)sender);
            this.home.videoCaptureDevice.Start();
        }

        private void AddSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.home.videoCaptureDevice.IsRunning)
            {
                this.home.videoCaptureDevice.SignalToStop();
            }
        }

        private void txtBxBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = ((TextBox)sender).Text.Trim();
            Product product = db.Products.Where(p => p.barcode == barcode).FirstOrDefault();
            if (product != null)
            {
                cmbBxProducts.SelectedValue = product.id;
                StorageItem storageItem = db.StorageItems.Include(si => si.product).Include(si => si.storage).Where(si => si.product.id == product.id).FirstOrDefault();
                if (storageItem != null)
                {
                    cmbBxStorages.SelectedValue = storageItem.storage.id;
                }
            }
        }
    }
}

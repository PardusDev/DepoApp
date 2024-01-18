using DepoApp.DAL.Context;
using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddProductToStorage : Form
    {
        
        StorageItemManager _storageItemManager = new StorageItemManager();
        ProductManager _productManager = new ProductManager();
        DepoDbContext db = new DepoDbContext();
        Home home;
        public AddProductToStorage(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void AddProductToStorage_Load(object sender, EventArgs e)
        {
            var products = _productManager.GetAll().OrderBy(p => p.id)
                .ToList();
            cmbBxProducts.ValueMember = "id";
            cmbBxProducts.DisplayMember = "name";

            cmbBxProducts.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StorageItem storageItem = new StorageItem();
            //storageItem.product = _productManager.GetAll().Find(cmbBxProducts.SelectedValue);
            storageItem.product = db.Products.Find(cmbBxProducts.SelectedValue);
            storageItem.count = Convert.ToInt32(numericUpDown1.Value);

            // Check if product already exists in storage
            StorageItem existingStorageItem = _storageItemManager.GetAll().FirstOrDefault(item => item.product == storageItem.product);

            if (existingStorageItem != null)
            {
                //DialogResult dialogResult = MessageBox.Show("Ürün zaten depoda bulunuyor lütfne stok değiştirme işlemi yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult dialogResult = MessageBox.Show("Ürün zaten depoda bulunuyor ve adedi "+ existingStorageItem.count + ". Siz ise bu ürünü " + storageItem.count + " stok adedi ile eklemek istiyordunuz. Ürünün stok adedini "+ (existingStorageItem.count + storageItem.count) + " olarak güncellemek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    updateStorageItem(existingStorageItem, existingStorageItem.count + storageItem.count);
                    home.updateStorageItemDataGridView();
                }
            } else
            {
                try
                {
                    // Degismeli
                    db.StorageItems.Add(storageItem);
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Ürün başarıyla depoya eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            cmbBxProducts.SelectedIndex = 0;
            numericUpDown1.Value = 0;
        }

        private void updateStorageItem(StorageItem storageItem, int stockCount)
        {
            try
            {
                storageItem.count = stockCount;
                if (_storageItemManager.Update(storageItem))
                {
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

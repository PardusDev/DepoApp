using DepoApp.DAL.Context;
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
    public partial class AddSale : Form
    {
        DepoDbContext db = new DepoDbContext();
        public AddSale()
        {
            InitializeComponent();
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

            StorageItem existingStorageItem = db.StorageItems.Include(si => si.product).Include(si => si.storage).Where(si => ((si.product.id == (int) cmbBxProducts.SelectedValue) && (si.storage.id == (int) cmbBxStorages.SelectedValue))).FirstOrDefault();

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
            // Attention! This calculate will be done later
            //sale.price = existingStorageItem.product.price * sale.count;
            sale.price = 0;
            
            try
            {
                // Update storage item count
                // TODO: If count is 0, delete storage item
                existingStorageItem.count -= sale.count;
                db.StorageItems.Update(existingStorageItem);
                db.Sales.Add(sale);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satış başarıyla gerçekleştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } catch (Exception exception)
            {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}

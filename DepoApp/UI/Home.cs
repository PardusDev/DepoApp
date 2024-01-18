using DepoApp.DAL.Context;
using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using DepoApp.UI;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DepoApp
{
    public partial class Home : Form
    {
        DepoDbContext db = new DepoDbContext();
        ProductManager _productManager = new ProductManager();
        StorageManager _storageManager = new StorageManager();
        StorageItemManager _storageItemManager = new StorageItemManager();

        int selectedStorageID = 0;

        public Home()
        {
            InitializeComponent();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            updateProductsDataGridView();

            updateStorageItemDataGridView();

            updateStoragesDataGridView();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();

            DialogResult dialogResult = addProduct.ShowDialog();

            // Form kapandýðýnda çalýþacak kodlar
            updateProductsDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedProductID = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
            Product selectedProduct = _productManager.GetAll().Where(p => p.id == selectedProductID).FirstOrDefault();

            StorageItem storageItem = _storageItemManager.GetAll().Where(item => item.product == selectedProduct).FirstOrDefault();

            if (storageItem != null)
            {
                MessageBox.Show("Bu ürünü silebilmek için önce stoktan silmelisiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_productManager.Remove(selectedProduct))
                {
                    MessageBox.Show("Ürün baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateProductsDataGridView();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region STORAGE
        private void button4_Click(object sender, EventArgs e)
        {
            // Check if the storage name is valid
            txtBxStorageName.Text = txtBxStorageName.Text.Trim();

            // Check if the storage name is empty
            if (string.IsNullOrEmpty(txtBxStorageName.Text))
            {
                MessageBox.Show("Lütfen depo adýný giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the storage name is already exists
            if (_storageManager.GetAll().Where(s => s.name == txtBxStorageName.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Bu depo adý zaten mevcut.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Storage storage = new Storage()
            {
                name = txtBxStorageName.Text
            };

            try
            {
                if (_storageManager.Add(storage))
                {
                    MessageBox.Show("Depo baþarýyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateStoragesDataGridView();
                }
                else
                {
                    MessageBox.Show("Depo eklenirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStorages_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStorages.SelectedRows.Count == 0)
            {
                return;
            }
            // Show panel and setting other values
            panel1.Visible = true;
            txtBxStorageUpdate.Text = dataGridViewStorages.SelectedRows[0].Cells[1].Value.ToString();
            selectedStorageID = Convert.ToInt32(dataGridViewStorages.SelectedRows[0].Cells[0].Value);
        }

        private void btnUpdateStorage_Click(object sender, EventArgs e)
        {
            // Check if the storage id is valid
            if (selectedStorageID != 0)
            {
                txtBxStorageUpdate.Text = txtBxStorageUpdate.Text.Trim();
                // Check if the storage name is empty
                if (string.IsNullOrEmpty(txtBxStorageUpdate.Text))
                {
                    MessageBox.Show("Lütfen depo adýný giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the storage name is already exists
                if (_storageManager.GetAll().Where(s => s.name == txtBxStorageUpdate.Text).FirstOrDefault() != null)
                {
                    MessageBox.Show("Bu depo adý zaten mevcut.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Storage storage = new Storage()
                {
                    id = selectedStorageID,
                    name = txtBxStorageUpdate.Text
                };
                try
                {
                    if (_storageManager.Update(storage))
                    {
                        MessageBox.Show("Depo baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        updateStoragesDataGridView();
                    }
                } catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region StorageItem Area
        private void btnAddNewProductToStorage_Click(object sender, EventArgs e)
        {
            AddProductToStorage addProductToStorage = new AddProductToStorage(this);

            addProductToStorage.ShowDialog();

            // Form kapandýðýnda çalýþacak kodlar
            updateStorageItemDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StorageItem selectedStorageItem = getSelectedStorageItem();
            SetNewCount setNewCount = new SetNewCount(selectedStorageItem);

            DialogResult dialogResult = setNewCount.ShowDialog();

            // When the stock count is updated and closed
            if (dialogResult == DialogResult.OK)
            {
                updateStorageItemDataGridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AreYouSure areYouSure = new AreYouSure();

            DialogResult dialogResult = areYouSure.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                StorageItem selectedStorageItem = getSelectedStorageItem();

                try
                {
                    db.StorageItems.Remove(selectedStorageItem);

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Stoktan baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        updateStorageItemDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Stok silinirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region UTILITY METHODS
        public StorageItem getSelectedStorageItem()
        {
            int selectedStorageItemID = Convert.ToInt32(dataGridViewStorage.SelectedRows[0].Cells[0].Value);
            StorageItem selectedStorageItem = db.StorageItems.Find(selectedStorageItemID);

            return selectedStorageItem;
        }

        public void updateProductsDataGridView()
        {
            dataGridViewProducts.Rows.Clear();
            var products = db.Products.OrderBy(p => p.id)
                .ToList();

            foreach (Product product in products)
            {
                dataGridViewProducts.Rows.Add(product.id, product.name);
            }
        }

        public void updateStoragesDataGridView()
        {
            dataGridViewStorages.Rows.Clear();

            // degismeli manager ile.
            var storages = _storageManager.GetAll();

            foreach (var storage in storages)
            {
                dataGridViewStorages.Rows.Add(storage.id, storage.name);
            }
        }

        public void updateStorageItemDataGridView()
        {
            dataGridViewStorage.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var storageItems = db.StorageItems.Include(s => s.product).Include(s => s.storage).ToList();

                foreach (var storageitem in storageItems)
                {
                    dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count, storageitem.storage.name);
                }
            }
        }

        
        #endregion



        
    }
}

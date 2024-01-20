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
        int selectedCategoryID = 0;

        public Home()
        {
            InitializeComponent();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            updateProductsDataGridView();

            updateStorageItemDataGridView();

            updateStoragesDataGridView();

            updateCategoriesDataGridView();

            updateSalesDataGridView();
        }

        #region PRODUCT

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
        #endregion


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
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region CATEGORY
        private void button4_Click_1(object sender, EventArgs e)
        {
            txtBxCategoryNew.Text = txtBxCategoryNew.Text.Trim();

            // Check if the category name is valid
            if (string.IsNullOrEmpty(txtBxCategoryNew.Text))
            {
                MessageBox.Show("Lütfen kategori adýný giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the category name is already exists
            if (db.Categories.Where(c => c.name == txtBxCategoryNew.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Bu kategori adý zaten mevcut.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Category category = new Category()
            {
                name = txtBxCategoryNew.Text
            };

            try
            {
                db.Categories.Add(category);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Kategori baþarýyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateCategoriesDataGridView();
                }
                else
                {
                    MessageBox.Show("Kategori eklenirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count == 0)
            {
                return;
            }
            // Show panel and setting other values
            panel2.Visible = true;
            txtBxCategoryUpdate.Text = dataGridViewCategories.SelectedRows[0].Cells[1].Value.ToString();
            selectedCategoryID = Convert.ToInt32(dataGridViewCategories.SelectedRows[0].Cells[0].Value);
        }

        // Update Category Button
        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedCategoryID != 0)
            {
                txtBxCategoryUpdate.Text = txtBxCategoryUpdate.Text.Trim();

                // Check if the category name is valid
                if (string.IsNullOrEmpty(txtBxCategoryUpdate.Text))
                {
                    MessageBox.Show("Lütfen kategori adýný giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the category name is already exists
                if (db.Categories.Where(c => c.name == txtBxCategoryUpdate.Text).FirstOrDefault() != null)
                {
                    MessageBox.Show("Bu kategori adý zaten mevcut.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Category category = new Category()
                {
                    id = selectedCategoryID,
                    name = txtBxCategoryUpdate.Text
                };

                try
                {
                    db.Categories.Update(category);

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Kategori baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        updateCategoriesDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Kategori güncellenirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
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
            // Check any row is selected
            if (dataGridViewStorage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            // Attention: Search term is lowercased
            string searchTerm = (txtBxSearchProductName.Text.Trim()).ToLower();
            using (DepoDbContext db = new DepoDbContext())
            {
                var storageItems = db.StorageItems.Include(s => s.product).Include(s => s.storage).Include(s => s.product.category).ToList();
                if (searchTerm != "")
                {
                    storageItems = storageItems.Where(s => s.product.name.ToLower().Contains(searchTerm)).ToList();
                }
                if ((int)cmbBxStorages.SelectedValue != -1)
                {
                    storageItems = storageItems.Where(s => s.storage.id == (int)cmbBxStorages.SelectedValue).ToList();
                }
                if ((int)cmbBxCategories.SelectedValue != -1)
                {
                    storageItems = storageItems.Where(s => s.product.category.id == (int)cmbBxCategories.SelectedValue).ToList();
                }


                dataGridViewStorage.Rows.Clear();

                foreach (var storageitem in storageItems)
                {
                    dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count + " " + getMeasurementType(storageitem.product.measurementType), storageitem.storage.name);
                }
            }
        }
        #endregion

        #region SALE
        private void button8_Click(object sender, EventArgs e)
        {
            AddSale addSale = new AddSale();
            addSale.ShowDialog();

            updateSalesDataGridView();
            updateStorageItemDataGridView();
        }
        #endregion

        #region UTILITY METHODS
        public StorageItem getSelectedStorageItem()
        {
            int selectedStorageItemID = Convert.ToInt32(dataGridViewStorage.SelectedRows[0].Cells[0].Value);
            StorageItem selectedStorageItem = db.StorageItems.Find(selectedStorageItemID);
            db.Entry(selectedStorageItem).Reference(s => s.product).Load();

            return selectedStorageItem;
        }

        public void updateProductsDataGridView()
        {
            dataGridViewProducts.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var products = db.Products.Include(p => p.category).OrderBy(p => p.id)
                    .ToList();

                foreach (var product in products)
                {
                    dataGridViewProducts.Rows.Add(product.id, product.name, product.category.name, getMeasurementType(product.measurementType));
                }
            }
        }

        public void updateStoragesDataGridView()
        {
            dataGridViewStorages.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var storages = db.Storages.OrderBy(s => s.id)
                    .ToList();

                foreach (var storage in storages)
                {
                    dataGridViewStorages.Rows.Add(storage.id, storage.name);
                }

            }
            updateStoragesComboBox();
        }

        public void updateStorageItemDataGridView()
        {
            dataGridViewStorage.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var storageItems = db.StorageItems.Include(s => s.product).Include(s => s.storage).ToList();

                foreach (var storageitem in storageItems)
                {
                    dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count + " " + getMeasurementType(storageitem.product.measurementType), storageitem.storage.name);
                }
            }
        }

        public void updateCategoriesDataGridView()
        {
            dataGridViewCategories.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var categories = db.Categories.OrderBy(c => c.id);

                foreach (var category in categories)
                {
                    dataGridViewCategories.Rows.Add(category.id, category.name);
                }
            }

            updateCategoriesComboBox();
        }

        public void updateSalesDataGridView()
        {
            // TODO: Sort by date
            // TODO: Add filter
            dataGridViewSales.Rows.Clear();

            using (DepoDbContext db = new DepoDbContext())
            {
                var sales = db.Sales.Include(s => s.storageItem).Include(s => s.storageItem.product).Include(s => s.storageItem.storage).ToList();

                foreach (var sale in sales)
                {
                    dataGridViewSales.Rows.Add(sale.id, sale.storageItem.product.name, sale.storageItem.storage.name, sale.count + " " + getMeasurementType(sale.storageItem.product.measurementType), sale.price);
                }
            }
        }

        public string getMeasurementType(int measurementType)
        {
            if (measurementType == 0)
            {
                return "Adet";
            }
            else if (measurementType == 1)
            {
                return "Kg";
            }
            else if (measurementType == 2)
            {
                return "Lt";
            }
            else
            {
                return "N/A";
            }
        }

        public void updateStoragesComboBox()
        {
            List<Storage> storages = new List<Storage>();
            storages.Add(new Storage()
            {
                id = -1,
                name = "Tüm Depolar"
            });
            using (DepoDbContext db = new DepoDbContext())
            {
                storages.AddRange(db.Storages.OrderBy(s => s.id).ToList());

                cmbBxStorages.DataSource = storages;
                cmbBxStorages.DisplayMember = "name";
                cmbBxStorages.ValueMember = "id";
            }
        }

        public void updateCategoriesComboBox()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                id = -1,
                name = "Tüm Kategoriler"
            });
            using (DepoDbContext db = new DepoDbContext())
            {
                categories.AddRange(db.Categories.OrderBy(c => c.id).ToList());

                cmbBxCategories.DataSource = categories;
                cmbBxCategories.DisplayMember = "name";
                cmbBxCategories.ValueMember = "id";
            }
        }
        #endregion


        
    }
}

using AForge.Video.DirectShow;
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
        CategoryManager _categoryManager = new CategoryManager();

        int selectedStorageID = 0;
        int selectedCategoryID = 0;

        public TextBox scannerTextBox;

        public Home()
        {
            InitializeComponent();
        }

        public FilterInfoCollection filterInfoCollection;
        public VideoCaptureDevice videoCaptureDevice;



        private void Home_Load(object sender, EventArgs e)
        {
            updateProductsDataGridView();

            updateStorageItemDataGridView();

            updateStoragesDataGridView();

            updateCategoriesDataGridView();

            updateSalesDataGridView();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_BarcodeFrame;
        }

        #region PRODUCT

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);

            DialogResult dialogResult = addProduct.ShowDialog();

            // When form is closed
            // But it's not necessary to update the products table
            // Because it's already updated when the form is closed
            // updateProductsDataGridView();
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

                    // it's not necessary to update the products table
                    // updateProductsDataGridView();
                    dataGridViewProducts.Rows.RemoveAt(dataGridViewProducts.SelectedRows[0].Index);
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

        // Products tab search button
        private void button7_Click(object sender, EventArgs e)
        {
            // Attention! : Search term is lowercased
            string searchTerm = txtBxProductsTab.Text.Trim().ToLower();

            using (DepoDbContext db = new DepoDbContext())
            {
                var products = db.Products
                    .Include(p => p.category)
                    .ToList();
                if (searchTerm != "")
                {
                    products = products.Where(p => p.name.ToLower().Contains(searchTerm)).ToList();
                }
                if ((int)cmbBxProductsTabCategories.SelectedValue != -1)
                {
                    products = products.Where(p => p.category.id == (int)cmbBxProductsTabCategories.SelectedValue).ToList();
                }
                if (txtBxBarcodeProducts.Text != "")
                {
                    products = products.Where(p => p.barcode == txtBxBarcodeProducts.Text).ToList();
                }

                dataGridViewProducts.Rows.Clear();

                foreach (var product in products)
                {
                    dataGridViewProducts.Rows.Add(product.id, product.name, product.category.name, product.getMeasurementType());
                }
            }

        }

        // Barcode search textbox
        private void txtBxBarcodeProducts_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            scannerTextBox = ((TextBox)sender);
            videoCaptureDevice.Start();
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

                    // it's not necessary to update the storages table
                    // updateStoragesDataGridView();
                    dataGridViewStorages.Rows.Add(storage.id, storage.name);
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

                        // It's not necessary to update the storages table
                        // updateStoragesDataGridView();
                        dataGridViewStorages.SelectedRows[0].Cells[1].Value = storage.name;
                        updateStorageItemDataGridView();
                        updateStoragesComboBox();
                        updateSalesDataGridView();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Check if the storage id is valid
            if (selectedStorageID != 0)
            {
                // Check storage is used in storage items
                if (_storageItemManager.GetAll().Where(s => s.storage.id == selectedStorageID).FirstOrDefault() != null)
                {
                    MessageBox.Show("Bu depo stoklarda kullanýlýyor. Önce stoklardan silmelisiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Storage existingStorage = _storageManager.GetAll().Where(s => s.id == selectedStorageID).FirstOrDefault();
                    if (_storageManager.Remove(existingStorage))
                    {
                        MessageBox.Show("Depo baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Delete from datagridview
                        dataGridViewStorages.Rows.RemoveAt(dataGridViewStorages.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("Depo silinirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir depo seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // it's not necessary to update the categories table
                    // updateCategoriesDataGridView();
                    dataGridViewCategories.Rows.Add(category.id, category.name);
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

                    if (_categoryManager.Update(category))
                    {
                        MessageBox.Show("Kategori baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // It's not necessary to update the categories table
                        // updateCategoriesDataGridView();
                        dataGridViewCategories.SelectedRows[0].Cells[1].Value = category.name;
                        // Products Tab
                        updateCategoriesComboBoxProductsTab();
                        updateProductsDataGridView();

                        // StorageItem Tab
                        updateCategoriesComboBox();
                        updateStorageItemDataGridView();

                        // Sales Tab
                        // TODO: Sales tab's search filter
                        updateSalesDataGridView();
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

        // Delete category button
        private void button9_Click(object sender, EventArgs e)
        {

            if (dataGridViewCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Products.Include(p => p.category).Where(p => p.category.id == selectedCategoryID).FirstOrDefault() != null)
            {
                MessageBox.Show("Bu kategoriye ait ürünler var. Önce ürünleri silmelisiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedCategoryID != 0)
            {
                try
                {
                    if (_categoryManager.RemoveById(selectedCategoryID))
                    {
                        MessageBox.Show("Kategori baþarýyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Delete from datagridview
                        dataGridViewCategories.Rows.RemoveAt(dataGridViewCategories.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("Kategori silinirken bir hata oluþtu.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string barcode = (txtBxBarcodeStorageItem.Text.Trim());
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
                if (barcode != "")
                {
                    storageItems = storageItems.Where(s => s.product.barcode == barcode).ToList();
                }


                dataGridViewStorage.Rows.Clear();

                foreach (var storageitem in storageItems)
                {
                    dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count + " " + storageitem.product.getMeasurementType(), storageitem.storage.name);
                }
            }
        }

        private void txtBxBarcodeStorageItem_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
            scannerTextBox = ((TextBox)sender);
            videoCaptureDevice.Start();
        }
        #endregion

        #region SALE
        private void button8_Click(object sender, EventArgs e)
        {
            AddSale addSale = new AddSale(this);
            addSale.ShowDialog();

            updateSalesDataGridView();
            updateStorageItemDataGridView();
        }
        #endregion

        #region MENU STRIP AREA

        #region PRODUCT STOCK AREA

        private void ürünStokRaporlarýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryReport inventoryReport = new InventoryReport();
            inventoryReport.ShowDialog();
        }

        #endregion
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
                    dataGridViewProducts.Rows.Add(product.id, product.name, product.category.name, product.getMeasurementType());
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
                    dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count + " " + storageitem.product.getMeasurementType(), storageitem.storage.name);
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
            updateCategoriesComboBoxProductsTab();
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
                    dataGridViewSales.Rows.Add(sale.id, sale.storageItem.product.name, sale.storageItem.storage.name, sale.count + " " + sale.storageItem.product.getMeasurementType(), sale.price);
                }
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

        public void updateCategoriesComboBoxProductsTab()
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

                cmbBxProductsTabCategories.DataSource = categories;
                cmbBxProductsTabCategories.DisplayMember = "name";
                cmbBxProductsTabCategories.ValueMember = "id";
            }
        }

        public void VideoCaptureDevice_BarcodeFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            var reader = new ZXing.Windows.Compatibility.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>() { ZXing.BarcodeFormat.UPC_A, ZXing.BarcodeFormat.EAN_13 };

            var result = reader.Decode(bitmap);
            if (result != null)
            {
                scannerTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    scannerTextBox.Text = result.ToString();
                    videoCaptureDevice.SignalToStop();
                }));
            }
        }
        #endregion









    
    }
}

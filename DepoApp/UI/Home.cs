using DepoApp.DAL.Context;
using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using DepoApp.UI;
using Microsoft.EntityFrameworkCore;

namespace DepoApp
{
    public partial class Home : Form
    {
        DepoDbContext db = new DepoDbContext();
        ProductManager _productManager = new ProductManager();
        StorageManager _storageManager = new StorageManager();
        StorageItemManager _storageItemManager = new StorageItemManager();

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

            // Form kapand���nda �al��acak kodlar
            updateProductsDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedProductID = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
            Product selectedProduct = _productManager.GetAll().Where(p => p.id == selectedProductID).FirstOrDefault();

            StorageItem storageItem = _storageItemManager.GetAll().Where(item => item.product == selectedProduct).FirstOrDefault();

            if (storageItem != null)
            {
                MessageBox.Show("Bu �r�n� silebilmek i�in �nce stoktan silmelisiniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_productManager.Remove(selectedProduct))
                {
                    MessageBox.Show("�r�n ba�ar�yla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateProductsDataGridView();
                }
                else
                {
                    MessageBox.Show("�r�n silinirken bir hata olu�tu.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("L�tfen depo ad�n� giriniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the storage name is already exists
            if (_storageManager.GetAll().Where(s => s.name == txtBxStorageName.Text).FirstOrDefault() != null)
            {
                MessageBox.Show("Bu depo ad� zaten mevcut.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Depo ba�ar�yla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    updateStoragesDataGridView();
                }
                else
                {
                    MessageBox.Show("Depo eklenirken bir hata olu�tu.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewStorages_SelectionChanged(object sender, EventArgs e)
        {

        }
        #endregion

        // Storage-Item Area
        private void btnAddNewProductToStorage_Click(object sender, EventArgs e)
        {
            AddProductToStorage addProductToStorage = new AddProductToStorage(this);

            addProductToStorage.ShowDialog();

            // Form kapand���nda �al��acak kodlar
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
                        MessageBox.Show("Stoktan ba�ar�yla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        updateStorageItemDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Stok silinirken bir hata olu�tu.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


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

        public void updateStorageItemDataGridView()
        {
            dataGridViewStorage.Rows.Clear();

            // degismeli manager ile.
            var storageItems = db.StorageItems;

            foreach (var storageitem in storageItems)
            {
                dataGridViewStorage.Rows.Add(storageitem.id, storageitem.product.name, storageitem.count);
            }
        }

        public void updateStoragesDataGridView()
        {
            dataGridViewStorages.Rows.Clear();

            // degismeli manager ile.
            var storages = db.Storages;

            foreach (var storage in storages)
            {
                dataGridViewStorages.Rows.Add(storage.id, storage.name);
            }
        }
        #endregion


        
    }
}

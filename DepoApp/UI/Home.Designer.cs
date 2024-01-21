namespace DepoApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage5 = new TabPage();
            button8 = new Button();
            dataGridViewSales = new DataGridView();
            saleId = new DataGridViewTextBoxColumn();
            saleProduct = new DataGridViewTextBoxColumn();
            saleStorage = new DataGridViewTextBoxColumn();
            saleCount = new DataGridViewTextBoxColumn();
            salePrice = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            cmbBxCategories = new ComboBox();
            button6 = new Button();
            cmbBxStorages = new ComboBox();
            txtBxSearchProductName = new TextBox();
            label7 = new Label();
            button3 = new Button();
            button2 = new Button();
            btnAddNewProductToStorage = new Button();
            dataGridViewStorage = new DataGridView();
            idStorage = new DataGridViewTextBoxColumn();
            productNameStorage = new DataGridViewTextBoxColumn();
            countProductStorage = new DataGridViewTextBoxColumn();
            storageItemStorageName = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button7 = new Button();
            cmbBxProductsTabCategories = new ComboBox();
            txtBxProductsTab = new TextBox();
            label10 = new Label();
            button1 = new Button();
            dataGridViewProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productMeasurement = new DataGridViewTextBoxColumn();
            btnAddNewProduct = new Button();
            tabPage3 = new TabPage();
            label9 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btnUpdateStorage = new Button();
            txtBxStorageUpdate = new TextBox();
            btnAddNewStorage = new Button();
            txtBxStorageName = new TextBox();
            dataGridViewStorages = new DataGridView();
            storageId = new DataGridViewTextBoxColumn();
            storageName = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            label8 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            button9 = new Button();
            button5 = new Button();
            txtBxCategoryUpdate = new TextBox();
            label5 = new Label();
            button4 = new Button();
            label4 = new Label();
            txtBxCategoryNew = new TextBox();
            dataGridViewCategories = new DataGridView();
            categoryId = new DataGridViewTextBoxColumn();
            categoryName = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            ürünStokRaporlarıToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorage).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorages).BeginInit();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.ItemSize = new Size(68, 20);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 448);
            tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button8);
            tabPage5.Controls.Add(dataGridViewSales);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(789, 420);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Satışlar";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(477, 375);
            button8.Name = "button8";
            button8.Size = new Size(121, 40);
            button8.TabIndex = 2;
            button8.Text = "Yeni Satış Gir";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToOrderColumns = true;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { saleId, saleProduct, saleStorage, saleCount, salePrice });
            dataGridViewSales.Location = new Point(0, 36);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSales.Size = new Size(789, 333);
            dataGridViewSales.TabIndex = 0;
            // 
            // saleId
            // 
            saleId.HeaderText = "id";
            saleId.Name = "saleId";
            saleId.ReadOnly = true;
            // 
            // saleProduct
            // 
            saleProduct.HeaderText = "Ürün Adı";
            saleProduct.Name = "saleProduct";
            saleProduct.ReadOnly = true;
            // 
            // saleStorage
            // 
            saleStorage.HeaderText = "Depo";
            saleStorage.Name = "saleStorage";
            saleStorage.ReadOnly = true;
            // 
            // saleCount
            // 
            saleCount.HeaderText = "Adet/Kg/Lt";
            saleCount.Name = "saleCount";
            saleCount.ReadOnly = true;
            // 
            // salePrice
            // 
            salePrice.HeaderText = "Toplam Fiyat";
            salePrice.Name = "salePrice";
            salePrice.ReadOnly = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbBxCategories);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(cmbBxStorages);
            tabPage1.Controls.Add(txtBxSearchProductName);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnAddNewProductToStorage);
            tabPage1.Controls.Add(dataGridViewStorage);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Depo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBxCategories
            // 
            cmbBxCategories.FormattingEnabled = true;
            cmbBxCategories.Items.AddRange(new object[] { "Tüm Depolar" });
            cmbBxCategories.Location = new Point(421, 9);
            cmbBxCategories.Name = "cmbBxCategories";
            cmbBxCategories.Size = new Size(140, 23);
            cmbBxCategories.TabIndex = 8;
            // 
            // button6
            // 
            button6.Location = new Point(591, 9);
            button6.Name = "button6";
            button6.Size = new Size(89, 23);
            button6.TabIndex = 7;
            button6.Text = "Arama Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // cmbBxStorages
            // 
            cmbBxStorages.FormattingEnabled = true;
            cmbBxStorages.Items.AddRange(new object[] { "Tüm Depolar" });
            cmbBxStorages.Location = new Point(263, 9);
            cmbBxStorages.Name = "cmbBxStorages";
            cmbBxStorages.Size = new Size(140, 23);
            cmbBxStorages.TabIndex = 6;
            // 
            // txtBxSearchProductName
            // 
            txtBxSearchProductName.Location = new Point(73, 9);
            txtBxSearchProductName.Name = "txtBxSearchProductName";
            txtBxSearchProductName.PlaceholderText = "Ürün Adı";
            txtBxSearchProductName.Size = new Size(170, 23);
            txtBxSearchProductName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 12);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 4;
            label7.Text = "Arama Yap:";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(591, 375);
            button3.Name = "button3";
            button3.Size = new Size(121, 40);
            button3.TabIndex = 3;
            button3.Text = "Ürünü Depodan Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(464, 375);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 2;
            button2.Text = "Stok Sayısını Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddNewProductToStorage
            // 
            btnAddNewProductToStorage.Location = new Point(337, 375);
            btnAddNewProductToStorage.Name = "btnAddNewProductToStorage";
            btnAddNewProductToStorage.Size = new Size(121, 40);
            btnAddNewProductToStorage.TabIndex = 1;
            btnAddNewProductToStorage.Text = "Depoya Yeni Ürün Ekle";
            btnAddNewProductToStorage.UseVisualStyleBackColor = true;
            btnAddNewProductToStorage.Click += btnAddNewProductToStorage_Click;
            // 
            // dataGridViewStorage
            // 
            dataGridViewStorage.AllowUserToAddRows = false;
            dataGridViewStorage.AllowUserToDeleteRows = false;
            dataGridViewStorage.AllowUserToOrderColumns = true;
            dataGridViewStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStorage.Columns.AddRange(new DataGridViewColumn[] { idStorage, productNameStorage, countProductStorage, storageItemStorageName });
            dataGridViewStorage.Location = new Point(0, 36);
            dataGridViewStorage.Name = "dataGridViewStorage";
            dataGridViewStorage.ReadOnly = true;
            dataGridViewStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorage.Size = new Size(789, 333);
            dataGridViewStorage.TabIndex = 0;
            // 
            // idStorage
            // 
            idStorage.HeaderText = "id";
            idStorage.Name = "idStorage";
            idStorage.ReadOnly = true;
            // 
            // productNameStorage
            // 
            productNameStorage.HeaderText = "Ürün Adı";
            productNameStorage.Name = "productNameStorage";
            productNameStorage.ReadOnly = true;
            // 
            // countProductStorage
            // 
            countProductStorage.HeaderText = "Ürün Stoğu";
            countProductStorage.Name = "countProductStorage";
            countProductStorage.ReadOnly = true;
            // 
            // storageItemStorageName
            // 
            storageItemStorageName.HeaderText = "Depo";
            storageItemStorageName.Name = "storageItemStorageName";
            storageItemStorageName.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(cmbBxProductsTabCategories);
            tabPage2.Controls.Add(txtBxProductsTab);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridViewProducts);
            tabPage2.Controls.Add(btnAddNewProduct);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ürünler";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(426, 7);
            button7.Name = "button7";
            button7.Size = new Size(89, 23);
            button7.TabIndex = 11;
            button7.Text = "Arama Yap";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // cmbBxProductsTabCategories
            // 
            cmbBxProductsTabCategories.FormattingEnabled = true;
            cmbBxProductsTabCategories.Items.AddRange(new object[] { "Tüm Depolar" });
            cmbBxProductsTabCategories.Location = new Point(261, 7);
            cmbBxProductsTabCategories.Name = "cmbBxProductsTabCategories";
            cmbBxProductsTabCategories.Size = new Size(140, 23);
            cmbBxProductsTabCategories.TabIndex = 10;
            // 
            // txtBxProductsTab
            // 
            txtBxProductsTab.Location = new Point(71, 7);
            txtBxProductsTab.Name = "txtBxProductsTab";
            txtBxProductsTab.PlaceholderText = "Ürün Adı";
            txtBxProductsTab.Size = new Size(170, 23);
            txtBxProductsTab.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(-2, 10);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 8;
            label10.Text = "Arama Yap:";
            // 
            // button1
            // 
            button1.Location = new Point(484, 375);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 4;
            button1.Text = "Seçili Ürünü Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = true;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { id, name, productCategory, productMeasurement });
            dataGridViewProducts.Location = new Point(0, 36);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(789, 333);
            dataGridViewProducts.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Ürün Adı";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // productCategory
            // 
            productCategory.HeaderText = "Kategori";
            productCategory.Name = "productCategory";
            productCategory.ReadOnly = true;
            // 
            // productMeasurement
            // 
            productMeasurement.HeaderText = "Ölçü Şekli";
            productMeasurement.Name = "productMeasurement";
            productMeasurement.ReadOnly = true;
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(370, 375);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(108, 39);
            btnAddNewProduct.TabIndex = 2;
            btnAddNewProduct.Text = "Yeni Ürün Ekle";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(btnAddNewStorage);
            tabPage3.Controls.Add(txtBxStorageName);
            tabPage3.Controls.Add(dataGridViewStorages);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Depolar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 272);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 8;
            label9.Text = "Güncelle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 13);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Depo Adı:";
            // 
            // label1
            // 
            label1.Location = new Point(364, 399);
            label1.Name = "label1";
            label1.Size = new Size(408, 20);
            label1.TabIndex = 4;
            label1.Text = "Lütfen bir işlem yapmak için listeden seçim yapınız.";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUpdateStorage);
            panel1.Controls.Add(txtBxStorageUpdate);
            panel1.Location = new Point(364, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 115);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 34);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Depo Adı:";
            // 
            // btnUpdateStorage
            // 
            btnUpdateStorage.Location = new Point(275, 81);
            btnUpdateStorage.Name = "btnUpdateStorage";
            btnUpdateStorage.Size = new Size(130, 31);
            btnUpdateStorage.TabIndex = 5;
            btnUpdateStorage.Text = "Depoyu Güncelle";
            btnUpdateStorage.UseVisualStyleBackColor = true;
            btnUpdateStorage.Click += btnUpdateStorage_Click;
            // 
            // txtBxStorageUpdate
            // 
            txtBxStorageUpdate.Location = new Point(4, 52);
            txtBxStorageUpdate.Name = "txtBxStorageUpdate";
            txtBxStorageUpdate.Size = new Size(401, 23);
            txtBxStorageUpdate.TabIndex = 0;
            // 
            // btnAddNewStorage
            // 
            btnAddNewStorage.Location = new Point(639, 60);
            btnAddNewStorage.Name = "btnAddNewStorage";
            btnAddNewStorage.Size = new Size(133, 31);
            btnAddNewStorage.TabIndex = 2;
            btnAddNewStorage.Text = "Yeni Depo Ekle";
            btnAddNewStorage.UseVisualStyleBackColor = true;
            btnAddNewStorage.Click += button4_Click;
            // 
            // txtBxStorageName
            // 
            txtBxStorageName.Location = new Point(364, 31);
            txtBxStorageName.Name = "txtBxStorageName";
            txtBxStorageName.Size = new Size(408, 23);
            txtBxStorageName.TabIndex = 1;
            // 
            // dataGridViewStorages
            // 
            dataGridViewStorages.AllowUserToAddRows = false;
            dataGridViewStorages.AllowUserToDeleteRows = false;
            dataGridViewStorages.AllowUserToOrderColumns = true;
            dataGridViewStorages.AllowUserToResizeColumns = false;
            dataGridViewStorages.AllowUserToResizeRows = false;
            dataGridViewStorages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStorages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStorages.Columns.AddRange(new DataGridViewColumn[] { storageId, storageName });
            dataGridViewStorages.Location = new Point(0, 0);
            dataGridViewStorages.Name = "dataGridViewStorages";
            dataGridViewStorages.ReadOnly = true;
            dataGridViewStorages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorages.Size = new Size(340, 424);
            dataGridViewStorages.TabIndex = 0;
            dataGridViewStorages.SelectionChanged += dataGridViewStorages_SelectionChanged;
            // 
            // storageId
            // 
            storageId.HeaderText = "id";
            storageId.Name = "storageId";
            storageId.ReadOnly = true;
            // 
            // storageName
            // 
            storageName.HeaderText = "name";
            storageName.Name = "storageName";
            storageName.ReadOnly = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(panel2);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(txtBxCategoryNew);
            tabPage4.Controls.Add(dataGridViewCategories);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(789, 420);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kategoriler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 282);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 6;
            label8.Text = "Güncelle";
            // 
            // label6
            // 
            label6.Location = new Point(354, 400);
            label6.Name = "label6";
            label6.Size = new Size(408, 20);
            label6.TabIndex = 5;
            label6.Text = "Lütfen bir işlem yapmak için listeden seçim yapınız.";
            // 
            // panel2
            // 
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(txtBxCategoryUpdate);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(354, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 119);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // button9
            // 
            button9.Location = new Point(0, 90);
            button9.Name = "button9";
            button9.Size = new Size(94, 23);
            button9.TabIndex = 8;
            button9.Text = "Kategoriyi Sil";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button5
            // 
            button5.Location = new Point(294, 90);
            button5.Name = "button5";
            button5.Size = new Size(126, 23);
            button5.TabIndex = 7;
            button5.Text = "Kategoriyi Güncelle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtBxCategoryUpdate
            // 
            txtBxCategoryUpdate.Location = new Point(0, 61);
            txtBxCategoryUpdate.Name = "txtBxCategoryUpdate";
            txtBxCategoryUpdate.Size = new Size(420, 23);
            txtBxCategoryUpdate.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 43);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 6;
            label5.Text = "Kategori Adı:";
            // 
            // button4
            // 
            button4.Location = new Point(648, 63);
            button4.Name = "button4";
            button4.Size = new Size(126, 23);
            button4.TabIndex = 3;
            button4.Text = "Kategoriyi Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 16);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 2;
            label4.Text = "Kategori Adı:";
            // 
            // txtBxCategoryNew
            // 
            txtBxCategoryNew.Location = new Point(354, 34);
            txtBxCategoryNew.Name = "txtBxCategoryNew";
            txtBxCategoryNew.Size = new Size(420, 23);
            txtBxCategoryNew.TabIndex = 1;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.AllowUserToOrderColumns = true;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryId, categoryName });
            dataGridViewCategories.Location = new Point(0, 0);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(340, 420);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // categoryId
            // 
            categoryId.HeaderText = "id";
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            // 
            // categoryName
            // 
            categoryName.HeaderText = "Kategori Adı";
            categoryName.Name = "categoryName";
            categoryName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünStokRaporlarıToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(63, 20);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // ürünStokRaporlarıToolStripMenuItem
            // 
            ürünStokRaporlarıToolStripMenuItem.Name = "ürünStokRaporlarıToolStripMenuItem";
            ürünStokRaporlarıToolStripMenuItem.Size = new Size(167, 22);
            ürünStokRaporlarıToolStripMenuItem.Text = "Ürün Stok Raporu";
            ürünStokRaporlarıToolStripMenuItem.Click += ürünStokRaporlarıToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depo";
            Load += Home_Load;
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorage).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorages).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddNewProduct;
        private DataGridView dataGridViewStorage;
        private Button btnAddNewProductToStorage;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabPage tabPage3;
        private DataGridView dataGridViewStorages;
        private DataGridViewTextBoxColumn storageId;
        private DataGridViewTextBoxColumn storageName;
        private Button btnAddNewStorage;
        private TextBox txtBxStorageName;
        private Label label1;
        private Panel panel1;
        private TextBox txtBxStorageUpdate;
        private Label label2;
        private Button btnUpdateStorage;
        private Label label3;
        private TabPage tabPage4;
        private DataGridView dataGridViewCategories;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private Label label6;
        private Panel panel2;
        private Button button5;
        private TextBox txtBxCategoryUpdate;
        private Label label5;
        private Button button4;
        private Label label4;
        private TextBox txtBxCategoryNew;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productMeasurement;
        private DataGridViewTextBoxColumn idStorage;
        private DataGridViewTextBoxColumn productNameStorage;
        private DataGridViewTextBoxColumn countProductStorage;
        private DataGridViewTextBoxColumn storageItemStorageName;
        private TextBox txtBxSearchProductName;
        private Label label7;
        private Button button6;
        private ComboBox cmbBxStorages;
        private ComboBox cmbBxCategories;
        private Label label9;
        private Label label8;
        private TabPage tabPage5;
        private DataGridView dataGridViewSales;
        private DataGridViewTextBoxColumn saleId;
        private DataGridViewTextBoxColumn saleProduct;
        private DataGridViewTextBoxColumn saleStorage;
        private DataGridViewTextBoxColumn saleCount;
        private DataGridViewTextBoxColumn salePrice;
        private Button button8;
        private Button button7;
        private ComboBox cmbBxProductsTabCategories;
        private TextBox txtBxProductsTab;
        private Label label10;
        private TabControl tabControl1;
        public DataGridView dataGridViewProducts;
        private Button button9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem ürünStokRaporlarıToolStripMenuItem;
    }
}

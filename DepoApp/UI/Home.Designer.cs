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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tabControl1 = new TabControl();
            tabPage5 = new TabPage();
            txtBxSalesTabBarcode = new TextBox();
            button11 = new Button();
            cmbBxSalesTabCategories = new ComboBox();
            cmbBxSalesTabStorages = new ComboBox();
            txtBxSalesTabProductName = new TextBox();
            label11 = new Label();
            button8 = new Button();
            dataGridViewSales = new DataGridView();
            saleId = new DataGridViewTextBoxColumn();
            saleProduct = new DataGridViewTextBoxColumn();
            saleStorage = new DataGridViewTextBoxColumn();
            saleCount = new DataGridViewTextBoxColumn();
            salePrice = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            txtBxBarcodeStorageItem = new TextBox();
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
            txtBxBarcodeProducts = new TextBox();
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
            button10 = new Button();
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
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage5
            // 
            resources.ApplyResources(tabPage5, "tabPage5");
            tabPage5.Controls.Add(txtBxSalesTabBarcode);
            tabPage5.Controls.Add(button11);
            tabPage5.Controls.Add(cmbBxSalesTabCategories);
            tabPage5.Controls.Add(cmbBxSalesTabStorages);
            tabPage5.Controls.Add(txtBxSalesTabProductName);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(button8);
            tabPage5.Controls.Add(dataGridViewSales);
            tabPage5.Name = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtBxSalesTabBarcode
            // 
            resources.ApplyResources(txtBxSalesTabBarcode, "txtBxSalesTabBarcode");
            txtBxSalesTabBarcode.Name = "txtBxSalesTabBarcode";
            txtBxSalesTabBarcode.Click += txtBxSalesTabBarcode_Click;
            // 
            // button11
            // 
            resources.ApplyResources(button11, "button11");
            button11.Name = "button11";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // cmbBxSalesTabCategories
            // 
            resources.ApplyResources(cmbBxSalesTabCategories, "cmbBxSalesTabCategories");
            cmbBxSalesTabCategories.FormattingEnabled = true;
            cmbBxSalesTabCategories.Items.AddRange(new object[] { resources.GetString("cmbBxSalesTabCategories.Items") });
            cmbBxSalesTabCategories.Name = "cmbBxSalesTabCategories";
            // 
            // cmbBxSalesTabStorages
            // 
            resources.ApplyResources(cmbBxSalesTabStorages, "cmbBxSalesTabStorages");
            cmbBxSalesTabStorages.FormattingEnabled = true;
            cmbBxSalesTabStorages.Items.AddRange(new object[] { resources.GetString("cmbBxSalesTabStorages.Items") });
            cmbBxSalesTabStorages.Name = "cmbBxSalesTabStorages";
            // 
            // txtBxSalesTabProductName
            // 
            resources.ApplyResources(txtBxSalesTabProductName, "txtBxSalesTabProductName");
            txtBxSalesTabProductName.Name = "txtBxSalesTabProductName";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridViewSales
            // 
            resources.ApplyResources(dataGridViewSales, "dataGridViewSales");
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToOrderColumns = true;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { saleId, saleProduct, saleStorage, saleCount, salePrice });
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // saleId
            // 
            resources.ApplyResources(saleId, "saleId");
            saleId.Name = "saleId";
            saleId.ReadOnly = true;
            // 
            // saleProduct
            // 
            resources.ApplyResources(saleProduct, "saleProduct");
            saleProduct.Name = "saleProduct";
            saleProduct.ReadOnly = true;
            // 
            // saleStorage
            // 
            resources.ApplyResources(saleStorage, "saleStorage");
            saleStorage.Name = "saleStorage";
            saleStorage.ReadOnly = true;
            // 
            // saleCount
            // 
            resources.ApplyResources(saleCount, "saleCount");
            saleCount.Name = "saleCount";
            saleCount.ReadOnly = true;
            // 
            // salePrice
            // 
            resources.ApplyResources(salePrice, "salePrice");
            salePrice.Name = "salePrice";
            salePrice.ReadOnly = true;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Controls.Add(txtBxBarcodeStorageItem);
            tabPage1.Controls.Add(cmbBxCategories);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(cmbBxStorages);
            tabPage1.Controls.Add(txtBxSearchProductName);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnAddNewProductToStorage);
            tabPage1.Controls.Add(dataGridViewStorage);
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBxBarcodeStorageItem
            // 
            resources.ApplyResources(txtBxBarcodeStorageItem, "txtBxBarcodeStorageItem");
            txtBxBarcodeStorageItem.Name = "txtBxBarcodeStorageItem";
            txtBxBarcodeStorageItem.Click += txtBxBarcodeStorageItem_Click;
            // 
            // cmbBxCategories
            // 
            resources.ApplyResources(cmbBxCategories, "cmbBxCategories");
            cmbBxCategories.FormattingEnabled = true;
            cmbBxCategories.Items.AddRange(new object[] { resources.GetString("cmbBxCategories.Items") });
            cmbBxCategories.Name = "cmbBxCategories";
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // cmbBxStorages
            // 
            resources.ApplyResources(cmbBxStorages, "cmbBxStorages");
            cmbBxStorages.FormattingEnabled = true;
            cmbBxStorages.Items.AddRange(new object[] { resources.GetString("cmbBxStorages.Items") });
            cmbBxStorages.Name = "cmbBxStorages";
            // 
            // txtBxSearchProductName
            // 
            resources.ApplyResources(txtBxSearchProductName, "txtBxSearchProductName");
            txtBxSearchProductName.Name = "txtBxSearchProductName";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.Transparent;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddNewProductToStorage
            // 
            resources.ApplyResources(btnAddNewProductToStorage, "btnAddNewProductToStorage");
            btnAddNewProductToStorage.Name = "btnAddNewProductToStorage";
            btnAddNewProductToStorage.UseVisualStyleBackColor = true;
            btnAddNewProductToStorage.Click += btnAddNewProductToStorage_Click;
            // 
            // dataGridViewStorage
            // 
            resources.ApplyResources(dataGridViewStorage, "dataGridViewStorage");
            dataGridViewStorage.AllowUserToAddRows = false;
            dataGridViewStorage.AllowUserToDeleteRows = false;
            dataGridViewStorage.AllowUserToOrderColumns = true;
            dataGridViewStorage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStorage.Columns.AddRange(new DataGridViewColumn[] { idStorage, productNameStorage, countProductStorage, storageItemStorageName });
            dataGridViewStorage.Name = "dataGridViewStorage";
            dataGridViewStorage.ReadOnly = true;
            dataGridViewStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // idStorage
            // 
            resources.ApplyResources(idStorage, "idStorage");
            idStorage.Name = "idStorage";
            idStorage.ReadOnly = true;
            // 
            // productNameStorage
            // 
            resources.ApplyResources(productNameStorage, "productNameStorage");
            productNameStorage.Name = "productNameStorage";
            productNameStorage.ReadOnly = true;
            // 
            // countProductStorage
            // 
            resources.ApplyResources(countProductStorage, "countProductStorage");
            countProductStorage.Name = "countProductStorage";
            countProductStorage.ReadOnly = true;
            // 
            // storageItemStorageName
            // 
            resources.ApplyResources(storageItemStorageName, "storageItemStorageName");
            storageItemStorageName.Name = "storageItemStorageName";
            storageItemStorageName.ReadOnly = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Controls.Add(txtBxBarcodeProducts);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(cmbBxProductsTabCategories);
            tabPage2.Controls.Add(txtBxProductsTab);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridViewProducts);
            tabPage2.Controls.Add(btnAddNewProduct);
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBxBarcodeProducts
            // 
            resources.ApplyResources(txtBxBarcodeProducts, "txtBxBarcodeProducts");
            txtBxBarcodeProducts.Name = "txtBxBarcodeProducts";
            txtBxBarcodeProducts.Click += txtBxBarcodeProducts_Click;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // cmbBxProductsTabCategories
            // 
            resources.ApplyResources(cmbBxProductsTabCategories, "cmbBxProductsTabCategories");
            cmbBxProductsTabCategories.FormattingEnabled = true;
            cmbBxProductsTabCategories.Items.AddRange(new object[] { resources.GetString("cmbBxProductsTabCategories.Items") });
            cmbBxProductsTabCategories.Name = "cmbBxProductsTabCategories";
            // 
            // txtBxProductsTab
            // 
            resources.ApplyResources(txtBxProductsTab, "txtBxProductsTab");
            txtBxProductsTab.Name = "txtBxProductsTab";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewProducts
            // 
            resources.ApplyResources(dataGridViewProducts, "dataGridViewProducts");
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AllowUserToOrderColumns = true;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { id, name, productCategory, productMeasurement });
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // id
            // 
            resources.ApplyResources(id, "id");
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(name, "name");
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // productCategory
            // 
            resources.ApplyResources(productCategory, "productCategory");
            productCategory.Name = "productCategory";
            productCategory.ReadOnly = true;
            // 
            // productMeasurement
            // 
            resources.ApplyResources(productMeasurement, "productMeasurement");
            productMeasurement.Name = "productMeasurement";
            productMeasurement.ReadOnly = true;
            // 
            // btnAddNewProduct
            // 
            resources.ApplyResources(btnAddNewProduct, "btnAddNewProduct");
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // tabPage3
            // 
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(btnAddNewStorage);
            tabPage3.Controls.Add(txtBxStorageName);
            tabPage3.Controls.Add(dataGridViewStorages);
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(button10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUpdateStorage);
            panel1.Controls.Add(txtBxStorageUpdate);
            panel1.Name = "panel1";
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnUpdateStorage
            // 
            resources.ApplyResources(btnUpdateStorage, "btnUpdateStorage");
            btnUpdateStorage.Name = "btnUpdateStorage";
            btnUpdateStorage.UseVisualStyleBackColor = true;
            btnUpdateStorage.Click += btnUpdateStorage_Click;
            // 
            // txtBxStorageUpdate
            // 
            resources.ApplyResources(txtBxStorageUpdate, "txtBxStorageUpdate");
            txtBxStorageUpdate.Name = "txtBxStorageUpdate";
            // 
            // btnAddNewStorage
            // 
            resources.ApplyResources(btnAddNewStorage, "btnAddNewStorage");
            btnAddNewStorage.Name = "btnAddNewStorage";
            btnAddNewStorage.UseVisualStyleBackColor = true;
            btnAddNewStorage.Click += button4_Click;
            // 
            // txtBxStorageName
            // 
            resources.ApplyResources(txtBxStorageName, "txtBxStorageName");
            txtBxStorageName.Name = "txtBxStorageName";
            // 
            // dataGridViewStorages
            // 
            resources.ApplyResources(dataGridViewStorages, "dataGridViewStorages");
            dataGridViewStorages.AllowUserToAddRows = false;
            dataGridViewStorages.AllowUserToDeleteRows = false;
            dataGridViewStorages.AllowUserToOrderColumns = true;
            dataGridViewStorages.AllowUserToResizeColumns = false;
            dataGridViewStorages.AllowUserToResizeRows = false;
            dataGridViewStorages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStorages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStorages.Columns.AddRange(new DataGridViewColumn[] { storageId, storageName });
            dataGridViewStorages.Name = "dataGridViewStorages";
            dataGridViewStorages.ReadOnly = true;
            dataGridViewStorages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorages.SelectionChanged += dataGridViewStorages_SelectionChanged;
            // 
            // storageId
            // 
            resources.ApplyResources(storageId, "storageId");
            storageId.Name = "storageId";
            storageId.ReadOnly = true;
            // 
            // storageName
            // 
            resources.ApplyResources(storageName, "storageName");
            storageName.Name = "storageName";
            storageName.ReadOnly = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(panel2);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(txtBxCategoryNew);
            tabPage4.Controls.Add(dataGridViewCategories);
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(txtBxCategoryUpdate);
            panel2.Controls.Add(label5);
            panel2.Name = "panel2";
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtBxCategoryUpdate
            // 
            resources.ApplyResources(txtBxCategoryUpdate, "txtBxCategoryUpdate");
            txtBxCategoryUpdate.Name = "txtBxCategoryUpdate";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtBxCategoryNew
            // 
            resources.ApplyResources(txtBxCategoryNew, "txtBxCategoryNew");
            txtBxCategoryNew.Name = "txtBxCategoryNew";
            // 
            // dataGridViewCategories
            // 
            resources.ApplyResources(dataGridViewCategories, "dataGridViewCategories");
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.AllowUserToOrderColumns = true;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryId, categoryName });
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // categoryId
            // 
            resources.ApplyResources(categoryId, "categoryId");
            categoryId.Name = "categoryId";
            categoryId.ReadOnly = true;
            // 
            // categoryName
            // 
            resources.ApplyResources(categoryName, "categoryName");
            categoryName.Name = "categoryName";
            categoryName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { raporlarToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // raporlarToolStripMenuItem
            // 
            resources.ApplyResources(raporlarToolStripMenuItem, "raporlarToolStripMenuItem");
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünStokRaporlarıToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            // 
            // ürünStokRaporlarıToolStripMenuItem
            // 
            resources.ApplyResources(ürünStokRaporlarıToolStripMenuItem, "ürünStokRaporlarıToolStripMenuItem");
            ürünStokRaporlarıToolStripMenuItem.Name = "ürünStokRaporlarıToolStripMenuItem";
            ürünStokRaporlarıToolStripMenuItem.Click += ürünStokRaporlarıToolStripMenuItem_Click;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            Load += Home_Load;
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
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
        private Label label6;
        private Panel panel2;
        private Button button5;
        private TextBox txtBxCategoryUpdate;
        private Label label5;
        private Button button4;
        private Label label4;
        private TextBox txtBxCategoryNew;
        private TextBox txtBxSearchProductName;
        private Label label7;
        private Button button6;
        private ComboBox cmbBxStorages;
        private ComboBox cmbBxCategories;
        private Label label9;
        private Label label8;
        private TabPage tabPage5;
        private DataGridView dataGridViewSales;
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
        private Button button10;
        private TextBox txtBxBarcodeProducts;
        private TextBox txtBxBarcodeStorageItem;
        private DataGridViewTextBoxColumn saleId;
        private DataGridViewTextBoxColumn saleProduct;
        private DataGridViewTextBoxColumn saleStorage;
        private DataGridViewTextBoxColumn saleCount;
        private DataGridViewTextBoxColumn salePrice;
        private DataGridViewTextBoxColumn categoryId;
        private DataGridViewTextBoxColumn categoryName;
        private DataGridViewTextBoxColumn storageId;
        private DataGridViewTextBoxColumn storageName;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productMeasurement;
        private DataGridViewTextBoxColumn idStorage;
        private DataGridViewTextBoxColumn productNameStorage;
        private DataGridViewTextBoxColumn countProductStorage;
        private DataGridViewTextBoxColumn storageItemStorageName;
        private Label label11;
        private TextBox txtBxSalesTabProductName;
        private Button button11;
        private ComboBox cmbBxSalesTabCategories;
        private ComboBox cmbBxSalesTabStorages;
        private TextBox txtBxSalesTabBarcode;
    }
}

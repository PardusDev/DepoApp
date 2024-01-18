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
            components = new System.ComponentModel.Container();
            productBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            btnAddNewProductToStorage = new Button();
            dataGridViewStorage = new DataGridView();
            idStorage = new DataGridViewTextBoxColumn();
            productNameStorage = new DataGridViewTextBoxColumn();
            countProductStorage = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            button1 = new Button();
            dataGridViewProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            btnAddNewProduct = new Button();
            tabPage3 = new TabPage();
            btnAddNewStorage = new Button();
            txtBxStorageName = new TextBox();
            dataGridViewStorages = new DataGridView();
            storageId = new DataGridViewTextBoxColumn();
            storageName = new DataGridViewTextBoxColumn();
            productBindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            label1 = new Label();
            txtBxStorageUpdate = new TextBox();
            btnUpdateStorage = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorage).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DAL.Models.Product);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 448);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            dataGridViewStorage.Columns.AddRange(new DataGridViewColumn[] { idStorage, productNameStorage, countProductStorage });
            dataGridViewStorage.Location = new Point(0, 6);
            dataGridViewStorage.Name = "dataGridViewStorage";
            dataGridViewStorage.ReadOnly = true;
            dataGridViewStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStorage.Size = new Size(789, 363);
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
            countProductStorage.HeaderText = "Ürün Sayısı";
            countProductStorage.Name = "countProductStorage";
            countProductStorage.ReadOnly = true;
            // 
            // tabPage2
            // 
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
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { id, name });
            dataGridViewProducts.Location = new Point(0, 6);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(789, 363);
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
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
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
            // productBindingSource1
            // 
            productBindingSource1.DataSource = typeof(DAL.Models.Product);
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnUpdateStorage);
            panel1.Controls.Add(txtBxStorageUpdate);
            panel1.Location = new Point(364, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 91);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.Location = new Point(364, 399);
            label1.Name = "label1";
            label1.Size = new Size(408, 20);
            label1.TabIndex = 4;
            label1.Text = "Lütfen bir işlem yapmak için listeden seçim yapınız.";
            // 
            // txtBxStorageUpdate
            // 
            txtBxStorageUpdate.Location = new Point(4, 28);
            txtBxStorageUpdate.Name = "txtBxStorageUpdate";
            txtBxStorageUpdate.Size = new Size(401, 23);
            txtBxStorageUpdate.TabIndex = 0;
            // 
            // btnUpdateStorage
            // 
            btnUpdateStorage.Location = new Point(275, 57);
            btnUpdateStorage.Name = "btnUpdateStorage";
            btnUpdateStorage.Size = new Size(130, 31);
            btnUpdateStorage.TabIndex = 5;
            btnUpdateStorage.Text = "Depoyu Güncelle";
            btnUpdateStorage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 10);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Depo Adı:";
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depo Uygulaması";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorage).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStorages).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource productBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAddNewProduct;
        private DataGridView dataGridViewProducts;
        private BindingSource productBindingSource1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridView dataGridViewStorage;
        private DataGridViewTextBoxColumn idStorage;
        private Button btnAddNewProductToStorage;
        private DataGridViewTextBoxColumn productNameStorage;
        private DataGridViewTextBoxColumn countProductStorage;
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
    }
}

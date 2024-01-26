namespace DepoApp
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            label2 = new Label();
            cmbBxCategories = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            rdButtonLt = new RadioButton();
            rdButtonKg = new RadioButton();
            rdButtonCount = new RadioButton();
            label3 = new Label();
            txtBxBarcode = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(109, 40);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(189, 23);
            txtProductName.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(83, 165);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(147, 36);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 43);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı:";
            // 
            // cmbBxCategories
            // 
            cmbBxCategories.FormattingEnabled = true;
            cmbBxCategories.Location = new Point(109, 69);
            cmbBxCategories.Name = "cmbBxCategories";
            cmbBxCategories.Size = new Size(189, 23);
            cmbBxCategories.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Ürün Kategorisi:";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdButtonLt);
            panel1.Controls.Add(rdButtonKg);
            panel1.Controls.Add(rdButtonCount);
            panel1.Location = new Point(14, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 37);
            panel1.TabIndex = 6;
            // 
            // rdButtonLt
            // 
            rdButtonLt.AutoSize = true;
            rdButtonLt.Location = new Point(242, 9);
            rdButtonLt.Name = "rdButtonLt";
            rdButtonLt.Size = new Size(36, 19);
            rdButtonLt.TabIndex = 2;
            rdButtonLt.Text = "LT";
            rdButtonLt.UseVisualStyleBackColor = true;
            // 
            // rdButtonKg
            // 
            rdButtonKg.AutoSize = true;
            rdButtonKg.Location = new Point(119, 9);
            rdButtonKg.Name = "rdButtonKg";
            rdButtonKg.Size = new Size(39, 19);
            rdButtonKg.TabIndex = 1;
            rdButtonKg.Text = "KG";
            rdButtonKg.UseVisualStyleBackColor = true;
            // 
            // rdButtonCount
            // 
            rdButtonCount.AutoSize = true;
            rdButtonCount.Checked = true;
            rdButtonCount.Location = new Point(3, 9);
            rdButtonCount.Name = "rdButtonCount";
            rdButtonCount.Size = new Size(50, 19);
            rdButtonCount.TabIndex = 0;
            rdButtonCount.TabStop = true;
            rdButtonCount.Text = "Adet";
            rdButtonCount.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 104);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 7;
            label3.Text = "Ürünün Ölçü Şekli:";
            // 
            // txtBxBarcode
            // 
            txtBxBarcode.Location = new Point(109, 11);
            txtBxBarcode.Name = "txtBxBarcode";
            txtBxBarcode.Size = new Size(189, 23);
            txtBxBarcode.TabIndex = 8;
            txtBxBarcode.Click += txtBxBarcode_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 15);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "Ürün Barkodu:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 220);
            Controls.Add(label4);
            Controls.Add(txtBxBarcode);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(cmbBxCategories);
            Controls.Add(label2);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürün Ekle";
            FormClosed += AddProduct_FormClosed;
            Load += AddProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private Button btnAddProduct;
        private Label label2;
        private ComboBox cmbBxCategories;
        private Label label1;
        private Panel panel1;
        private RadioButton rdButtonLt;
        private RadioButton rdButtonKg;
        private RadioButton rdButtonCount;
        private Label label3;
        private TextBox txtBxBarcode;
        private Label label4;
    }
}
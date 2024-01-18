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
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(78, 25);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(189, 23);
            txtProductName.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(78, 102);
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
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 178);
            Controls.Add(label2);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürün Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private Button btnAddProduct;
        private Label label2;
    }
}
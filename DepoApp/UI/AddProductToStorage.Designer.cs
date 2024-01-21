namespace DepoApp.UI
{
    partial class AddProductToStorage
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
            components = new System.ComponentModel.Container();
            cmbBxProducts = new ComboBox();
            productBindingSource = new BindingSource(components);
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            cmbBxStorages = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmbBxProducts
            // 
            cmbBxProducts.FormattingEnabled = true;
            cmbBxProducts.Location = new Point(93, 31);
            cmbBxProducts.Name = "cmbBxProducts";
            cmbBxProducts.Size = new Size(183, 23);
            cmbBxProducts.TabIndex = 0;
            cmbBxProducts.SelectedIndexChanged += cmbBxProducts_SelectedIndexChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DAL.Models.Product);
            // 
            // button1
            // 
            button1.Location = new Point(80, 158);
            button1.Name = "button1";
            button1.Size = new Size(183, 41);
            button1.TabIndex = 1;
            button1.Text = "Ürünü Depoya Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(93, 87);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Ürün:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 89);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Adet:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbBxStorages
            // 
            cmbBxStorages.FormattingEnabled = true;
            cmbBxStorages.Location = new Point(93, 60);
            cmbBxStorages.Name = "cmbBxStorages";
            cmbBxStorages.Size = new Size(183, 23);
            cmbBxStorages.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Hangi Depo:";
            // 
            // AddProductToStorage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 213);
            Controls.Add(label3);
            Controls.Add(cmbBxStorages);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(cmbBxProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddProductToStorage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Depoya Ürün Ekle";
            Load += AddProductToStorage_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBxProducts;
        private BindingSource productBindingSource;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private ComboBox cmbBxStorages;
        private Label label3;
    }
}
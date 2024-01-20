namespace DepoApp.UI
{
    partial class AddSale
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
            cmbBxProducts = new ComboBox();
            cmbBxStorages = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // cmbBxProducts
            // 
            cmbBxProducts.Enabled = false;
            cmbBxProducts.FormattingEnabled = true;
            cmbBxProducts.Location = new Point(48, 92);
            cmbBxProducts.Name = "cmbBxProducts";
            cmbBxProducts.Size = new Size(260, 23);
            cmbBxProducts.TabIndex = 0;
            // 
            // cmbBxStorages
            // 
            cmbBxStorages.FormattingEnabled = true;
            cmbBxStorages.Location = new Point(48, 36);
            cmbBxStorages.Name = "cmbBxStorages";
            cmbBxStorages.Size = new Size(260, 23);
            cmbBxStorages.TabIndex = 1;
            cmbBxStorages.SelectedIndexChanged += cmbBxStorages_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Depo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 74);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Ürün";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(48, 139);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(48, 240);
            button1.Name = "button1";
            button1.Size = new Size(260, 29);
            button1.TabIndex = 5;
            button1.Text = "Satış Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 121);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 174);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Toplam Gelir";
            // 
            // AddSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 293);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbBxStorages);
            Controls.Add(cmbBxProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSale";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Satış";
            Load += AddSale_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBxProducts;
        private ComboBox cmbBxStorages;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
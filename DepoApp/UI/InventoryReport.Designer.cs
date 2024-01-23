namespace DepoApp.UI
{
    partial class InventoryReport
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
            panel1 = new Panel();
            dataGridViewRestock = new DataGridView();
            dataGridViewSales = new DataGridView();
            saleId = new DataGridViewTextBoxColumn();
            saleProductName = new DataGridViewTextBoxColumn();
            saleCount = new DataGridViewTextBoxColumn();
            saleDate = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            RestockDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewRestock);
            panel1.Controls.Add(dataGridViewSales);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 343);
            panel1.TabIndex = 0;
            // 
            // dataGridViewRestock
            // 
            dataGridViewRestock.AllowUserToAddRows = false;
            dataGridViewRestock.AllowUserToDeleteRows = false;
            dataGridViewRestock.AllowUserToOrderColumns = true;
            dataGridViewRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRestock.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, RestockDate });
            dataGridViewRestock.Location = new Point(429, 28);
            dataGridViewRestock.Name = "dataGridViewRestock";
            dataGridViewRestock.ReadOnly = true;
            dataGridViewRestock.Size = new Size(344, 312);
            dataGridViewRestock.TabIndex = 1;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToOrderColumns = true;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { saleId, saleProductName, saleCount, saleDate });
            dataGridViewSales.Location = new Point(3, 28);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.Size = new Size(344, 312);
            dataGridViewSales.TabIndex = 0;
            // 
            // saleId
            // 
            saleId.HeaderText = "id";
            saleId.Name = "saleId";
            saleId.ReadOnly = true;
            // 
            // saleProductName
            // 
            saleProductName.HeaderText = "Ürün Adı";
            saleProductName.Name = "saleProductName";
            saleProductName.ReadOnly = true;
            // 
            // saleCount
            // 
            saleCount.HeaderText = "Satış Adedi";
            saleCount.Name = "saleCount";
            saleCount.ReadOnly = true;
            // 
            // saleDate
            // 
            saleDate.HeaderText = "Tarih";
            saleDate.Name = "saleDate";
            saleDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Satış Adedi";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RestockDate
            // 
            RestockDate.HeaderText = "Tarih";
            RestockDate.Name = "RestockDate";
            RestockDate.ReadOnly = true;
            // 
            // InventoryReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "InventoryReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InventoryReport";
            Load += InventoryReport_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewRestock;
        private DataGridView dataGridViewSales;
        private DataGridViewTextBoxColumn saleId;
        private DataGridViewTextBoxColumn saleProductName;
        private DataGridViewTextBoxColumn saleCount;
        private DataGridViewTextBoxColumn saleDate;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn RestockDate;
    }
}
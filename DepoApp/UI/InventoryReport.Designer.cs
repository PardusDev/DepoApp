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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            panel1 = new Panel();
            cmbBxProducts = new ComboBox();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRestock = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            RestockDate = new DataGridViewTextBoxColumn();
            dataGridViewSales = new DataGridView();
            saleId = new DataGridViewTextBoxColumn();
            saleProductName = new DataGridViewTextBoxColumn();
            saleCount = new DataGridViewTextBoxColumn();
            saleDate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRestock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbBxProducts);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(dataGridViewRestock);
            panel1.Controls.Add(dataGridViewSales);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 481);
            panel1.TabIndex = 0;
            // 
            // cmbBxProducts
            // 
            cmbBxProducts.FormattingEnabled = true;
            cmbBxProducts.Location = new Point(304, 402);
            cmbBxProducts.Name = "cmbBxProducts";
            cmbBxProducts.Size = new Size(167, 23);
            cmbBxProducts.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(304, 458);
            button1.Name = "button1";
            button1.Size = new Size(167, 23);
            button1.TabIndex = 3;
            button1.Text = "Grafiğini Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            chart1.Size = new Size(776, 262);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // dataGridViewRestock
            // 
            dataGridViewRestock.AllowUserToAddRows = false;
            dataGridViewRestock.AllowUserToDeleteRows = false;
            dataGridViewRestock.AllowUserToOrderColumns = true;
            dataGridViewRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRestock.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, RestockDate });
            dataGridViewRestock.Location = new Point(478, 291);
            dataGridViewRestock.Name = "dataGridViewRestock";
            dataGridViewRestock.ReadOnly = true;
            dataGridViewRestock.Size = new Size(298, 190);
            dataGridViewRestock.TabIndex = 1;
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
            dataGridViewTextBoxColumn3.HeaderText = "Alış Adedi";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RestockDate
            // 
            RestockDate.HeaderText = "Tarih";
            RestockDate.Name = "RestockDate";
            RestockDate.ReadOnly = true;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AllowUserToAddRows = false;
            dataGridViewSales.AllowUserToDeleteRows = false;
            dataGridViewSales.AllowUserToOrderColumns = true;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Columns.AddRange(new DataGridViewColumn[] { saleId, saleProductName, saleCount, saleDate });
            dataGridViewSales.Location = new Point(0, 291);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.ReadOnly = true;
            dataGridViewSales.Size = new Size(298, 190);
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
            // InventoryReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(panel1);
            Name = "InventoryReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stok Raporu";
            Load += InventoryReport_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
        private ComboBox cmbBxProducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn RestockDate;
    }
}
using DepoApp.DAL.Context;
using DepoApp.DAL.Manager;
using DepoApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoApp
{
    public partial class AddProduct : Form
    {
        ProductManager _productManager = new ProductManager();
        DepoDbContext db = new DepoDbContext();
        Home home;

        public AddProduct(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.OrderBy(c => c.id).ToList();
            cmbBxCategories.ValueMember = "id";
            cmbBxCategories.DisplayMember = "name";
            cmbBxCategories.DataSource = categories;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.name = txtProductName.Text.Trim();
            newProduct.category = db.Categories.Find(cmbBxCategories.SelectedValue);
            newProduct.measurementType = getMeasurementType();

            // Check if it's already there
            Product product = _productManager.GetAll().Where(p => (p.name == newProduct.name) && (p.category == newProduct.category)).FirstOrDefault();
            if (product != null)
            {
                MessageBox.Show("Bu ürün zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if product name is empty
            if (newProduct.name == "")
            {
                MessageBox.Show("Ürün adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if category is selected
            if (newProduct.category == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if measurement type is selected
            if (newProduct.measurementType == -1)
            {
                MessageBox.Show("Lütfen bir ölçü birimi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.Products.Add(newProduct);
                db.Categories.Attach(newProduct.category);
                if (db.SaveChanges() > 0 )
                {
                    MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home.dataGridViewProducts.Rows.Add(newProduct.id, newProduct.name, newProduct.category.name, getMeasurementType(newProduct.measurementType));
          
                    txtProductName.Text = "";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int getMeasurementType()
        {
            if (rdButtonCount.Checked)
            {
                return 0;
            }
            else if (rdButtonKg.Checked)
            {
                return 1;
            }
            else if (rdButtonLt.Checked)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }

        public string getMeasurementType(int measurementType)
        {
            if (measurementType == 0)
            {
                return "Adet";
            }
            else if (measurementType == 1)
            {
                return "Kg";
            }
            else if (measurementType == 2)
            {
                return "Lt";
            }
            else
            {
                return "N/A";
            }
        }
    }
}

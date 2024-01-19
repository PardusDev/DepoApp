using DepoApp.DAL.Context;
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

namespace DepoApp.UI
{
    public partial class AddSale : Form
    {
        DepoDbContext db = new DepoDbContext();
        public AddSale()
        {
            InitializeComponent();
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            cmbBxStorages.ValueMember = "id";
            cmbBxStorages.DisplayMember = "name";
            cmbBxStorages.DataSource = db.Storages.ToList();
        }

        private void cmbBxStorages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxStorages.SelectedIndex == -1)
            {
                return;
            }
            cmbBxProducts.Enabled = true;
            var selectedStorage = cmbBxStorages.SelectedValue;

            var products = db.StorageItems.Include(si => si.product).Include(si => si.storage).Where(si => si.storage.id == (int)cmbBxStorages.SelectedValue).ToList();

            // Create a new list for display
            var productDisplayList = products.Select(si => new
            {
                id = si.id,
                name = si.product.name
            }).ToList();

            cmbBxProducts.DataSource = productDisplayList;
            cmbBxProducts.ValueMember = "id";
            cmbBxProducts.DisplayMember = "name";
        }
    }
}

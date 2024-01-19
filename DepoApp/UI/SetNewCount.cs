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

namespace DepoApp.UI
{
    public partial class SetNewCount : Form
    {
        StorageItem selectedStorageItem;
        StorageItemManager _storageItemManager = new StorageItemManager();

        public SetNewCount(StorageItem selectedStorageItem)
        {
            InitializeComponent();

            this.selectedStorageItem = selectedStorageItem;

             label1.Text = selectedStorageItem.product.name;
            numericUpDown1.Value = selectedStorageItem.count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedStorageItem.count = Convert.ToInt32(numericUpDown1.Value);
            try
            {   
                if (_storageItemManager.Update(selectedStorageItem))
                {
                    MessageBox.Show("Stok güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stok güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

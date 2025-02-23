using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_QL
{
    public partial class Invoice : Form
    {
        private bool saved = false;
        public Invoice()
        {
            InitializeComponent();
            labelDateTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy HH:mm:ss");
        }
        public void SetCustomerName(string customerName)
        {
            lblCustomerName.Text = customerName;
        }
        public void SetEmployeeName(string employeeName)
        {
            lblEmployeeName.Text = employeeName;
        }
        public void SetProducts(List<string> productNames)
        {
            lstProducts.Items.Clear();
            foreach (string productName in productNames)
            {
                lstProducts.Items.Add(productName);
            }
        }
        public void SetTotal(decimal total)
        {
            lblTotalPrice.Text = total.ToString();
            labelTP.Text = "$"+total.ToString();
        }
        public void SaveAsImage(string customerName, DateTime createDate)
        {
            try
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

                string folderPath = Path.Combine(Application.StartupPath, "Invoices");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = $"{customerName}_{createDate:dd-MM-yyyy}.png";
                string filePath = Path.Combine(folderPath, fileName);

                bmp.Save(filePath, ImageFormat.Png);
                saved = true;

                MessageBox.Show("Invoice saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("Do you want to save the invoice before closing?", "Save Invoice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string customerName = lblCustomerName.Text;
                    DateTime createDate = DateTime.Now;
                    SaveAsImage(customerName, createDate);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}



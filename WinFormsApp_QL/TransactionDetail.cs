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
    public partial class TransactionDetail : Form
    {
        private bool saved = false;

        public TransactionDetail(DataTable transactionDetails)
        {
            InitializeComponent();
            dataGridView1.DataSource = transactionDetails;

            this.dataGridView1.ScrollBars = ScrollBars.None;
            this.dataGridView1.MouseWheel += new MouseEventHandler(mousewheel);

            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataRow row in ((DataTable)dataGridView1.DataSource).Rows)
            {
                if (row.Table.Columns.Contains("Unit Price") && decimal.TryParse(row["Unit Price"].ToString(), out decimal unitPrice))
                {
                    total += unitPrice;
                }
            }
            lblTotalPrice.Text = total.ToString("0.000");
        }
        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && dataGridView1.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex++;
            }
        }
        public void UpdateLabelValue(string value)
        {
            label3.Text = value;
        }
        public void SaveTransactionAsImage(string customerName, DateTime createDate)
        {
            try
            {
                Bitmap bmp = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

                string folderPath = Path.Combine(Application.StartupPath, "Transactions");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = $"{customerName}_{createDate:dd-MM-yyyy}.png";
                string filePath = Path.Combine(folderPath, fileName);

                bmp.Save(filePath, ImageFormat.Png);
                saved = true;

                MessageBox.Show("Transaction saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("Do you want to save the transaction before closing?", "Save Transaction", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string customerName = label3.Text;
                    DateTime createDate = DateTime.Now;
                    SaveTransactionAsImage(customerName, createDate);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}

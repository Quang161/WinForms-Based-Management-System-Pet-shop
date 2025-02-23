using DocumentFormat.OpenXml.Vml;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp_QL
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
            BillingLoad();
            CusLoad();
        }
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void BillingLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.NameCustomer AS Customer, bt.IDBill AS [Bill ID], bt.Total, bt.CDate AS Date FROM CustomerTbl c JOIN BillingTbl bt ON c.IDCustomer = bt.IDCustomer;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;

            this.dataGridView1.ScrollBars = ScrollBars.None;
            this.dataGridView1.MouseWheel += new MouseEventHandler(mousewheel1);
        }
        private void CusLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDCustomer AS ID, NameCustomer AS Customer, Gender, Address, Phone, Nickname FROM CustomerTBL", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dt;

            this.dataGridView2.ScrollBars = ScrollBars.None;
            this.dataGridView2.MouseWheel += new MouseEventHandler(mousewheel2);

            if (dataGridView2 != null && dataGridView2.Columns["ID"] != null)
            {
                dataGridView2.Columns["ID"].Visible = false;
            }
        }
        private void mousewheel1(object sender, MouseEventArgs e)
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
        private void mousewheel2(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && dataGridView2.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridView2.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                dataGridView2.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                textBoxCusName.Text = selectedRow.Cells["Customer"].Value.ToString();
                textBoxCusID.Text = selectedRow.Cells["ID"].Value.ToString();
            }
        }
        private void ButtonSearchTransaction_Click(object sender, EventArgs e)
        {
            string customerIDText = textBoxCusID.Text;

            int customerID;

            if (!int.TryParse(customerIDText, out customerID))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            DataTable billingDetails = SearchBills(customerID);

            if (billingDetails.Rows.Count > 0)
            {
                TransactionDetail transactionDetailForm = new TransactionDetail(billingDetails);
                string valueFromTextBox = textBoxCusName.Text;
                transactionDetailForm.UpdateLabelValue(valueFromTextBox);
                transactionDetailForm.Show();
            }
            else
            {
                MessageBox.Show("No billing details found for the given Customer ID.");
            }
        }
        private DataTable SearchBills(int customerID)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = @"SELECT
                            p.NameProduct AS Product,
                            bd.Quantity,
                            bd.UnitPrice AS [Unit Price],
                            b.Cdate AS Date
                        FROM
                            BillingDetail bd
                        INNER JOIN
                            ProductTbl p ON bd.IDProduct = p.IDProduct
                        INNER JOIN
                            BillingTbl b ON bd.IDBill = b.IDBill
                        WHERE
                            b.IDCustomer = @CustomerID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns["Unit Price"].DataType = typeof(decimal);
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Unit Price"] != DBNull.Value)
                    {
                        row["Unit Price"] = Convert.ToDecimal(row["Unit Price"]).ToString("0.000");
                    }
                }

                return dt;
            }
        }
        //Remove Screen Flickering 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }
}

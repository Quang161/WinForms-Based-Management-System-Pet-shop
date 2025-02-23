using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class Billing : Form
    {
        private int quantityColumnIndex = -1;
        private int priceColumnIndex = -1;
        private List<ItemInfo> products;
        public Billing()
        {
            InitializeComponent();
            LoadProducts();
            CusLoad();
            InitializeDataGridView();
            ComboBoxEmp();
            products = new List<ItemInfo>();
        }
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        int itemsCount = 0;
        const int itemsPerRow = 3;
        private void CusLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.IDCustomer AS ID, c.NameCustomer AS Customer, c.Nickname, p.Name " +
                                                    "AS [Pet Name], p.Species AS Species FROM CustomerTbl c " +
                                                    "INNER JOIN PetTbl p ON c.IDCustomer = p.IDCustomer;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dt;
        }
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT NameProduct, Type, Quantity, Price FROM ProductTbl ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            string name = reader["NameProduct"].ToString();
                            string type = reader["Type"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            decimal price = Convert.ToDecimal(reader["Price"]);
                            AddNewItem(name, type, quantity, price);
                        }
                    }
                }
            }
        }
        private Dictionary<string, Bitmap> itemImages = new Dictionary<string, Bitmap>
        {
        { "Food", Properties.Resources.Food },
        { "Toy", Properties.Resources.Toy },
        { "Extras", Properties.Resources.Extras },
        { "Furniture", Properties.Resources.Furniture },
        { "Default", Properties.Resources.Default_Img },
        //{ "Healthcare", Properties.Resources.Healthcare },
        //{ "Beauty", Properties.Resources.Beauty },
        //{ "Training", Properties.Resources.Training }
        };
        private void AddNewItem(string itemName, string itemType, int itemQuantity, decimal price)
        {
            int x = (itemsCount % itemsPerRow) * 200;
            int y = (itemsCount / itemsPerRow) * 200;

            PictureBox picBox = new PictureBox
            {
                Size = new Size(150, 100),
                Location = new Point(x, y),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = itemImages.ContainsKey(itemType) ? itemImages[itemType] : itemImages["Default"]
            };
            flowLayoutPanel1.Controls.Add(picBox);

            picBox.Tag = new ItemInfo(itemName, itemQuantity, price);
            picBox.Click += PictureBox_Click;

            Label lbl = new Label
            {
                Text = $"{itemName} \nType: {itemType}" +
                /*$"\nQuantity: {itemQuantity}" +*/
                $"\nPrice: ${price}",
                Location = new Point(x, y),
                Size = new Size(145, 100),
                TextAlign = ContentAlignment.TopLeft
            };
            flowLayoutPanel1.Controls.Add(lbl);

            lbl.Tag = new ItemInfo(itemName, itemQuantity, price);
            lbl.Click += Label_Click;

            itemsCount++;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            ItemInfo info = (ItemInfo)clickedPictureBox.Tag;

            ItemName.Text = info.Name;
            Availabletxt.Text = info.Quantity.ToString();
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            ItemInfo info = (ItemInfo)clickedLabel.Tag;

            ItemName.Text = info.Name;
            Availabletxt.Text = info.Quantity.ToString();
        }
        public class ItemInfo
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Total
            {
                get { return Price * Quantity; }
            }
            public ItemInfo(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                IDCustomer.Text = selectedRow.Cells["ID"].Value.ToString();
                NameCustomer.Text = selectedRow.Cells["Customer"].Value.ToString();
            }
        }
        private void BtnAddtoBill_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = NameCustomer.Text;
                string employeeName = comboBoxEmp.Text;
                string itemName = ItemName.Text;
                int quantity = int.Parse(numericUpDown1.Text);
                decimal price = GetProductPrice(itemName);
                decimal total = price * quantity;

                bool itemExists = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductName"].Value != null && row.Cells["ProductName"].Value.ToString() == itemName)
                    {
                        int existingQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal existingTotal = Convert.ToDecimal(row.Cells["Total"].Value);

                        int newQuantity = existingQuantity + quantity;
                        decimal newTotal = existingTotal + total;

                        row.Cells["Quantity"].Value = newQuantity;
                        row.Cells["Total"].Value = newTotal;

                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    dataGridView1.Rows.Add(customerName, employeeName, itemName, quantity, price, total);
                }

                UpdateProductQuantity(itemName, quantity);

                CalculateTotalPrice();

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateProductQuantity(string itemName, int quantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE ProductTbl SET Quantity = Quantity - @quantity WHERE NameProduct = @itemName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@itemName", itemName);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product quantity: " + ex.Message);
            }
        }
        private decimal GetProductPrice(string itemName)
        {
            decimal price = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT Price FROM ProductTbl WHERE NameProduct = @itemName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@itemName", itemName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        price = Convert.ToDecimal(reader["Price"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting product price: " + ex.Message);
            }
            return price;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                CreateTextBoxColumn("Customer", "CustomerName"),
                CreateTextBoxColumn("Employee", "employeename"),
                CreateTextBoxColumn("Product", "ProductName"),
                CreateTextBoxColumn("Quantity", "Quantity"),
                CreateTextBoxColumn("Price", "Price"),
                CreateTextBoxColumn("Total", "Total"),
            };
            foreach (DataGridViewTextBoxColumn column in columns)
            {
                if (!dataGridView1.Columns.Contains(column))
                {
                    dataGridView1.Columns.Add(column);
                    if (column.DataPropertyName == "Quantity")
                    {
                        column.Name = "Quantity";
                    }
                    else if (column.DataPropertyName == "ProductName")
                    {
                        column.Name = "ProductName";
                    }
                    else if (column.DataPropertyName == "Price")
                    {
                        column.Name = "Price";
                    }
                    else if (column.DataPropertyName == "Total")
                    {
                        column.Name = "Total";
                    }
                }
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "Quantity")
                {
                    quantityColumnIndex = i;
                }
                else if (dataGridView1.Columns[i].DataPropertyName == "Price")
                {
                    priceColumnIndex = i;
                }
            }
        }
        private DataGridViewTextBoxColumn CreateTextBoxColumn(string headerText, string dataPropertyName)
        {
            return new DataGridViewTextBoxColumn
            {
                HeaderText = headerText,
                DataPropertyName = dataPropertyName
            };
        }
        private void InsertIntoBillingTable(string customerName, int employeeId, List<ItemInfo> products, decimal total)
        {
            try
            {
                int customerId = GetCustomerId(customerName);

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO BillingTbl (IDCustomer, IDEmp, Total, CDate) VALUES (@customerId, @employeeId, @total, @cDate)";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@employeeId", employeeId); 
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@cDate", DateTime.Now);
                    command.ExecuteNonQuery();

                    int billingId = GetLastBillingId();

                    foreach (ItemInfo product in products)
                    {
                        int productId = GetProductId(product.Name);

                        string detailQuery = "INSERT INTO BillingDetail (IDBill, IDProduct, Quantity, UnitPrice, Total) VALUES (@billingId, @productId, @quantity, @unitprice, @total)";
                        SqlCommand detailCommand = new SqlCommand(detailQuery, conn);
                        detailCommand.Parameters.AddWithValue("@billingId", billingId);
                        detailCommand.Parameters.AddWithValue("@productId", productId);
                        detailCommand.Parameters.AddWithValue("@unitprice", product.Price);
                        detailCommand.Parameters.AddWithValue("@quantity", product.Quantity);
                        detailCommand.Parameters.AddWithValue("@total", product.Total);
                        detailCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting into BillingTbl: " + ex.Message);
            }
        }
        private int GetCustomerId(string customerName)
        {
            int customerId = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT IDCustomer AS ID FROM CustomerTbl WHERE NameCustomer = @customerName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@customerName", customerName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        customerId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting ID in CustomerTbl: " + ex.Message);
            }
            return customerId;
        }
        private int GetProductId(string itemName)
        {
            int productId = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT IDProduct FROM ProductTbl WHERE NameProduct = @itemName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@itemName", itemName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        productId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting product ID from ProductTbl: " + ex.Message);
            }
            return productId;
        }
        private void ComboBoxEmp()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = $"SELECT IDEmp, NameEmp FROM EmployeeTbl";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBoxEmp.DataSource = dt;
                        comboBoxEmp.DisplayMember = "NameEmp";
                        comboBoxEmp.ValueMember = "IDEmp";
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBillPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = "";
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    customerName = selectedRow.Cells["Customer"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a customer.");
                    return;
                }

                int employeeId = Convert.ToInt32(comboBoxEmp.SelectedValue);
                string employeeName = comboBoxEmp.Text;

                List<ItemInfo> products = new List<ItemInfo>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string itemName = row.Cells["ProductName"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        ItemInfo product = new ItemInfo(itemName, quantity, price);
                        products.Add(product);
                    }
                }

                decimal total = decimal.Parse(TxtTotal.Text);

                Invoice invoiceForm = new Invoice();
                invoiceForm.SetCustomerName(customerName);
                invoiceForm.SetEmployeeName(employeeName);
                invoiceForm.SetProducts(products.Select(p => string.Format("{0,4} {1,16} {2,16} {3,16}", p.Quantity, p.Name, p.Price, p.Total)).ToList());
                invoiceForm.SetTotal(total);
                invoiceForm.Show();

                InsertIntoBillingTable(customerName, employeeId, products, total);

                MessageBox.Show("Billing information has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No products selected");
            }
        }
        private void CalculateTotalPrice()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                if (dataGridView1.Columns.Count > 0)
                {
                    int totalColumnIndex = -1;
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (dataGridView1.Columns[i].HeaderText == "Total")
                        {
                            totalColumnIndex = i;
                            break;
                        }
                    }
                    if (totalColumnIndex != -1)
                    {
                        decimal totalPrice = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row != null && !row.IsNewRow)
                            {
                                if (row.Cells[totalColumnIndex].Value != null)
                                {
                                    decimal total;
                                    if (decimal.TryParse(row.Cells[totalColumnIndex].Value.ToString(), out total))
                                    {
                                        totalPrice += total;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Vaule of Total {row.Index} is null.");
                                }
                            }
                        }
                        TxtTotal.Text = totalPrice.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not found row 'Total' in DataGridView.");
                    }
                }
                else
                {
                    MessageBox.Show("DataGridView have no available rows.");
                }
            }
        }
        private int GetLastBillingId()
        {
            int lastBillingId = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 IDBill FROM BillingTbl ORDER BY IDBill DESC";
                    SqlCommand command = new SqlCommand(query, conn);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        lastBillingId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting last billing ID: " + ex.Message);
            }
            return lastBillingId;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            TxtTotal.Text = String.Empty;
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string searchByName = NameCustomer.Text.Trim();
            if (!string.IsNullOrEmpty(searchByName))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string query = "SELECT c.IDCustomer AS ID, c.NameCustomer AS Customer, c.Nickname, p.Name AS [Pet Name], p.Species AS Species " +
                                       "FROM CustomerTbl c " +
                                       "INNER JOIN PetTbl p ON c.IDCustomer = p.IDCustomer " +
                                       "WHERE c.NameCustomer LIKE @searchByName OR c.Nickname LIKE @searchByName OR p.Name LIKE @searchByName OR p.Species LIKE @searchByName";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@searchByName", $"%{searchByName}%");

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView2.DataSource = null;
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }
        private void buttonFindClear_Click(object sender, EventArgs e)
        {
            CusLoad();
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

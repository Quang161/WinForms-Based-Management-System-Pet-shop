using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using static WinFormsApp_QL.Billing;

namespace WinFormsApp_QL
{
    public partial class Inventory : Form
    {
        string connectionString = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        int itemsCount = 0;
        const int itemsPerRow = 3;
        public Inventory()
        {
            InitializeComponent();
        }
        //Database
        private void AddProductToDatabase(string name, string type, int quantity, decimal price)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ProductTbl (NameProduct, Type, Quantity, Price) VALUES (@Name, @Type, @Quantity, @Price)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred accessing the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input format: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Load
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT NameProduct, Type, Quantity, Price FROM ProductTbl"; // Include Type and Quantity in the query
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear(); // Clear previous items to avoid duplicates
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
        private void Product_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        //Add
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = comboBoxType.Text;

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price. Please enter a valid decimal number.");
                return;
            }

            AddProductToDatabase(name, type, quantity, price);
            LoadProducts();

            txtName.Clear();
            comboBoxType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            textBoxDelete.Clear();
            comboBoxFind.SelectedIndex = -1;
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
                Size = new Size(140, 100),
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
                Text = $"{itemName} \nType: {itemType}\nQuantity: {itemQuantity}\nPrice: ${price}",
                Location = new Point(x, y),
                Size = new Size(155, 100),
                TextAlign = ContentAlignment.TopLeft
            };
            flowLayoutPanel1.Controls.Add(lbl);

            lbl.Tag = new ItemInfo(itemName, itemQuantity, price);
            lbl.Click += Label_Click;

            itemsCount++;
        }
        //Click on Pic and Label
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            ItemInfo info = (ItemInfo)clickedPictureBox.Tag;

            txtName.Text = info.Name;
            txtQuantity.Text = info.Quantity.ToString();
            txtPrice.Text = info.Price.ToString();
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            ItemInfo info = (ItemInfo)clickedLabel.Tag;

            txtName.Text = info.Name;
            txtQuantity.Text = info.Quantity.ToString();
            txtPrice.Text = info.Price.ToString();
        }
        //Edit
        private void EditItem(string oldName, string newName, string type, int quantity, decimal price)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ProductTbl SET NameProduct = @NewName, Type = @Type, Quantity = @Quantity, Price = @Price WHERE NameProduct = @OldName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewName", newName);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@OldName", oldName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadProducts();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred accessing the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string oldName = txtName.Text;
            string newName = txtName.Text;
            string type = comboBoxType.Text;
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer.");
                return;
            }
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid price. Please enter a valid decimal number.");
                return;
            }
            EditItem(oldName, newName, type, quantity, price);

            txtName.Clear();
            comboBoxType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            textBoxDelete.Clear();
            comboBoxFind.SelectedIndex = -1;
        }
        //Delete
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string itemName = textBoxDelete.Text;
            DeleteItem(itemName);

            txtName.Clear();
            comboBoxType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            textBoxDelete.Clear();
            comboBoxFind.SelectedIndex = -1;
        }
        private void DeleteItem(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ProductTbl WHERE NameProduct = @Name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", itemName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred accessing the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Find
        private void buttonFind_Click(object sender, EventArgs e)
        {
            string searchType = comboBoxFind.Text;
            LoadFindProducts(searchType);

            txtName.Clear();
            comboBoxType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            textBoxDelete.Clear();
        }
        private void LoadFindProducts(string searchType = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT NameProduct, Type, Quantity, Price FROM ProductTbl";
                if (!string.IsNullOrEmpty(searchType))
                {
                    query += " WHERE Type = @Type";
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchType))
                    {
                        cmd.Parameters.AddWithValue("@Type", searchType);
                    }
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
        //Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            LoadProducts();
            txtName.Clear();
            comboBoxType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtPrice.Clear();
            textBoxDelete.Clear();
            comboBoxFind.SelectedIndex = -1;
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

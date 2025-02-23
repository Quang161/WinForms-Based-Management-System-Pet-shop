using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp_QL
{
    public partial class Pet : Form
    {
        //Ellipse Form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
            );
        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);

        private Button CurrentActiveButton;
        private Color InactiveButtonColor = Color.FromArgb(181, 51, 137);
        private string loggedInUsername;
        private string UserRole;

        private Bitmap tabPageImage;

        public Pet(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            InitializeComponent();
            loggedInUsername = username;
            UpdateUsernameLabel();

            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CurrentActiveButton = buttonPet;
            buttonPet.BackColor = Color.FromArgb(222, 111, 161);
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = InactiveButtonColor;
            }

            tabControl1.BackColor = Color.Transparent;
            tabPageList.BackColor = Color.Transparent;
            tabPageManage.BackColor = Color.Transparent;

            if (Emp && Cus && Pet && Rep)
            {
                UserRole = "Manager";
            }
            else if (Emp && Cus && Pet)
            {
                UserRole = "Clerk";
            }
            else if (Rep)
            {
                UserRole = "Accountant";
            }
            else
            {
                MessageBox.Show("Unknown Role");
                this.Close();
            }

            ComboBoxCus();
        }
        //Login
        private void UpdateUsernameLabel()
        {
            labelUser.Text = $"{loggedInUsername}";
        }
        private void Pet_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            Petload();
            ComboBoxCus();

            switch (UserRole)
            {
                case "Manager":
                    buttonCus.Enabled = true;
                    buttonEmp.Enabled = true;
                    buttonPet.Enabled = true;
                    buttonReport.Enabled = true;
                    break;
                case "Clerk":
                    buttonCus.Enabled = true;
                    buttonEmp.Enabled = true;
                    buttonPet.Enabled = true;
                    buttonReport.Enabled = false;
                    break;
                case "Accountant":
                    buttonCus.Enabled = false;
                    buttonEmp.Enabled = false;
                    buttonPet.Enabled = false;
                    buttonReport.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rec = tabControl1.ClientRectangle;

            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;
            StrFormat.Alignment = StringAlignment.Center;

            SolidBrush backColor = new SolidBrush(Color.PaleVioletRed);
            SolidBrush fontColor;

            e.Graphics.FillRectangle(backColor, rec);

            Font fntTab = e.Font;
            Brush bshBack = new SolidBrush(Color.Transparent);

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                bool bSelected = (tabControl1.SelectedIndex == i);
                Rectangle recBounds = tabControl1.GetTabRect(i);
                RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(i);
                if (bSelected)
                {
                    e.Graphics.FillRectangle(bshBack, recBounds);
                    fontColor = new SolidBrush(Color.LavenderBlush);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
                else
                {
                    fontColor = new SolidBrush(Color.Black);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
        }
        //Exit
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Menu
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            SetActiveButton(clickedButton);
        }
        //Home
        private void Home(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            MainForm newform = new MainForm(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void GotoHome(object sender, EventArgs e)
        {
            if (UserRole == "Clerk")
            {
                Home(loggedInUsername, true, true, true, false);
            }
            else if (UserRole == "Accountant")
            {
                Home(loggedInUsername, false, false, false, true);
            }
            else if (UserRole == "Manager")
            {
                Home(loggedInUsername, true, true, true, true);
            }
            else
            {
                MessageBox.Show("Access Denied! You don't have permission to perform this action.");
            }
        }
        //Emp
        private void Emp(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            Employee newform = new Employee(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void GotoEmp(object sender, EventArgs e)
        {
            if (UserRole == "Clerk")
            {
                Emp(loggedInUsername, true, true, true, false);
            }
            else if (UserRole == "Accountant")
            {
                Emp(loggedInUsername, false, false, false, true);
            }
            else if (UserRole == "Manager")
            {
                Emp(loggedInUsername, true, true, true, true);
            }
            else
            {
                MessageBox.Show("Access Denied! You don't have permission to perform this action.");
            }
        }
        //Cus
        private void Cus(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            Customer newform = new Customer(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void GotoCus(object sender, EventArgs e)
        {
            if (UserRole == "Clerk")
            {
                Cus(loggedInUsername, true, true, true, false);
            }
            else if (UserRole == "Accountant")
            {
                Cus(loggedInUsername, false, false, false, true);
            }
            else if (UserRole == "Manager")
            {
                Cus(loggedInUsername, true, true, true, true);
            }
            else
            {
                MessageBox.Show("Access Denied! You don't have permission to perform this action.");
            }
        }
        //Report
        private void Report(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            Report newform = new Report(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void GotoRep(object sender, EventArgs e)
        {
            if (UserRole == "Clerk")
            {
                Report(loggedInUsername, true, true, true, false);
            }
            else if (UserRole == "Accountant")
            {
                Report(loggedInUsername, false, false, false, true);
            }
            else if (UserRole == "Manager")
            {
                Report(loggedInUsername, true, true, true, true);
            }
            else
            {
                MessageBox.Show("Access Denied! You don't have permission to perform this action.");
            }
        }
        //Billing
        private void buttonBil_Click(object sender, EventArgs e)
        {
            Billing newform = new Billing();
            newform.ShowDialog();
        }
        //Service
        private void buttonSer_Click(object sender, EventArgs e)
        {
            Service newform = new Service();
            newform.ShowDialog();
        }
        //Logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void SetActiveButton(Button button)
        {
            if (CurrentActiveButton != null)
            {
                CurrentActiveButton.BackColor = InactiveButtonColor;
            }
            button.BackColor = Color.FromArgb(222, 111, 161);
            CurrentActiveButton = button;
        }
        //Database
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void Petload()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string query = $"SELECT p.Name, c.NameCustomer AS Owner, p.Species, p.Gender, p.Age, p.ColorAndPattern AS Color, p.HealthStatus AS Status " +
                                   $"FROM PetTBL p INNER JOIN CustomerTbl c ON p.IDCustomer = c.IDCustomer";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ComboBoxCus()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string query = $"SELECT NameCustomer FROM CustomerTbl";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        comboBoxCustomer.DataSource = dt;
                        comboBoxCustomer.DisplayMember = "NameCustomer";
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEmpAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string customerQuery = $"SELECT IDCustomer FROM CustomerTbl WHERE NameCustomer = @NameCustomer";
                    int customerId;
                    using (SqlCommand customerCmd = new SqlCommand(customerQuery, conn))
                    {
                        customerCmd.Parameters.AddWithValue("@NameCustomer", comboBoxCustomer.Text);
                        customerId = (int)customerCmd.ExecuteScalar();
                    }

                    string insertQuery = $"INSERT INTO PetTbl (Name, Gender, Age, ColorAndPattern, HealthStatus, Species, IDCustomer) " +
                                         $"VALUES (@Name, @Gender, @Age, @ColorAndPattern, @HealthStatus, @Species, @IDCustomer)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", textBoxPetName.Text);
                        cmd.Parameters.AddWithValue("@Gender", comboBoxPetGender.Text);
                        cmd.Parameters.AddWithValue("@Age", comboBoxPetAge.Text);
                        cmd.Parameters.AddWithValue("@ColorAndPattern", textBoxPetCP.Text);
                        cmd.Parameters.AddWithValue("@HealthStatus", comboBoxPetHealth.Text);
                        cmd.Parameters.AddWithValue("@Species", comboBoxPetSpecies.Text);
                        cmd.Parameters.AddWithValue("@IDCustomer", customerId);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    Petload();
                    MessageBox.Show("Pet added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string petName = textBoxPetName.Text;

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string deleteQuery = $"DELETE FROM PetTbl WHERE Name = @PetName";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@PetName", petName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pet information has been deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Pet not found.");
                        }
                    }
                    conn.Close();
                    Petload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEmpEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string petName = textBoxPetName.Text;

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string customerQuery = $"SELECT IDCustomer FROM CustomerTbl WHERE NameCustomer = @NameCustomer";
                    int customerId;
                    using (SqlCommand customerCmd = new SqlCommand(customerQuery, conn))
                    {
                        customerCmd.Parameters.AddWithValue("@NameCustomer", comboBoxCustomer.Text);
                        var result = customerCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Customer not found.");
                            return;
                        }
                        customerId = (int)result;
                    }

                    string updateQuery = $"UPDATE PetTbl SET Gender = @NewGender, Age = @NewAge, ColorAndPattern = @NewColorAndPattern, " +
                                         $"HealthStatus = @NewHealthStatus, Species = @NewSpecies, IDCustomer = @IDCustomer WHERE Name = @PetName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewGender", comboBoxPetGender.Text);
                        cmd.Parameters.AddWithValue("@NewAge", comboBoxPetAge.Text);
                        cmd.Parameters.AddWithValue("@NewColorAndPattern", textBoxPetCP.Text);
                        cmd.Parameters.AddWithValue("@NewHealthStatus", comboBoxPetHealth.Text);
                        cmd.Parameters.AddWithValue("@NewSpecies", comboBoxPetSpecies.Text);
                        cmd.Parameters.AddWithValue("@IDCustomer", customerId);
                        cmd.Parameters.AddWithValue("@PetName", petName);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pet information has been updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Pet not found.");
                        }
                    }
                    conn.Close();
                    Petload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                textBoxPetName.Text = selectedRow.Cells["Name"].Value.ToString();
                comboBoxPetGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                comboBoxPetAge.Text = selectedRow.Cells["Age"].Value.ToString();
                textBoxPetCP.Text = selectedRow.Cells["Color"].Value.ToString();
                comboBoxPetHealth.Text = selectedRow.Cells["Status"].Value.ToString();
                comboBoxPetSpecies.Text = selectedRow.Cells["Species"].Value.ToString();
                comboBoxCustomer.Text = selectedRow.Cells["Owner"].Value.ToString();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string PetQuery = $"SELECT p.Name, c.NameCustomer AS Owner, p.Species, p.Gender, p.Age, p.ColorAndPattern AS Color, p.HealthStatus AS Status " +
                                      $"FROM PetTBL p INNER JOIN CustomerTbl c ON p.IDCustomer = c.IDCustomer WHERE p.Species = @Species";

                    using (SqlCommand cmd = new SqlCommand(PetQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Species", textBoxSearch.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            dataGridView1.DataSource = null;
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Drag
        private void button2_Click(object sender, EventArgs e)
        {
            Petload();
            textBoxSearch.Text = "";
        }
        private void panelUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void tabPageList_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void tabPageManage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void buttonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelUserName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Print
        private void buttonEmpPrint_Click(object sender, EventArgs e)
        {
            CaptureTabPageImage();
            PrintTabPageImage();
        }
        private void CaptureTabPageImage()
        {
            int PrintTabPage = tabControl1.TabPages.IndexOfKey("tabPageManage");

            if (PrintTabPage >= 0)
            {
                TabPage manageTabPage = tabControl1.TabPages[PrintTabPage];
                tabPageImage = new Bitmap(manageTabPage.Width, manageTabPage.Height);
                manageTabPage.DrawToBitmap(tabPageImage, new Rectangle(0, 0, manageTabPage.Width, manageTabPage.Height));
            }
        }
        private void PrintTabPageImage()
        {
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                if (tabPageImage != null)
                {
                    Size printSize = ev.PageBounds.Size;

                    int x = (printSize.Width - tabPageImage.Width) / 2;
                    int y = (printSize.Height - tabPageImage.Height) / 2;
                    ev.Graphics.DrawImage(tabPageImage, x, y);
                }
            };
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
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

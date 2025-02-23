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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp_QL
{
    public partial class Customer : Form
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

        public Customer(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            InitializeComponent();
            loggedInUsername = username;
            UpdateUsernameLabel();

            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CurrentActiveButton = buttonCus;
            buttonCus.BackColor = Color.FromArgb(222, 111, 161);
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
        }
        //Login
        private void UpdateUsernameLabel()
        {
            labelUser.Text = $"{loggedInUsername}";
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            CusLoad();

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
        //Pet
        private void Pet(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            Pet newform = new Pet(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
        private void GotoPet(object sender, EventArgs e)
        {
            if (UserRole == "Clerk")
            {
                Pet(loggedInUsername, true, true, true, false);
            }
            else if (UserRole == "Accountant")
            {
                Pet(loggedInUsername, false, false, false, true);
            }
            else if (UserRole == "Manager")
            {
                Pet(loggedInUsername, true, true, true, true);
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
        private void CusLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT NameCustomer AS Customer,Gender,Address,Phone,Nickname FROM CustomerTBL", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }
        private void buttonCusAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();

                string insertQuery = $"INSERT INTO CustomerTbl (NameCustomer, Gender, Address, Phone,NickName) " +
                                     $"VALUES (@NameCustomer, @Gender, @Address, @Phone, @NickName)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NameCustomer", textBoxCusName.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxCusGender.Text);
                    cmd.Parameters.AddWithValue("@Address", textBoxCusAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBoxCusPhone.Text);
                    cmd.Parameters.AddWithValue("@NickName", textBoxNickName.Text);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                CusLoad();
                MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCusDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string DeleteQuery = $"DELETE FROM CustomerTbl WHERE NameCustomer = @NameCustomer";

                    using (SqlCommand cmd = new SqlCommand(DeleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NameCustomer", textBoxCusName.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer information has been deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found");
                        }
                    }
                    conn.Close();
                    CusLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCusEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string updateQuery = $"UPDATE CustomerTbl SET Gender = @Gender, " +
                                         $"Address = @Address, Phone = @Phone, NickName = @NickName WHERE NameCustomer = @NameCustomer";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NameCustomer", textBoxCusName.Text);
                        cmd.Parameters.AddWithValue("@Gender", comboBoxCusGender.Text);
                        cmd.Parameters.AddWithValue("@Address", textBoxCusAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBoxCusPhone.Text);
                        cmd.Parameters.AddWithValue("@NickName", textBoxNickName.Text);

                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer information has been updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }
                    conn.Close();
                    CusLoad();
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

                textBoxCusName.Text = selectedRow.Cells["Customer"].Value.ToString();
                comboBoxCusGender.Text = selectedRow.Cells["Gender"].Value.ToString();
                textBoxCusAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                textBoxCusPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                textBoxNickName.Text = selectedRow.Cells["NickName"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string customerQuery = $"SELECT NameCustomer AS Customer,Gender,Address,Phone,Nickname FROM CustomerTbl WHERE Nickname = N'{textBoxSearch.Text}'";
                    using (SqlCommand cmd = new SqlCommand(customerQuery, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            BindingSource bindingSource = new BindingSource();
                            bindingSource.DataSource = dataTable;

                            dataGridView1.DataSource = bindingSource;
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
        private void button2_Click(object sender, EventArgs e)
        {
            CusLoad();
            textBoxSearch.Text = "";
        }
        //Drag
        private void panel2_MouseDown(object sender, MouseEventArgs e)
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
        private void buttonCusPrint_Click(object sender, EventArgs e)
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

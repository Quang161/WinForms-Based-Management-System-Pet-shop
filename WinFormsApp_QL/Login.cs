using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace WinFormsApp_QL
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelLogin.Parent = pictureBox1;
            labelUserName.Parent = pictureBox1;
            labelPass.Parent = pictureBox1;
            buttonX.Parent = pictureBox1;

            labelUserName.Paint += labelUserName_Paint;

            labelLogin.BackColor = Color.Transparent;
            labelUserName.BackColor = Color.Transparent;
            labelPass.BackColor = Color.Transparent;

            buttonX.BackColor = Color.Transparent;
            buttonX.FlatStyle = FlatStyle.Flat;
            buttonX.FlatAppearance.BorderSize = 0;
            buttonX.FlatAppearance.MouseOverBackColor = buttonX.BackColor;
            buttonX.BackColorChanged += (s, e) =>
            {
                buttonX.FlatAppearance.MouseOverBackColor = buttonX.BackColor;
            };

            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseOverBackColor = buttonLogin.BackColor;
            buttonLogin.BackColorChanged += (s, e) =>
            {
                buttonLogin.FlatAppearance.MouseOverBackColor = buttonLogin.BackColor;
            };
            EmpLoad();
        }
        private void labelUserName_Paint(object sender, PaintEventArgs e)
        {
            string text = labelUserName.Text;
            Font font = labelUserName.Font;

            Color outlineColor = Color.PaleVioletRed;
            int outlineWidth = 2;

            Graphics g = e.Graphics;
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF((labelUserName.Width - textSize.Width) / 2,
                                             (labelUserName.Height - textSize.Height) / 2);

            for (int dx = -outlineWidth; dx <= outlineWidth; dx++)
            {
                for (int dy = -outlineWidth; dy <= outlineWidth; dy++)
                {
                    if (dx != 0 || dy != 0)
                    {
                        g.DrawString(text, font, new SolidBrush(outlineColor),
                                     textPosition.X + dx, textPosition.Y + dy);
                    }
                }
            }
            g.DrawString(text, font, new SolidBrush(labelUserName.ForeColor), textPosition);
        }
        private void labelPass_Paint(object sender, PaintEventArgs e)
        {
            string text = labelPass.Text;
            Font font = labelPass.Font;

            Color outlineColor = Color.DarkMagenta;
            int outlineWidth = 2;

            Graphics g = e.Graphics;
            SizeF textSize = g.MeasureString(text, font);
            PointF textPosition = new PointF((labelPass.Width - textSize.Width) / 2,
                                             (labelPass.Height - textSize.Height) / 2);

            for (int dx = -outlineWidth; dx <= outlineWidth; dx++)
            {
                for (int dy = -outlineWidth; dy <= outlineWidth; dy++)
                {
                    if (dx != 0 || dy != 0)
                    {
                        g.DrawString(text, font, new SolidBrush(outlineColor),
                                     textPosition.X + dx, textPosition.Y + dy);
                    }
                }
            }
            g.DrawString(text, font, new SolidBrush(labelPass.ForeColor), textPosition);
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin.PerformClick();
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin.PerformClick();
        }
        //Database
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void EmpLoad()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string query = @"SELECT e.NameEmp, e.[Password], p.PerType
                 FROM EmployeeTbl e
                 INNER JOIN PermissionTbl p ON e.Permission = p.PerId 
                 WHERE NameEmp = @username AND [Password] = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
            }
        }
        private void Login_Logout(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            string username = textBox3.Text;
            string password = textBox4.Text;

            if (AuthenticateUser(username, password))
            {
                string Permission = GetUserPermission(username);
                GrantPermissions(Permission, username);
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        //xác nhận phân quyền 
        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;
            string query = "SELECT COUNT(*) FROM EmployeeTbl WHERE NameEmp = @Username AND [Password] = @Password";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    isAuthenticated = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return isAuthenticated;
        }
        //lấy thông tin quyền
        private string GetUserPermission(string username)
        {
            string Permission = string.Empty;
            string query = "SELECT p.PerType FROM EmployeeTbl e INNER JOIN PermissionTbl p ON e.Permission = p.PerId WHERE e.NameEmp = @Username";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    Permission = result != null ? result.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return Permission;
        }
        //thao tác quyền
        private void GrantPermissions(string Permission, string username)
        {
            switch (Permission)
            {
                case "Manager":
                    MessageBox.Show("Welcome, Manager!");
                    ShowLoadingForm(username, true, true, true, true);
                    this.Close();
                    break;
                case "Clerk":
                    MessageBox.Show("Welcome, Clerk!");
                    ShowLoadingForm(username, true, true, true, false);
                    this.Close();
                    break;
                case "Accountant":
                    MessageBox.Show("Welcome, Accountant!");
                    ShowLoadingForm(username, false, false, false, true);
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
        }
        //Loading
        private void ShowLoadingForm(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            Loading newform = new Loading(username, Emp, Cus, Pet, Rep);
            this.Hide();
            newform.ShowDialog();
        }
        //Exit
        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Drag
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelUserName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

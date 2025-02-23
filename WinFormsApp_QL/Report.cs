using DocumentFormat.OpenXml.Drawing;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp_QL
{
    public partial class Report : Form
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

        private System.Windows.Forms.Button CurrentActiveButton;
        private Color InactiveButtonColor = Color.FromArgb(181, 51, 137);
        private string loggedInUsername;
        private string UserRole;
        public Report(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            InitializeComponent();
            loggedInUsername = username;
            UpdateUsernameLabel();

            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CurrentActiveButton = buttonReport;
            buttonReport.BackColor = Color.FromArgb(222, 111, 161);
            foreach (System.Windows.Forms.Button button in this.Controls.OfType<System.Windows.Forms.Button>())
            {
                button.BackColor = InactiveButtonColor;
            }

            tabControl1.BackColor = Color.Transparent;
            tabPageReport.BackColor = Color.Transparent;

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
        private void Report_Load(object sender, EventArgs e)
        {
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);

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
            System.Drawing.Rectangle rec = tabControl1.ClientRectangle;
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
                System.Drawing.Rectangle recBounds = tabControl1.GetTabRect(i);
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
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
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
        //In report
        private void buttonRepInventory_Click(object sender, EventArgs e)
        {
            Inventory newform = new Inventory();
            newform.ShowDialog();
        }
        private void buttonRepSale_Click(object sender, EventArgs e)
        {
            SalesReport newform = new SalesReport();
            newform.ShowDialog();
        }
        private void buttonRepFin_Click(object sender, EventArgs e)
        {
            Transaction newform = new Transaction();
            newform.ShowDialog();
        }
        private void buttonRepStaff_Click(object sender, EventArgs e)
        {
            if (UserRole == "Manager")
            {
                StaffList newform = new StaffList();
                newform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Denied! You don't have permission to perform this action.");
            }
        }
        private void SetActiveButton(System.Windows.Forms.Button button)
        {
            if (CurrentActiveButton != null)
            {
                CurrentActiveButton.BackColor = InactiveButtonColor;
            }
            button.BackColor = Color.FromArgb(222, 111, 161);
            CurrentActiveButton = button;
        }
        //Drag
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
        private void tabPageReport_MouseDown(object sender, MouseEventArgs e)
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

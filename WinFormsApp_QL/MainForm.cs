using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp_QL
{
    public partial class MainForm : Form
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
        public MainForm(string username, bool Emp, bool Cus, bool Pet, bool Rep)
        {
            InitializeComponent();
            loggedInUsername = username;
            UpdateUsernameLabel();

            this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CurrentActiveButton = buttonHome;
            buttonHome.BackColor = Color.FromArgb(222, 111, 161);
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = InactiveButtonColor;
            }

            labelQ1.Parent = pictureBox1;
            labelQ2.Parent = pictureBox1;
            labelQ3.Parent = pictureBox1;
            labelQ4.Parent = pictureBox1;
            labelQ5.Parent = pictureBox1;
            pictureBoxDog.Parent = pictureBox1;
            pictureBoxPen.Parent = pictureBox1;

            labelQ1.BackColor = Color.Transparent;
            labelQ2.BackColor = Color.Transparent;
            labelQ3.BackColor = Color.Transparent;
            labelQ4.BackColor = Color.Transparent;
            labelQ5.BackColor = Color.Transparent;
            pictureBoxDog.BackColor = Color.Transparent;
            pictureBoxPen.BackColor = Color.Transparent;

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
        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (UserRole)
            {
                case "Manager":
                    buttonCus.Enabled = true;
                    buttonEmp.Enabled = true;
                    buttonPet.Enabled = true;
                    buttonRep.Enabled = true;
                    break;
                case "Clerk":
                    buttonCus.Enabled = true;
                    buttonEmp.Enabled = true;
                    buttonPet.Enabled = true;
                    buttonRep.Enabled = false;
                    break;
                case "Accountant":
                    buttonCus.Enabled = false;
                    buttonEmp.Enabled = false;
                    buttonPet.Enabled = false;
                    buttonRep.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
        }
        //Exit
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Menu
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            SetActiveButton(clickedButton);
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
        //Rep
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
        private void AppAbout_Click(object sender, EventArgs e)
        {
            Introduction newform = new Introduction();
            newform.ShowDialog();
        }
        //Drag
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelQ1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelQ2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelQ3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelQ4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelQ5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxDog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBoxPen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelUser_MouseDown(object sender, MouseEventArgs e)
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

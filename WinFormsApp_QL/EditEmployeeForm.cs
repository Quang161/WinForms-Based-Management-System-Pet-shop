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

namespace WinFormsApp_QL
{
    public partial class EditEmployeeForm : Form
    {
        private string employeeID;
        public EditEmployeeForm(string employeeID, string employeeName, string permission, string password)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            textBoxIDEmp.Text = employeeID;
            textBoxEmpName.Text = employeeName;
            comboBoxPermission.Text = permission;
            textBoxPassword.Text = password;
        }
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newPermission = comboBoxPermission.Text;
            string newPassword = textBoxPassword.Text;
            string id = textBoxIDEmp.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "UPDATE EmployeeTbl SET Permission = @Permission, Password = @Password WHERE IDEmp = @IDEmp";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Permission", newPermission);
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@IDEmp", id);

                conn.Open();
                command.ExecuteNonQuery();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = textBoxIDEmp.Text;

            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "DELETE FROM EmployeeTbl WHERE IDEmp = @IDEmp";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@IDEmp", id);

                    conn.Open();
                    command.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
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

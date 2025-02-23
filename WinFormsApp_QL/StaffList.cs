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
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
            EmpLoad();
        }
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void EmpLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDEmp AS ID, NameEmp As Employee, Role, Permission, Password FROM EmployeeTBL", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;

            DataGridViewColumn editColumn = dataGridView1.Columns["Edit_Button"];

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            editColumn.HeaderCell.Style = headerStyle;

            this.dataGridView1.ScrollBars = ScrollBars.None;
            this.dataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit_Button"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string employeeID = row.Cells["ID"].Value.ToString();
                string employeeName = row.Cells["Employee"].Value.ToString();
                string permission = row.Cells["Permission"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();

                EditEmployeeForm editForm = new EditEmployeeForm(employeeID, employeeName, permission, password);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    EmpLoad();
                }
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

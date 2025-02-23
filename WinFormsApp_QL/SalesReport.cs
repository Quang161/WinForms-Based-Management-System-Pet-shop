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

using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.InteropServices;
using DocumentFormat.OpenXml.Bibliography;

namespace WinFormsApp_QL
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            BillingLoad();
            ProductLoad();
            dateTimePickerStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
        string connection = @"Server=LAPTOP-CO730HHP; Database=Petshop; Integrated Security=True; Encrypt=False";
        private void BillingLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.NameCustomer AS Customer, bt.IDBill [Bill ID], bt.Total, bt.CDate AS Date FROM CustomerTbl c JOIN BillingTbl bt ON c.IDCustomer = bt.IDCustomer;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridViewBilling.DataSource = null;
            dataGridViewBilling.DataSource = dt;

            this.dataGridViewBilling.ScrollBars = ScrollBars.None;
            this.dataGridViewBilling.MouseWheel += new MouseEventHandler(mousewheel1);

            this.dataGridViewBillingDetail.ScrollBars = ScrollBars.None;
            this.dataGridViewBillingDetail.MouseWheel += new MouseEventHandler(mousewheel2);
        }
        private void mousewheel1(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && dataGridViewBilling.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridViewBilling.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                dataGridViewBilling.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void mousewheel2(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && dataGridViewBillingDetail.FirstDisplayedScrollingRowIndex > 0)
            {
                dataGridViewBillingDetail.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                dataGridViewBillingDetail.FirstDisplayedScrollingRowIndex++;
            }
        }
        private void ProductLoad()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NameProduct AS Product, Type, Quantity, Price FROM ProductTbl;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridViewBillingDetail.DataSource = null;
            dataGridViewBillingDetail.DataSource = dt;
        }
        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerStart.Value.Date;
            DateTime toDate = dateTimePickerEnd.Value.Date;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT IDBill AS [Bill ID],CDate AS Date, Total FROM BillingTbl WHERE CDate >= @StartDate AND CDate <= @EndDate";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@StartDate", fromDate);
                command.Parameters.AddWithValue("@EndDate", toDate);

                DataTable filteredData = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(filteredData);
                decimal totalRevenue = filteredData.AsEnumerable().Sum(row => row.Field<decimal>("Total"));

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("RevenueReport");
                    worksheet.Range("A1:C1").Merge();
                    worksheet.Range("A2:B2").Merge();
                    worksheet.Column(1).Width = 130 / 7.0;
                    worksheet.Column(2).Width = 80 / 7.0;
                    worksheet.Column(3).Width = 80 / 7.0;
                    worksheet.Column("C").Style.NumberFormat.Format = "#,##0.000";
                    worksheet.Style.Font.FontColor = XLColor.IndigoDye;

                    var titleCell = worksheet.Cell(1, 1);
                    titleCell.Value = "Sales Report";
                    titleCell.Style.Font.Bold = true;
                    titleCell.Style.Font.FontSize = 18;
                    titleCell.Style.Font.FontName = "Arial";
                    titleCell.Style.Fill.BackgroundColor = XLColor.Pink;
                    titleCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    var createDateCell = worksheet.Cell(2, 1);
                    createDateCell.Value = "Create day:";
                    createDateCell.Style.Font.Bold = true;
                    createDateCell.Style.Font.FontSize = 14;
                    createDateCell.Style.Font.FontName = "Arial";
                    createDateCell.Style.Fill.BackgroundColor = XLColor.Pink;
                    createDateCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    var createDateValueCell = worksheet.Cell(2, 3);
                    createDateValueCell.Value = DateTime.Now.ToString("dd-MM-yyyy");
                    createDateValueCell.Style.Font.Bold = true;
                    createDateValueCell.Style.Font.FontSize = 12;
                    createDateValueCell.Style.Font.FontName = "Arial";
                    createDateValueCell.Style.Fill.BackgroundColor = XLColor.Pink;
                    createDateValueCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                    var dataTableRange = worksheet.Cell(4, 1).InsertTable(filteredData);

                    dataTableRange.Theme = XLTableTheme.TableStyleMedium3;
                    foreach (var cell in dataTableRange.Cells())
                    {
                        cell.Style.Font.FontSize = 12;
                        cell.Style.Font.FontName = "Arial";
                        cell.Style.Fill.BackgroundColor = XLColor.Pink;
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    }

                    var totalRevenueCell = worksheet.Cell(filteredData.Rows.Count + 6, 1);
                    totalRevenueCell.Value = "Total Revenue:";
                    totalRevenueCell.Style.Font.Bold = true;
                    totalRevenueCell.Style.Font.FontSize = 14;
                    totalRevenueCell.Style.Font.FontName = "Arial";
                    totalRevenueCell.Style.Fill.BackgroundColor = XLColor.Pink;
                    totalRevenueCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    var totalRevenueValueCell = worksheet.Cell(filteredData.Rows.Count + 6, 2);
                    totalRevenueValueCell.Value = totalRevenue;
                    totalRevenueValueCell.Style.Font.Bold = true;
                    totalRevenueValueCell.Style.Font.FontSize = 12;
                    totalRevenueValueCell.Style.Font.FontName = "Arial";
                    totalRevenueValueCell.Style.Fill.BackgroundColor = XLColor.Pink;
                    totalRevenueValueCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                    totalRevenueValueCell.Style.NumberFormat.Format = "#,##0.000";


                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                        saveFileDialog.DefaultExt = ".xlsx";
                        string defaultFileName = $"RevenueReport_{fromDate:dd-MM-yyyy}_{toDate:dd-MM-yyyy}.xlsx";
                        saveFileDialog.FileName = defaultFileName;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Sales report generated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerStart.Value.Date;
            DateTime toDate = dateTimePickerEnd.Value.Date;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT c.NameCustomer AS Customer, bt.IDBill AS [Bill ID], Total, CDate AS Date FROM CustomerTbl c JOIN BillingTbl bt ON c.IDCustomer = bt.IDCustomer WHERE CDate >= @StartDate AND CDate <= @EndDate";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@StartDate", fromDate);
                command.Parameters.AddWithValue("@EndDate", toDate);

                DataTable filteredData = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(filteredData);
                dataGridViewBilling.DataSource = null;
                dataGridViewBilling.DataSource = filteredData;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BillingLoad();
        }
        private DataTable GetProductSalesData(DateTime startDate, DateTime endDate, string productName, string typeProduct)
        {
            DataTable dt = new DataTable();
            string query = @"
                    SELECT p.NameProduct AS Product, 
                           SUM(bd.Quantity) AS [Total Sold],
                           SUM(bd.Quantity * p.Price) AS [Total Revenue]
                    FROM BillingDetail bd
                    JOIN BillingTbl b ON bd.IDBill = b.IDBill
                    JOIN ProductTbl p ON bd.IDProduct = p.IDProduct
                    WHERE b.CDate BETWEEN @StartDate AND @EndDate
                      AND p.NameProduct LIKE @Product
                      AND p.Type LIKE @Type
                    GROUP BY p.NameProduct, p.Type";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@Product", productName);
                    cmd.Parameters.AddWithValue("@Type", typeProduct);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        private void dataGridViewBillingDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBillingDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBillingDetail.SelectedRows[0];

                ProductName.Text = selectedRow.Cells["Product"].Value.ToString();
                TypeProduct.Text = selectedRow.Cells["Type"].Value.ToString();
            }
        }
        private DataTable GetBillingData(DateTime startDate, DateTime endDate, string productName, string typeProduct)
        {
            DataTable dt = new DataTable();
            string query = @"
                        SELECT c.NameCustomer AS Customer, b.IDBill AS [Bill ID], b.Total, b.CDate AS Date, p.NameProduct AS ProductName, p.Type AS TypeProduct
                        FROM CustomerTbl c
                        JOIN BillingTbl b ON c.IDCustomer = b.IDCustomer
                        JOIN BillingDetail bd ON b.IDBill = bd.IDBill
                        JOIN ProductTbl p ON bd.IDProduct = p.IDProduct
                        WHERE b.CDate BETWEEN @StartDate AND @EndDate
                        AND p.NameProduct LIKE @ProductName
                        AND p.Type LIKE @TypeProduct;";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@TypeProduct", typeProduct);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;
            string productName = ProductName.Text;
            string typeProduct = TypeProduct.SelectedItem.ToString();

            DataTable billingData = GetBillingData(fromDate, toDate, productName, typeProduct);
            DataTable productSalesData = GetProductSalesData(fromDate, toDate, productName, typeProduct);

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Revenue Report");

                var billingTable = worksheet.Cell(1, 1).InsertTable(billingData, "BillingData", true);
                billingTable.Theme = XLTableTheme.TableStyleMedium9;

                var productSalesTable = worksheet.Cell(billingData.Rows.Count + 3, 1).InsertTable(productSalesData, "ProductSalesData", true);
                productSalesTable.Theme = XLTableTheme.TableStyleMedium9;

                worksheet.Columns().Width = 12.56;

                worksheet.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                worksheet.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.DefaultExt = ".xlsx";
                    string defaultFileName = $"SalesReport_{productName}_{fromDate:dd_MM_yyyy}_{toDate:dd_MM_yyyy}.xlsx";
                    saveFileDialog.FileName = defaultFileName;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        workbook.SaveAs(filePath);
                        MessageBox.Show("Sales report generated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

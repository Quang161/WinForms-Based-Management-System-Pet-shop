namespace WinFormsApp_QL
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInvoice = new Label();
            labelCustomer = new Label();
            labelBill = new Label();
            lblTotalPrice = new Label();
            lblCustomerName = new Label();
            lstProducts = new ListBox();
            labelEmployee = new Label();
            lblEmployeeName = new Label();
            labelDate = new Label();
            labelDateTime = new Label();
            labelQ = new Label();
            labelN = new Label();
            labelA = new Label();
            labelU = new Label();
            labelD = new Label();
            label0 = new Label();
            labelT = new Label();
            labelTP = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelInvoice
            // 
            labelInvoice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelInvoice.AutoSize = true;
            labelInvoice.Font = new Font("Courier New", 24F, FontStyle.Bold);
            labelInvoice.ForeColor = Color.Black;
            labelInvoice.Location = new Point(511, 9);
            labelInvoice.Name = "labelInvoice";
            labelInvoice.Size = new Size(284, 46);
            labelInvoice.TabIndex = 0;
            labelInvoice.Text = "Sale Recipt";
            labelInvoice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            labelCustomer.ForeColor = Color.Black;
            labelCustomer.Location = new Point(15, 110);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(170, 27);
            labelCustomer.TabIndex = 1;
            labelCustomer.Text = "Customer Name:";
            // 
            // labelBill
            // 
            labelBill.AutoSize = true;
            labelBill.Font = new Font("Courier New", 12F);
            labelBill.ForeColor = Color.Black;
            labelBill.Location = new Point(560, 680);
            labelBill.Name = "labelBill";
            labelBill.Size = new Size(106, 22);
            labelBill.TabIndex = 3;
            labelBill.Text = "SubTotal";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Courier New", 12F);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(680, 680);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(46, 22);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "...";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Courier New", 12F);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(180, 115);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(46, 22);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "...";
            // 
            // lstProducts
            // 
            lstProducts.BackColor = Color.White;
            lstProducts.BorderStyle = BorderStyle.None;
            lstProducts.Cursor = Cursors.Hand;
            lstProducts.Font = new Font("Courier New", 13.8F);
            lstProducts.ForeColor = Color.Black;
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 25;
            lstProducts.Location = new Point(12, 209);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(770, 450);
            lstProducts.TabIndex = 8;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            labelEmployee.ForeColor = Color.Black;
            labelEmployee.Location = new Point(445, 110);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(168, 27);
            labelEmployee.TabIndex = 9;
            labelEmployee.Text = "Employee Name:";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Courier New", 12F);
            lblEmployeeName.ForeColor = Color.Black;
            lblEmployeeName.Location = new Point(610, 115);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(46, 22);
            lblEmployeeName.TabIndex = 10;
            lblEmployeeName.Text = "...";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(15, 75);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(62, 27);
            labelDate.TabIndex = 11;
            labelDate.Text = "Date:";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Courier New", 12F);
            labelDateTime.ForeColor = Color.Black;
            labelDateTime.Location = new Point(75, 80);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(46, 22);
            labelDateTime.TabIndex = 12;
            labelDateTime.Text = "...";
            // 
            // labelQ
            // 
            labelQ.AutoSize = true;
            labelQ.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQ.ForeColor = Color.Black;
            labelQ.Location = new Point(32, 160);
            labelQ.Name = "labelQ";
            labelQ.Size = new Size(70, 37);
            labelQ.TabIndex = 13;
            labelQ.Text = "QTY";
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelN.ForeColor = Color.Black;
            labelN.Location = new Point(164, 160);
            labelN.Name = "labelN";
            labelN.Size = new Size(221, 37);
            labelN.TabIndex = 14;
            labelN.Text = "Products Name";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelA.ForeColor = Color.Black;
            labelA.Location = new Point(670, 160);
            labelA.Name = "labelA";
            labelA.Size = new Size(125, 37);
            labelA.TabIndex = 15;
            labelA.Text = "Amount";
            // 
            // labelU
            // 
            labelU.AutoSize = true;
            labelU.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelU.ForeColor = Color.Black;
            labelU.Location = new Point(445, 160);
            labelU.Name = "labelU";
            labelU.Size = new Size(148, 37);
            labelU.TabIndex = 16;
            labelU.Text = "Unit Price";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Courier New", 12F);
            labelD.ForeColor = Color.Black;
            labelD.Location = new Point(560, 720);
            labelD.Name = "labelD";
            labelD.Size = new Size(106, 22);
            labelD.TabIndex = 17;
            labelD.Text = "Discount";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Courier New", 12F);
            label0.ForeColor = Color.Black;
            label0.Location = new Point(680, 720);
            label0.Name = "label0";
            label0.Size = new Size(34, 22);
            label0.TabIndex = 18;
            label0.Text = "No";
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            labelT.ForeColor = Color.SeaGreen;
            labelT.Location = new Point(590, 765);
            labelT.Name = "labelT";
            labelT.Size = new Size(73, 29);
            labelT.TabIndex = 19;
            labelT.Text = "Total";
            // 
            // labelTP
            // 
            labelTP.AutoSize = true;
            labelTP.Font = new Font("Courier New", 13.8F, FontStyle.Bold);
            labelTP.ForeColor = Color.SeaGreen;
            labelTP.Location = new Point(680, 770);
            labelTP.Name = "labelTP";
            labelTP.Size = new Size(54, 27);
            labelTP.TabIndex = 20;
            labelTP.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-5, 140);
            label1.Name = "label1";
            label1.Size = new Size(819, 20);
            label1.TabIndex = 21;
            label1.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-5, 186);
            label2.Name = "label2";
            label2.Size = new Size(819, 20);
            label2.TabIndex = 22;
            label2.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 746);
            label3.Name = "label3";
            label3.Size = new Size(249, 20);
            label3.TabIndex = 23;
            label3.Text = "________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-5, 646);
            label4.Name = "label4";
            label4.Size = new Size(819, 20);
            label4.TabIndex = 24;
            label4.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(807, 803);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelTP);
            Controls.Add(labelT);
            Controls.Add(label0);
            Controls.Add(labelD);
            Controls.Add(labelU);
            Controls.Add(labelA);
            Controls.Add(labelN);
            Controls.Add(labelQ);
            Controls.Add(labelDateTime);
            Controls.Add(labelDate);
            Controls.Add(lblEmployeeName);
            Controls.Add(labelEmployee);
            Controls.Add(lstProducts);
            Controls.Add(lblCustomerName);
            Controls.Add(lblTotalPrice);
            Controls.Add(labelBill);
            Controls.Add(labelCustomer);
            Controls.Add(labelInvoice);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            FormClosing += Invoice_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInvoice;
        private Label labelCustomer;
        private Label labelBill;
        private Label lblTotalPrice;
        private Label lblCustomerName;
        private ListBox lstProducts;
        private Label labelEmployee;
        private Label lblEmployeeName;
        private Label labelDate;
        private Label labelDateTime;
        private Label labelQ;
        private Label labelN;
        private Label labelA;
        private Label labelU;
        private Label labelD;
        private Label label0;
        private Label labelT;
        private Label labelTP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
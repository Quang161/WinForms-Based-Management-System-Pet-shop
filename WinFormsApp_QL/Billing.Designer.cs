namespace WinFormsApp_QL
{
    partial class Billing
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            groupBox1 = new GroupBox();
            buttonClear = new Button();
            labelTotal = new Label();
            TxtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            buttonBillPrint = new Button();
            groupBox2 = new GroupBox();
            buttonFindClear = new Button();
            buttonFind = new Button();
            NameCustomer = new TextBox();
            labelCusName = new Label();
            IDCustomer = new TextBox();
            labelCusID = new Label();
            Availabletxt = new TextBox();
            Available = new Label();
            Quantity = new Label();
            ItemName = new TextBox();
            numericUpDown1 = new NumericUpDown();
            labelItemName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            AddToBill = new Button();
            groupBox5 = new GroupBox();
            comboBoxEmp = new ComboBox();
            labelEmpName = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(labelTotal);
            groupBox1.Controls.Add(TxtTotal);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(buttonBillPrint);
            groupBox1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(1020, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 923);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // buttonClear
            // 
            buttonClear.AutoSize = true;
            buttonClear.BackColor = Color.FromArgb(222, 111, 161);
            buttonClear.BackgroundImageLayout = ImageLayout.None;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.LavenderBlush;
            buttonClear.Location = new Point(20, 864);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(175, 48);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.LavenderBlush;
            labelTotal.Location = new Point(566, 870);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(90, 38);
            labelTotal.TabIndex = 22;
            labelTotal.Text = "Total:";
            // 
            // TxtTotal
            // 
            TxtTotal.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTotal.Location = new Point(662, 874);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(170, 34);
            TxtTotal.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepPink;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightPink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightPink;
            dataGridView1.Location = new Point(20, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightPink;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 52;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(812, 803);
            dataGridView1.TabIndex = 20;
            // 
            // buttonBillPrint
            // 
            buttonBillPrint.Anchor = AnchorStyles.None;
            buttonBillPrint.AutoSize = true;
            buttonBillPrint.BackColor = Color.FromArgb(222, 111, 161);
            buttonBillPrint.Cursor = Cursors.Hand;
            buttonBillPrint.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonBillPrint.FlatAppearance.BorderSize = 0;
            buttonBillPrint.FlatStyle = FlatStyle.Flat;
            buttonBillPrint.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBillPrint.ForeColor = Color.LavenderBlush;
            buttonBillPrint.Location = new Point(201, 864);
            buttonBillPrint.Name = "buttonBillPrint";
            buttonBillPrint.Size = new Size(173, 48);
            buttonBillPrint.TabIndex = 18;
            buttonBillPrint.Text = "Print Bill";
            buttonBillPrint.UseVisualStyleBackColor = false;
            buttonBillPrint.Click += buttonBillPrint_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(buttonFindClear);
            groupBox2.Controls.Add(buttonFind);
            groupBox2.Controls.Add(NameCustomer);
            groupBox2.Controls.Add(labelCusName);
            groupBox2.Controls.Add(IDCustomer);
            groupBox2.Controls.Add(labelCusID);
            groupBox2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            groupBox2.ForeColor = Color.LavenderBlush;
            groupBox2.Location = new Point(20, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 165);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer";
            // 
            // buttonFindClear
            // 
            buttonFindClear.BackColor = Color.FromArgb(222, 111, 161);
            buttonFindClear.Cursor = Cursors.Hand;
            buttonFindClear.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonFindClear.FlatAppearance.BorderSize = 0;
            buttonFindClear.FlatStyle = FlatStyle.Flat;
            buttonFindClear.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonFindClear.ForeColor = Color.LavenderBlush;
            buttonFindClear.Location = new Point(166, 122);
            buttonFindClear.Name = "buttonFindClear";
            buttonFindClear.Size = new Size(162, 40);
            buttonFindClear.TabIndex = 24;
            buttonFindClear.Text = "Clear";
            buttonFindClear.UseVisualStyleBackColor = false;
            buttonFindClear.Click += buttonFindClear_Click;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.FromArgb(222, 111, 161);
            buttonFind.Cursor = Cursors.Hand;
            buttonFind.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonFind.FlatAppearance.BorderSize = 0;
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonFind.ForeColor = Color.LavenderBlush;
            buttonFind.Location = new Point(2, 122);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(166, 40);
            buttonFind.TabIndex = 23;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // NameCustomer
            // 
            NameCustomer.Location = new Point(175, 75);
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Size = new Size(136, 30);
            NameCustomer.TabIndex = 21;
            // 
            // labelCusName
            // 
            labelCusName.AutoSize = true;
            labelCusName.Location = new Point(20, 75);
            labelCusName.Name = "labelCusName";
            labelCusName.Size = new Size(148, 23);
            labelCusName.TabIndex = 20;
            labelCusName.Text = "Customer Name";
            // 
            // IDCustomer
            // 
            IDCustomer.Location = new Point(175, 30);
            IDCustomer.Name = "IDCustomer";
            IDCustomer.ReadOnly = true;
            IDCustomer.Size = new Size(136, 30);
            IDCustomer.TabIndex = 19;
            // 
            // labelCusID
            // 
            labelCusID.AutoSize = true;
            labelCusID.Location = new Point(20, 30);
            labelCusID.Name = "labelCusID";
            labelCusID.Size = new Size(117, 23);
            labelCusID.TabIndex = 18;
            labelCusID.Text = "Customer ID";
            // 
            // Availabletxt
            // 
            Availabletxt.Location = new Point(322, 75);
            Availabletxt.Name = "Availabletxt";
            Availabletxt.ReadOnly = true;
            Availabletxt.Size = new Size(65, 30);
            Availabletxt.TabIndex = 30;
            // 
            // Available
            // 
            Available.AutoSize = true;
            Available.Location = new Point(220, 75);
            Available.Name = "Available";
            Available.Size = new Size(92, 23);
            Available.TabIndex = 29;
            Available.Text = "Available:";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(20, 75);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(129, 23);
            Quantity.TabIndex = 28;
            Quantity.Text = "Item Quantity";
            // 
            // ItemName
            // 
            ItemName.Location = new Point(150, 30);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(237, 30);
            ItemName.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(150, 75);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 30);
            numericUpDown1.TabIndex = 23;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Location = new Point(20, 30);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(105, 23);
            labelItemName.TabIndex = 22;
            labelItemName.Text = "Item Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightPink;
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowLayoutPanel1.ForeColor = Color.Indigo;
            flowLayoutPanel1.Location = new Point(12, 28);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(951, 426);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Indigo;
            groupBox3.Location = new Point(20, 200);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(976, 250);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.LightPink;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DeepPink;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightPink;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Indigo;
            dataGridViewCellStyle5.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle5.SelectionForeColor = Color.MintCream;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightPink;
            dataGridView2.Location = new Point(20, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightPink;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Indigo;
            dataGridViewCellStyle6.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle6.SelectionForeColor = Color.MintCream;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(935, 204);
            dataGridView2.TabIndex = 0;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(flowLayoutPanel1);
            groupBox4.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            groupBox4.ForeColor = Color.LavenderBlush;
            groupBox4.Location = new Point(20, 470);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(976, 465);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Product And Service List";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(AddToBill);
            groupBox6.Controls.Add(ItemName);
            groupBox6.Controls.Add(numericUpDown1);
            groupBox6.Controls.Add(Quantity);
            groupBox6.Controls.Add(labelItemName);
            groupBox6.Controls.Add(Available);
            groupBox6.Controls.Add(Availabletxt);
            groupBox6.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            groupBox6.ForeColor = Color.LavenderBlush;
            groupBox6.Location = new Point(365, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(400, 165);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Product And Service";
            // 
            // AddToBill
            // 
            AddToBill.BackColor = Color.FromArgb(222, 111, 161);
            AddToBill.Cursor = Cursors.Hand;
            AddToBill.Dock = DockStyle.Bottom;
            AddToBill.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            AddToBill.FlatAppearance.BorderSize = 0;
            AddToBill.FlatStyle = FlatStyle.Flat;
            AddToBill.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            AddToBill.ForeColor = Color.LavenderBlush;
            AddToBill.Location = new Point(3, 122);
            AddToBill.Name = "AddToBill";
            AddToBill.Size = new Size(394, 40);
            AddToBill.TabIndex = 25;
            AddToBill.Text = "Add to Bill";
            AddToBill.UseVisualStyleBackColor = false;
            AddToBill.Click += BtnAddtoBill_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(comboBoxEmp);
            groupBox5.Controls.Add(labelEmpName);
            groupBox5.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            groupBox5.ForeColor = Color.LavenderBlush;
            groupBox5.Location = new Point(780, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(216, 120);
            groupBox5.TabIndex = 25;
            groupBox5.TabStop = false;
            groupBox5.Text = "Select Employee";
            // 
            // comboBoxEmp
            // 
            comboBoxEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmp.FormattingEnabled = true;
            comboBoxEmp.Location = new Point(30, 70);
            comboBoxEmp.Name = "comboBoxEmp";
            comboBoxEmp.Size = new Size(151, 31);
            comboBoxEmp.TabIndex = 19;
            // 
            // labelEmpName
            // 
            labelEmpName.AutoSize = true;
            labelEmpName.Location = new Point(30, 30);
            labelEmpName.Name = "labelEmpName";
            labelEmpName.Size = new Size(148, 23);
            labelEmpName.TabIndex = 18;
            labelEmpName.Text = "Employee Name";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1882, 953);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button buttonBillPrint;
        private GroupBox groupBox2;
        private TextBox NameCustomer;
        private Label labelCusName;
        private TextBox IDCustomer;
        private Label labelCusID;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label labelItemName;
        private NumericUpDown numericUpDown1;
        private Label Quantity;
        private TextBox ItemName;
        private TextBox Availabletxt;
        private Label Available;
        private Label labelTotal;
        private TextBox TxtTotal;
        private Button Add;
        private GroupBox groupBox6;
        private Button buttonFind;
        private Button AddToBill;
        private Button buttonClear;
        private Button buttonFindClear;
        private GroupBox groupBox5;
        private Label labelEmpName;
        private ComboBox comboBoxEmp;
    }
}
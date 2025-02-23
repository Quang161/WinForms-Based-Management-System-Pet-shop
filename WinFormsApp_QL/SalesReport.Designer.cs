namespace WinFormsApp_QL
{
    partial class SalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            groupBoxProduct = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridViewBilling = new DataGridView();
            button3 = new Button();
            groupBox3 = new GroupBox();
            dataGridViewBillingDetail = new DataGridView();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            ExportToExcel = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            TypeProduct = new ComboBox();
            label3 = new Label();
            ProductName = new TextBox();
            groupBoxProduct.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBilling).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBillingDetail).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.BackColor = Color.Transparent;
            groupBoxProduct.Controls.Add(groupBox2);
            groupBoxProduct.Controls.Add(button3);
            groupBoxProduct.Controls.Add(groupBox3);
            groupBoxProduct.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxProduct.ForeColor = Color.LavenderBlush;
            groupBoxProduct.Location = new Point(20, 10);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Size = new Size(1090, 460);
            groupBoxProduct.TabIndex = 2;
            groupBoxProduct.TabStop = false;
            groupBoxProduct.Text = "Sales Report";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(dataGridViewBilling);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(20, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 425);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // dataGridViewBilling
            // 
            dataGridViewBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBilling.BackgroundColor = Color.LightPink;
            dataGridViewBilling.BorderStyle = BorderStyle.None;
            dataGridViewBilling.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBilling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepPink;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightPink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewBilling.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBilling.EnableHeadersVisualStyles = false;
            dataGridViewBilling.GridColor = Color.LightPink;
            dataGridViewBilling.Location = new Point(0, 14);
            dataGridViewBilling.Name = "dataGridViewBilling";
            dataGridViewBilling.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightPink;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewBilling.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBilling.RowHeadersVisible = false;
            dataGridViewBilling.RowHeadersWidth = 75;
            dataGridViewBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBilling.Size = new Size(460, 410);
            dataGridViewBilling.TabIndex = 23;
            // 
            // button3
            // 
            button3.Location = new Point(84, 89);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 25;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(dataGridViewBillingDetail);
            groupBox3.Cursor = Cursors.Hand;
            groupBox3.ForeColor = Color.Indigo;
            groupBox3.Location = new Point(500, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(565, 425);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            // 
            // dataGridViewBillingDetail
            // 
            dataGridViewBillingDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBillingDetail.BackgroundColor = Color.LightPink;
            dataGridViewBillingDetail.BorderStyle = BorderStyle.None;
            dataGridViewBillingDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewBillingDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DeepPink;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewBillingDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBillingDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightPink;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Indigo;
            dataGridViewCellStyle5.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewBillingDetail.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewBillingDetail.EnableHeadersVisualStyles = false;
            dataGridViewBillingDetail.GridColor = Color.LightPink;
            dataGridViewBillingDetail.Location = new Point(0, 14);
            dataGridViewBillingDetail.Name = "dataGridViewBillingDetail";
            dataGridViewBillingDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightPink;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Indigo;
            dataGridViewCellStyle6.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewBillingDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewBillingDetail.RowHeadersVisible = false;
            dataGridViewBillingDetail.RowHeadersWidth = 60;
            dataGridViewBillingDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBillingDetail.Size = new Size(565, 410);
            dataGridViewBillingDetail.TabIndex = 24;
            dataGridViewBillingDetail.SelectionChanged += dataGridViewBillingDetail_SelectionChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd-MM-yyyy";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(25, 75);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(160, 34);
            dateTimePickerStart.TabIndex = 3;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "dd-MM-yyyy";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(295, 75);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(160, 34);
            dateTimePickerEnd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 5;
            label1.Text = "Date Start";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 35);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 6;
            label2.Text = "Date End";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(222, 111, 161);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(159, 129);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(ExportToExcel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.ForeColor = Color.LavenderBlush;
            groupBox1.Location = new Point(20, 475);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 180);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Time To Export The Vernue";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(222, 111, 161);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(0, 129);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 9;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ExportToExcel
            // 
            ExportToExcel.BackColor = Color.FromArgb(222, 111, 161);
            ExportToExcel.FlatStyle = FlatStyle.Popup;
            ExportToExcel.Location = new Point(309, 129);
            ExportToExcel.Name = "ExportToExcel";
            ExportToExcel.Size = new Size(171, 50);
            ExportToExcel.TabIndex = 8;
            ExportToExcel.Text = "Export To Excel";
            ExportToExcel.UseVisualStyleBackColor = false;
            ExportToExcel.Click += ExportToExcel_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(dateTimePicker2);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(TypeProduct);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(ProductName);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox4.ForeColor = Color.LavenderBlush;
            groupBox4.Location = new Point(520, 475);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(590, 180);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Export sold products";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(222, 111, 161);
            button4.Dock = DockStyle.Bottom;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(3, 127);
            button4.Name = "button4";
            button4.Size = new Size(584, 50);
            button4.TabIndex = 9;
            button4.Text = "Export To Excel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 85);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 7;
            label6.Text = "Date End";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 85);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 6;
            label5.Text = "Date Start";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(400, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(165, 34);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(135, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 34);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 35);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
            label4.TabIndex = 3;
            label4.Text = "Type";
            // 
            // TypeProduct
            // 
            TypeProduct.Enabled = false;
            TypeProduct.FormattingEnabled = true;
            TypeProduct.Items.AddRange(new object[] { "Food", "Toy", "Extras", "Furniture", "<--------->", "Healthcare", "Beauty", "Training" });
            TypeProduct.Location = new Point(400, 35);
            TypeProduct.Name = "TypeProduct";
            TypeProduct.Size = new Size(165, 36);
            TypeProduct.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 35);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 1;
            label3.Text = "Product Name";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(175, 35);
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Size = new Size(122, 34);
            ProductName.TabIndex = 0;
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1132, 673);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxProduct);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            groupBoxProduct.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBilling).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBillingDetail).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxProduct;
        private Button button3;
        private DataGridView dataGridViewBillingDetail;
        private DataGridView dataGridViewBilling;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Button ExportToExcel;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox ProductName;
        private ComboBox TypeProduct;
        private Button button4;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button2;
    }
}
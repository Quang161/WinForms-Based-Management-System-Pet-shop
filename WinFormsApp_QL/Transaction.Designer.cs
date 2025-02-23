namespace WinFormsApp_QL
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            label1 = new Label();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBoxCusName = new TextBox();
            ButtonSearchTransaction = new Button();
            textBoxCusID = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(331, 46);
            label1.TabIndex = 1;
            label1.Text = "Transaction History";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.LightPink;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepPink;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightPink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.LightPink;
            dataGridView2.Location = new Point(20, 80);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightPink;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(700, 405);
            dataGridView2.TabIndex = 2;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxCusName);
            groupBox2.Controls.Add(ButtonSearchTransaction);
            groupBox2.Controls.Add(textBoxCusID);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.ForeColor = Color.LavenderBlush;
            groupBox2.Location = new Point(735, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 174);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Transaction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(35, 35);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 10;
            label2.Text = "Customer";
            // 
            // textBoxCusName
            // 
            textBoxCusName.Location = new Point(30, 70);
            textBoxCusName.Name = "textBoxCusName";
            textBoxCusName.Size = new Size(148, 34);
            textBoxCusName.TabIndex = 11;
            // 
            // ButtonSearchTransaction
            // 
            ButtonSearchTransaction.BackColor = Color.FromArgb(222, 111, 161);
            ButtonSearchTransaction.Cursor = Cursors.Hand;
            ButtonSearchTransaction.Dock = DockStyle.Bottom;
            ButtonSearchTransaction.FlatStyle = FlatStyle.Popup;
            ButtonSearchTransaction.Location = new Point(3, 121);
            ButtonSearchTransaction.Name = "ButtonSearchTransaction";
            ButtonSearchTransaction.Size = new Size(227, 50);
            ButtonSearchTransaction.TabIndex = 9;
            ButtonSearchTransaction.Text = "Search Transaction";
            ButtonSearchTransaction.UseVisualStyleBackColor = false;
            ButtonSearchTransaction.Click += ButtonSearchTransaction_Click;
            // 
            // textBoxCusID
            // 
            textBoxCusID.Location = new Point(30, 70);
            textBoxCusID.Name = "textBoxCusID";
            textBoxCusID.Size = new Size(148, 34);
            textBoxCusID.TabIndex = 12;
            textBoxCusID.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DeepPink;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle4.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightPink;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.Indigo;
            dataGridViewCellStyle5.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightPink;
            dataGridView1.Location = new Point(20, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightPink;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.Indigo;
            dataGridViewCellStyle6.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 405);
            dataGridView1.TabIndex = 15;
            dataGridView1.Visible = false;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(980, 503);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Transaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private Button ButtonSearchTransaction;
        private Label label2;
        private TextBox textBoxCusName;
        private DataGridView dataGridView1;
        private TextBox textBoxCusID;
    }
}
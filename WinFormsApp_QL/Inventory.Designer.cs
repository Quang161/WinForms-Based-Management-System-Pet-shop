namespace WinFormsApp_QL
{
    partial class Inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            buttonAdd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            buttonDel = new Button();
            labelNAME = new Label();
            labelTYPE = new Label();
            labelQUAN = new Label();
            labelPRICE = new Label();
            buttonFind = new Button();
            buttonClear = new Button();
            textBoxDelete = new TextBox();
            comboBoxType = new ComboBox();
            comboBoxFind = new ComboBox();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSize = true;
            buttonAdd.BackColor = Color.HotPink;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.LavenderBlush;
            buttonAdd.Location = new Point(420, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(96, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += btnAddItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightPink;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flowLayoutPanel1.ForeColor = Color.Indigo;
            flowLayoutPanel1.Location = new Point(10, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(951, 426);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            txtName.Location = new Point(80, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 30);
            txtName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            txtQuantity.Location = new Point(290, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 30);
            txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.Hand;
            txtPrice.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            txtPrice.Location = new Point(290, 36);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 30);
            txtPrice.TabIndex = 3;
            // 
            // buttonDel
            // 
            buttonDel.AutoSize = true;
            buttonDel.BackColor = Color.HotPink;
            buttonDel.FlatStyle = FlatStyle.Popup;
            buttonDel.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonDel.ForeColor = Color.LavenderBlush;
            buttonDel.Location = new Point(12, 503);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(94, 33);
            buttonDel.TabIndex = 4;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // labelNAME
            // 
            labelNAME.AutoSize = true;
            labelNAME.BackColor = Color.Transparent;
            labelNAME.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            labelNAME.ForeColor = Color.LavenderBlush;
            labelNAME.Location = new Point(10, 5);
            labelNAME.Name = "labelNAME";
            labelNAME.Size = new Size(60, 23);
            labelNAME.TabIndex = 5;
            labelNAME.Text = "Name";
            // 
            // labelTYPE
            // 
            labelTYPE.AutoSize = true;
            labelTYPE.BackColor = Color.Transparent;
            labelTYPE.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            labelTYPE.ForeColor = Color.LavenderBlush;
            labelTYPE.Location = new Point(20, 40);
            labelTYPE.Name = "labelTYPE";
            labelTYPE.Size = new Size(50, 23);
            labelTYPE.TabIndex = 6;
            labelTYPE.Text = "Type";
            // 
            // labelQUAN
            // 
            labelQUAN.AutoSize = true;
            labelQUAN.BackColor = Color.Transparent;
            labelQUAN.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            labelQUAN.ForeColor = Color.LavenderBlush;
            labelQUAN.Location = new Point(200, 3);
            labelQUAN.Name = "labelQUAN";
            labelQUAN.Size = new Size(84, 23);
            labelQUAN.TabIndex = 7;
            labelQUAN.Text = "Quantity";
            // 
            // labelPRICE
            // 
            labelPRICE.AutoSize = true;
            labelPRICE.BackColor = Color.Transparent;
            labelPRICE.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            labelPRICE.ForeColor = Color.LavenderBlush;
            labelPRICE.Location = new Point(232, 40);
            labelPRICE.Name = "labelPRICE";
            labelPRICE.Size = new Size(52, 23);
            labelPRICE.TabIndex = 8;
            labelPRICE.Text = "Price";
            // 
            // buttonFind
            // 
            buttonFind.AutoSize = true;
            buttonFind.BackColor = Color.HotPink;
            buttonFind.FlatStyle = FlatStyle.Popup;
            buttonFind.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonFind.ForeColor = Color.LavenderBlush;
            buttonFind.Location = new Point(741, 503);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(94, 33);
            buttonFind.TabIndex = 9;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonClear
            // 
            buttonClear.AutoSize = true;
            buttonClear.BackColor = Color.HotPink;
            buttonClear.BackgroundImageLayout = ImageLayout.None;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.LavenderBlush;
            buttonClear.Location = new Point(420, 34);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(190, 38);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            textBoxDelete.Location = new Point(112, 504);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(120, 30);
            textBoxDelete.TabIndex = 11;
            // 
            // comboBoxType
            // 
            comboBoxType.Cursor = Cursors.Hand;
            comboBoxType.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Food", "Toy", "Extras", "Furniture" });
            comboBoxType.Location = new Point(80, 36);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(120, 31);
            comboBoxType.TabIndex = 13;
            // 
            // comboBoxFind
            // 
            comboBoxFind.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            comboBoxFind.FormattingEnabled = true;
            comboBoxFind.Items.AddRange(new object[] { "Food", "Toy", "Extras", "Furniture" });
            comboBoxFind.Location = new Point(841, 504);
            comboBoxFind.Name = "comboBoxFind";
            comboBoxFind.Size = new Size(120, 31);
            comboBoxFind.TabIndex = 14;
            // 
            // buttonEdit
            // 
            buttonEdit.AutoSize = true;
            buttonEdit.BackColor = Color.HotPink;
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.FlatStyle = FlatStyle.Popup;
            buttonEdit.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.LavenderBlush;
            buttonEdit.Location = new Point(514, 0);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(96, 35);
            buttonEdit.TabIndex = 15;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(973, 543);
            Controls.Add(buttonEdit);
            Controls.Add(comboBoxFind);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonFind);
            Controls.Add(labelPRICE);
            Controls.Add(labelQUAN);
            Controls.Add(labelTYPE);
            Controls.Add(labelNAME);
            Controls.Add(buttonDel);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product And Service";
            Load += Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button buttonDel;
        private Label labelNAME;
        private Label labelTYPE;
        private Label labelQUAN;
        private Label labelPRICE;
        private Button buttonFind;
        private Button buttonClear;
        private TextBox textBoxDelete;
        private ComboBox comboBoxType;
        private ComboBox comboBoxFind;
        private Button buttonEdit;
    }
}

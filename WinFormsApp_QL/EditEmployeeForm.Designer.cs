namespace WinFormsApp_QL
{
    partial class EditEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmployeeForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            label5 = new Label();
            label6 = new Label();
            textBoxIDEmp = new TextBox();
            textBoxEmpName = new TextBox();
            comboBoxPermission = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Information ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(275, 80);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Permisson";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.LavenderBlush;
            label3.Location = new Point(275, 140);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.Hand;
            textBoxPassword.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBoxPassword.Location = new Point(385, 140);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(140, 34);
            textBoxPassword.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.LavenderBlush;
            label4.Location = new Point(275, 20);
            label4.Name = "label4";
            label4.Size = new Size(257, 28);
            label4.TabIndex = 5;
            label4.Text = "Permission And Password";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(222, 111, 161);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.LavenderBlush;
            buttonSave.Location = new Point(267, 200);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(270, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(222, 111, 161);
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.LavenderBlush;
            buttonDelete.Location = new Point(0, 200);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(270, 40);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label5.ForeColor = Color.LavenderBlush;
            label5.Location = new Point(20, 80);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 8;
            label5.Text = "Empoyee ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.LavenderBlush;
            label6.Location = new Point(20, 140);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 9;
            label6.Text = "Name";
            // 
            // textBoxIDEmp
            // 
            textBoxIDEmp.Cursor = Cursors.Hand;
            textBoxIDEmp.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBoxIDEmp.Location = new Point(150, 80);
            textBoxIDEmp.Name = "textBoxIDEmp";
            textBoxIDEmp.ReadOnly = true;
            textBoxIDEmp.Size = new Size(90, 34);
            textBoxIDEmp.TabIndex = 10;
            // 
            // textBoxEmpName
            // 
            textBoxEmpName.Cursor = Cursors.Hand;
            textBoxEmpName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            textBoxEmpName.Location = new Point(90, 140);
            textBoxEmpName.Name = "textBoxEmpName";
            textBoxEmpName.ReadOnly = true;
            textBoxEmpName.Size = new Size(150, 34);
            textBoxEmpName.TabIndex = 11;
            // 
            // comboBoxPermission
            // 
            comboBoxPermission.Cursor = Cursors.Hand;
            comboBoxPermission.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            comboBoxPermission.FormattingEnabled = true;
            comboBoxPermission.Items.AddRange(new object[] { "1", "2", "3" });
            comboBoxPermission.Location = new Point(385, 80);
            comboBoxPermission.Name = "comboBoxPermission";
            comboBoxPermission.Size = new Size(140, 36);
            comboBoxPermission.TabIndex = 12;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(537, 240);
            Controls.Add(comboBoxPermission);
            Controls.Add(textBoxEmpName);
            Controls.Add(textBoxIDEmp);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label4;
        private Button buttonSave;
        private Button buttonDelete;
        private Label label5;
        private Label label6;
        private TextBox textBoxIDEmp;
        private TextBox textBoxEmpName;
        private ComboBox comboBoxPermission;
    }
}
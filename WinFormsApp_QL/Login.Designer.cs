namespace WinFormsApp_QL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            labelUserName = new Label();
            labelPass = new Label();
            textBox1 = new CustomTextBox();
            textBox2 = new CustomTextBox();
            buttonLogin = new Button();
            buttonX = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.BackColor = Color.Transparent;
            labelLogin.Font = new Font("Segoe Script", 20F, FontStyle.Bold | FontStyle.Italic);
            labelLogin.ForeColor = Color.LavenderBlush;
            labelLogin.Location = new Point(143, 55);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(126, 57);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Login";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            labelLogin.MouseDown += labelLogin_MouseDown;
            // 
            // labelUserName
            // 
            labelUserName.BackColor = Color.Transparent;
            labelUserName.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = Color.LavenderBlush;
            labelUserName.Location = new Point(69, 140);
            labelUserName.Margin = new Padding(3, 0, 3, 3);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(120, 35);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "UserName";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            labelUserName.UseCompatibleTextRendering = true;
            labelUserName.Paint += labelUserName_Paint;
            labelUserName.MouseDown += labelUserName_MouseDown;
            // 
            // labelPass
            // 
            labelPass.BackColor = Color.Transparent;
            labelPass.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            labelPass.ForeColor = Color.LavenderBlush;
            labelPass.Location = new Point(69, 251);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(120, 35);
            labelPass.TabIndex = 5;
            labelPass.Text = "PassWord";
            labelPass.TextAlign = ContentAlignment.MiddleCenter;
            labelPass.Paint += labelPass_Paint;
            labelPass.MouseDown += labelPass_MouseDown;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MintCream;
            textBox1.BorderColor = Color.PaleVioletRed;
            textBox1.BorderSize = 2;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(72, 180);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.NotHidden = true;
            textBox1.Padding = new Padding(8);
            textBox1.Size = new Size(267, 37);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MintCream;
            textBox2.BorderColor = Color.FromArgb(112, 41, 99);
            textBox2.BorderSize = 2;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(72, 291);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.NotHidden = false;
            textBox2.Padding = new Padding(8);
            textBox2.Size = new Size(267, 37);
            textBox2.TabIndex = 7;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLogin.AutoSize = true;
            buttonLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLogin.BackColor = Color.FromArgb(112, 41, 99);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.LavenderBlush;
            buttonLogin.Location = new Point(169, 350);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(81, 47);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += Login_Logout;
            // 
            // buttonX
            // 
            buttonX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonX.AutoSize = true;
            buttonX.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonX.BackColor = Color.Transparent;
            buttonX.Cursor = Cursors.Hand;
            buttonX.FlatStyle = FlatStyle.Flat;
            buttonX.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonX.ForeColor = Color.PaleVioletRed;
            buttonX.Location = new Point(372, 0);
            buttonX.Name = "buttonX";
            buttonX.Size = new Size(42, 47);
            buttonX.TabIndex = 11;
            buttonX.Text = "X";
            buttonX.UseVisualStyleBackColor = false;
            buttonX.Click += buttonX_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MintCream;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(78, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 12;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MintCream;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(78, 296);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 27);
            textBox4.TabIndex = 13;
            textBox4.UseSystemPasswordChar = true;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 424);
            ControlBox = false;
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(labelUserName);
            Controls.Add(labelPass);
            Controls.Add(buttonX);
            Controls.Add(buttonLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelLogin);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelLogin;
        private Label labelUserName;
        private Label labelPass;
        private CustomTextBox textBox1;
        private CustomTextBox textBox2;
        private Button buttonLogin;
        private Button buttonX;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
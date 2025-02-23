namespace WinFormsApp_QL
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelLoadBar = new Label();
            pictureBox2 = new PictureBox();
            labelTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelLoadBar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelTitle);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 175);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // labelLoadBar
            // 
            labelLoadBar.AutoSize = true;
            labelLoadBar.BackColor = Color.Transparent;
            labelLoadBar.Font = new Font("Segoe Print", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelLoadBar.ForeColor = Color.FromArgb(112, 41, 99);
            labelLoadBar.Location = new Point(149, 121);
            labelLoadBar.Name = "labelLoadBar";
            labelLoadBar.Size = new Size(136, 44);
            labelLoadBar.TabIndex = 3;
            labelLoadBar.Text = "Loading...";
            labelLoadBar.MouseDown += labelLoadBar_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-10, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(314, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe Print", 14F, FontStyle.Bold | FontStyle.Italic);
            labelTitle.ForeColor = Color.FromArgb(112, 41, 99);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(295, 43);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Pet store management";
            labelTitle.MouseDown += labelTitle_MouseDown;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 183, 197);
            ClientSize = new Size(294, 175);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelLoadBar;
        private Label labelTitle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

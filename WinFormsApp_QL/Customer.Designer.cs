namespace WinFormsApp_QL
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            buttonSer = new Button();
            buttonBil = new Button();
            buttonEtc = new Button();
            buttonReport = new Button();
            buttonPet = new Button();
            buttonCus = new Button();
            buttonEmp = new Button();
            buttonHome = new Button();
            panelUser = new Panel();
            labelUser = new Label();
            pictureBoxUser = new PictureBox();
            pictureBoxExit = new PictureBox();
            tabControl1 = new TabControl();
            tabPageList = new TabPage();
            button2 = new Button();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabPageManage = new TabPage();
            groupBoxEmpControl = new GroupBox();
            buttonCusPrint = new Button();
            buttonCusDelete = new Button();
            buttonCusAdd = new Button();
            buttonCusEdit = new Button();
            groupBoxCI = new GroupBox();
            textBoxCusAddress = new TextBox();
            textBoxCusPhone = new TextBox();
            labelCusAddress = new Label();
            labelCusPhone = new Label();
            groupBoxPI = new GroupBox();
            textBoxNickName = new TextBox();
            labelCusPetName = new Label();
            comboBoxCusGender = new ComboBox();
            labelCusGender = new Label();
            textBoxCusName = new TextBox();
            labelCusName = new Label();
            panelMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageManage.SuspendLayout();
            groupBoxEmpControl.SuspendLayout();
            groupBoxCI.SuspendLayout();
            groupBoxPI.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Plum;
            panelMenu.Controls.Add(buttonSer);
            panelMenu.Controls.Add(buttonBil);
            panelMenu.Controls.Add(buttonEtc);
            panelMenu.Controls.Add(buttonReport);
            panelMenu.Controls.Add(buttonPet);
            panelMenu.Controls.Add(buttonCus);
            panelMenu.Controls.Add(buttonEmp);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Controls.Add(panelUser);
            panelMenu.Dock = DockStyle.Right;
            panelMenu.ForeColor = SystemColors.ControlText;
            panelMenu.Location = new Point(733, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(183, 609);
            panelMenu.TabIndex = 4;
            // 
            // buttonSer
            // 
            buttonSer.BackColor = Color.FromArgb(181, 51, 137);
            buttonSer.Cursor = Cursors.Hand;
            buttonSer.Dock = DockStyle.Top;
            buttonSer.Enabled = false;
            buttonSer.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonSer.FlatAppearance.BorderSize = 0;
            buttonSer.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonSer.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonSer.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonSer.FlatStyle = FlatStyle.Flat;
            buttonSer.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonSer.ForeColor = Color.LavenderBlush;
            buttonSer.Image = (Image)resources.GetObject("buttonSer.Image");
            buttonSer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSer.Location = new Point(0, 487);
            buttonSer.Name = "buttonSer";
            buttonSer.Padding = new Padding(10, 0, 0, 0);
            buttonSer.Size = new Size(183, 61);
            buttonSer.TabIndex = 11;
            buttonSer.Text = " Service";
            buttonSer.TextAlign = ContentAlignment.MiddleLeft;
            buttonSer.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSer.UseVisualStyleBackColor = false;
            buttonSer.Click += buttonSer_Click;
            // 
            // buttonBil
            // 
            buttonBil.BackColor = Color.FromArgb(181, 51, 137);
            buttonBil.Cursor = Cursors.Hand;
            buttonBil.Dock = DockStyle.Top;
            buttonBil.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonBil.FlatAppearance.BorderSize = 0;
            buttonBil.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonBil.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonBil.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonBil.FlatStyle = FlatStyle.Flat;
            buttonBil.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonBil.ForeColor = Color.LavenderBlush;
            buttonBil.Image = (Image)resources.GetObject("buttonBil.Image");
            buttonBil.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBil.Location = new Point(0, 426);
            buttonBil.Name = "buttonBil";
            buttonBil.Padding = new Padding(10, 0, 0, 0);
            buttonBil.Size = new Size(183, 61);
            buttonBil.TabIndex = 10;
            buttonBil.Text = " Billing";
            buttonBil.TextAlign = ContentAlignment.MiddleLeft;
            buttonBil.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBil.UseVisualStyleBackColor = false;
            buttonBil.Click += buttonBil_Click;
            // 
            // buttonEtc
            // 
            buttonEtc.BackColor = Color.FromArgb(181, 51, 137);
            buttonEtc.Cursor = Cursors.Hand;
            buttonEtc.Dock = DockStyle.Bottom;
            buttonEtc.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.BorderSize = 0;
            buttonEtc.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonEtc.FlatStyle = FlatStyle.Flat;
            buttonEtc.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonEtc.ForeColor = Color.LavenderBlush;
            buttonEtc.Image = (Image)resources.GetObject("buttonEtc.Image");
            buttonEtc.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEtc.Location = new Point(0, 547);
            buttonEtc.Name = "buttonEtc";
            buttonEtc.Padding = new Padding(10, 0, 0, 0);
            buttonEtc.Size = new Size(183, 62);
            buttonEtc.TabIndex = 7;
            buttonEtc.Text = " Logout";
            buttonEtc.TextAlign = ContentAlignment.MiddleLeft;
            buttonEtc.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEtc.UseVisualStyleBackColor = false;
            buttonEtc.Click += buttonLogout_Click;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(181, 51, 137);
            buttonReport.Cursor = Cursors.Hand;
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonReport.ForeColor = Color.LavenderBlush;
            buttonReport.Image = (Image)resources.GetObject("buttonReport.Image");
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(0, 365);
            buttonReport.Name = "buttonReport";
            buttonReport.Padding = new Padding(10, 0, 0, 0);
            buttonReport.Size = new Size(183, 61);
            buttonReport.TabIndex = 6;
            buttonReport.Text = " Report";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += GotoRep;
            // 
            // buttonPet
            // 
            buttonPet.BackColor = Color.FromArgb(181, 51, 137);
            buttonPet.Cursor = Cursors.Hand;
            buttonPet.Dock = DockStyle.Top;
            buttonPet.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.BorderSize = 0;
            buttonPet.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonPet.FlatStyle = FlatStyle.Flat;
            buttonPet.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonPet.ForeColor = Color.LavenderBlush;
            buttonPet.Image = (Image)resources.GetObject("buttonPet.Image");
            buttonPet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPet.Location = new Point(0, 304);
            buttonPet.Name = "buttonPet";
            buttonPet.Padding = new Padding(10, 0, 0, 0);
            buttonPet.Size = new Size(183, 61);
            buttonPet.TabIndex = 5;
            buttonPet.Text = " Pet's";
            buttonPet.TextAlign = ContentAlignment.MiddleLeft;
            buttonPet.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPet.UseVisualStyleBackColor = false;
            buttonPet.Click += GotoPet;
            // 
            // buttonCus
            // 
            buttonCus.BackColor = Color.FromArgb(181, 51, 137);
            buttonCus.Cursor = Cursors.Hand;
            buttonCus.Dock = DockStyle.Top;
            buttonCus.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.BorderSize = 0;
            buttonCus.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonCus.FlatStyle = FlatStyle.Flat;
            buttonCus.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonCus.ForeColor = Color.LavenderBlush;
            buttonCus.Image = (Image)resources.GetObject("buttonCus.Image");
            buttonCus.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCus.Location = new Point(0, 243);
            buttonCus.Name = "buttonCus";
            buttonCus.Padding = new Padding(9, 0, 0, 0);
            buttonCus.Size = new Size(183, 61);
            buttonCus.TabIndex = 4;
            buttonCus.Text = " Customer";
            buttonCus.TextAlign = ContentAlignment.MiddleLeft;
            buttonCus.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCus.UseVisualStyleBackColor = false;
            buttonCus.Click += button_Click;
            // 
            // buttonEmp
            // 
            buttonEmp.BackColor = Color.FromArgb(181, 51, 137);
            buttonEmp.Cursor = Cursors.Hand;
            buttonEmp.Dock = DockStyle.Top;
            buttonEmp.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.BorderSize = 0;
            buttonEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonEmp.FlatStyle = FlatStyle.Flat;
            buttonEmp.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonEmp.ForeColor = Color.LavenderBlush;
            buttonEmp.Image = (Image)resources.GetObject("buttonEmp.Image");
            buttonEmp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmp.Location = new Point(0, 182);
            buttonEmp.Name = "buttonEmp";
            buttonEmp.Padding = new Padding(10, 0, 0, 0);
            buttonEmp.Size = new Size(183, 61);
            buttonEmp.TabIndex = 3;
            buttonEmp.Text = " Employee";
            buttonEmp.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmp.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEmp.UseVisualStyleBackColor = false;
            buttonEmp.Click += GotoEmp;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(181, 51, 137);
            buttonHome.Cursor = Cursors.Hand;
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatAppearance.CheckedBackColor = Color.FromArgb(254, 78, 218);
            buttonHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(222, 111, 161);
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonHome.ForeColor = Color.LavenderBlush;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 121);
            buttonHome.Margin = new Padding(0);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(10, 0, 0, 0);
            buttonHome.Size = new Size(183, 61);
            buttonHome.TabIndex = 2;
            buttonHome.Text = " Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += GotoHome;
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(181, 51, 137);
            panelUser.Controls.Add(labelUser);
            panelUser.Controls.Add(pictureBoxUser);
            panelUser.Controls.Add(pictureBoxExit);
            panelUser.Dock = DockStyle.Top;
            panelUser.ForeColor = SystemColors.ControlText;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(183, 121);
            panelUser.TabIndex = 1;
            panelUser.MouseDown += panel2_MouseDown;
            // 
            // labelUser
            // 
            labelUser.Cursor = Cursors.Hand;
            labelUser.Dock = DockStyle.Bottom;
            labelUser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            labelUser.ForeColor = Color.LavenderBlush;
            labelUser.Location = new Point(0, 76);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(183, 45);
            labelUser.TabIndex = 2;
            labelUser.Text = "User Name";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            labelUser.MouseDown += labelUserName_MouseDown;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Cursor = Cursors.Hand;
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(60, 9);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(66, 72);
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            pictureBoxUser.MouseDown += pictureBoxUser_MouseDown;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Cursor = Cursors.Hand;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(151, 5);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(32, 31);
            pictureBoxExit.TabIndex = 0;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Controls.Add(tabPageManage);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Historic", 11F, FontStyle.Bold);
            tabControl1.ItemSize = new Size(150, 28);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(733, 609);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 6;
            tabControl1.Tag = "";
            tabControl1.MouseDown += tabControl1_MouseDown;
            // 
            // tabPageList
            // 
            tabPageList.BackColor = Color.Transparent;
            tabPageList.BackgroundImage = (Image)resources.GetObject("tabPageList.BackgroundImage");
            tabPageList.Controls.Add(button2);
            tabPageList.Controls.Add(labelSearch);
            tabPageList.Controls.Add(textBoxSearch);
            tabPageList.Controls.Add(button1);
            tabPageList.Controls.Add(groupBox1);
            tabPageList.Cursor = Cursors.Hand;
            tabPageList.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            tabPageList.ForeColor = Color.LavenderBlush;
            tabPageList.Location = new Point(4, 32);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.RightToLeft = RightToLeft.No;
            tabPageList.Size = new Size(725, 573);
            tabPageList.TabIndex = 0;
            tabPageList.Text = " Customer List";
            tabPageList.MouseDown += tabPageList_MouseDown;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(222, 111, 161);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(617, 29);
            button2.Name = "button2";
            button2.Size = new Size(103, 31);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.Transparent;
            labelSearch.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            labelSearch.Location = new Point(4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(309, 28);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Search Customer by NickName";
            labelSearch.MouseDown += labelSearch_MouseDown;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(8, 30);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(502, 30);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.MouseDown += textBoxSearch_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(222, 111, 161);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(507, 29);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(8, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 528);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepPink;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightPink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = Color.MintCream;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightPink;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightPink;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = Color.MintCream;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(705, 499);
            dataGridView1.TabIndex = 3;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // tabPageManage
            // 
            tabPageManage.BackgroundImage = (Image)resources.GetObject("tabPageManage.BackgroundImage");
            tabPageManage.BackgroundImageLayout = ImageLayout.None;
            tabPageManage.Controls.Add(groupBoxEmpControl);
            tabPageManage.Controls.Add(groupBoxCI);
            tabPageManage.Controls.Add(groupBoxPI);
            tabPageManage.Cursor = Cursors.Hand;
            tabPageManage.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold);
            tabPageManage.ForeColor = Color.LavenderBlush;
            tabPageManage.Location = new Point(4, 32);
            tabPageManage.Name = "tabPageManage";
            tabPageManage.Padding = new Padding(3);
            tabPageManage.Size = new Size(725, 573);
            tabPageManage.TabIndex = 1;
            tabPageManage.Text = "Manage Info";
            tabPageManage.UseVisualStyleBackColor = true;
            tabPageManage.MouseDown += tabPageManage_MouseDown;
            // 
            // groupBoxEmpControl
            // 
            groupBoxEmpControl.Controls.Add(buttonCusPrint);
            groupBoxEmpControl.Controls.Add(buttonCusDelete);
            groupBoxEmpControl.Controls.Add(buttonCusAdd);
            groupBoxEmpControl.Controls.Add(buttonCusEdit);
            groupBoxEmpControl.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxEmpControl.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxEmpControl.Location = new Point(380, 320);
            groupBoxEmpControl.Name = "groupBoxEmpControl";
            groupBoxEmpControl.Size = new Size(295, 174);
            groupBoxEmpControl.TabIndex = 8;
            groupBoxEmpControl.TabStop = false;
            groupBoxEmpControl.Text = "Control";
            // 
            // buttonCusPrint
            // 
            buttonCusPrint.AutoSize = true;
            buttonCusPrint.BackColor = Color.FromArgb(222, 111, 161);
            buttonCusPrint.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCusPrint.FlatAppearance.BorderSize = 0;
            buttonCusPrint.FlatStyle = FlatStyle.Flat;
            buttonCusPrint.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonCusPrint.ForeColor = Color.LavenderBlush;
            buttonCusPrint.Location = new Point(155, 105);
            buttonCusPrint.Name = "buttonCusPrint";
            buttonCusPrint.Size = new Size(110, 45);
            buttonCusPrint.TabIndex = 14;
            buttonCusPrint.Text = "Print";
            buttonCusPrint.UseVisualStyleBackColor = false;
            buttonCusPrint.Click += buttonCusPrint_Click;
            // 
            // buttonCusDelete
            // 
            buttonCusDelete.AutoSize = true;
            buttonCusDelete.BackColor = Color.FromArgb(222, 111, 161);
            buttonCusDelete.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCusDelete.FlatAppearance.BorderSize = 0;
            buttonCusDelete.FlatStyle = FlatStyle.Flat;
            buttonCusDelete.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonCusDelete.ForeColor = Color.LavenderBlush;
            buttonCusDelete.Location = new Point(30, 105);
            buttonCusDelete.Name = "buttonCusDelete";
            buttonCusDelete.Size = new Size(110, 45);
            buttonCusDelete.TabIndex = 13;
            buttonCusDelete.Text = "Delete";
            buttonCusDelete.UseVisualStyleBackColor = false;
            buttonCusDelete.Click += buttonCusDelete_Click;
            // 
            // buttonCusAdd
            // 
            buttonCusAdd.AutoSize = true;
            buttonCusAdd.BackColor = Color.FromArgb(222, 111, 161);
            buttonCusAdd.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCusAdd.FlatAppearance.BorderSize = 0;
            buttonCusAdd.FlatStyle = FlatStyle.Flat;
            buttonCusAdd.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCusAdd.ForeColor = Color.LavenderBlush;
            buttonCusAdd.Location = new Point(30, 45);
            buttonCusAdd.Name = "buttonCusAdd";
            buttonCusAdd.Size = new Size(110, 45);
            buttonCusAdd.TabIndex = 11;
            buttonCusAdd.Text = "Add";
            buttonCusAdd.UseVisualStyleBackColor = false;
            buttonCusAdd.Click += buttonCusAdd_Click;
            // 
            // buttonCusEdit
            // 
            buttonCusEdit.AutoSize = true;
            buttonCusEdit.BackColor = Color.FromArgb(222, 111, 161);
            buttonCusEdit.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonCusEdit.FlatAppearance.BorderSize = 0;
            buttonCusEdit.FlatStyle = FlatStyle.Flat;
            buttonCusEdit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonCusEdit.ForeColor = Color.LavenderBlush;
            buttonCusEdit.Location = new Point(155, 45);
            buttonCusEdit.Name = "buttonCusEdit";
            buttonCusEdit.Size = new Size(110, 45);
            buttonCusEdit.TabIndex = 12;
            buttonCusEdit.Text = "Edit";
            buttonCusEdit.UseVisualStyleBackColor = false;
            buttonCusEdit.Click += buttonCusEdit_Click;
            // 
            // groupBoxCI
            // 
            groupBoxCI.Controls.Add(textBoxCusAddress);
            groupBoxCI.Controls.Add(textBoxCusPhone);
            groupBoxCI.Controls.Add(labelCusAddress);
            groupBoxCI.Controls.Add(labelCusPhone);
            groupBoxCI.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCI.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxCI.Location = new Point(380, 50);
            groupBoxCI.Name = "groupBoxCI";
            groupBoxCI.Size = new Size(295, 252);
            groupBoxCI.TabIndex = 7;
            groupBoxCI.TabStop = false;
            groupBoxCI.Text = "Contact Information";
            // 
            // textBoxCusAddress
            // 
            textBoxCusAddress.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxCusAddress.Location = new Point(30, 70);
            textBoxCusAddress.Multiline = true;
            textBoxCusAddress.Name = "textBoxCusAddress";
            textBoxCusAddress.Size = new Size(235, 101);
            textBoxCusAddress.TabIndex = 3;
            // 
            // textBoxCusPhone
            // 
            textBoxCusPhone.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxCusPhone.Location = new Point(30, 210);
            textBoxCusPhone.Name = "textBoxCusPhone";
            textBoxCusPhone.Size = new Size(235, 30);
            textBoxCusPhone.TabIndex = 5;
            // 
            // labelCusAddress
            // 
            labelCusAddress.AutoSize = true;
            labelCusAddress.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusAddress.Location = new Point(30, 40);
            labelCusAddress.Name = "labelCusAddress";
            labelCusAddress.Size = new Size(77, 23);
            labelCusAddress.TabIndex = 1;
            labelCusAddress.Text = "Address";
            // 
            // labelCusPhone
            // 
            labelCusPhone.AutoSize = true;
            labelCusPhone.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusPhone.Location = new Point(30, 180);
            labelCusPhone.Name = "labelCusPhone";
            labelCusPhone.Size = new Size(64, 23);
            labelCusPhone.TabIndex = 4;
            labelCusPhone.Text = "Phone";
            // 
            // groupBoxPI
            // 
            groupBoxPI.Controls.Add(textBoxNickName);
            groupBoxPI.Controls.Add(labelCusPetName);
            groupBoxPI.Controls.Add(comboBoxCusGender);
            groupBoxPI.Controls.Add(labelCusGender);
            groupBoxPI.Controls.Add(textBoxCusName);
            groupBoxPI.Controls.Add(labelCusName);
            groupBoxPI.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPI.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxPI.Location = new Point(50, 50);
            groupBoxPI.Name = "groupBoxPI";
            groupBoxPI.Size = new Size(300, 252);
            groupBoxPI.TabIndex = 6;
            groupBoxPI.TabStop = false;
            groupBoxPI.Text = "Personal Information";
            // 
            // textBoxNickName
            // 
            textBoxNickName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxNickName.Location = new Point(30, 210);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(235, 30);
            textBoxNickName.TabIndex = 15;
            // 
            // labelCusPetName
            // 
            labelCusPetName.AutoSize = true;
            labelCusPetName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusPetName.Location = new Point(30, 180);
            labelCusPetName.Name = "labelCusPetName";
            labelCusPetName.Size = new Size(94, 23);
            labelCusPetName.TabIndex = 12;
            labelCusPetName.Text = "Nickname";
            // 
            // comboBoxCusGender
            // 
            comboBoxCusGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCusGender.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxCusGender.FormattingEnabled = true;
            comboBoxCusGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxCusGender.Location = new Point(30, 140);
            comboBoxCusGender.Name = "comboBoxCusGender";
            comboBoxCusGender.Size = new Size(235, 31);
            comboBoxCusGender.TabIndex = 11;
            // 
            // labelCusGender
            // 
            labelCusGender.AutoSize = true;
            labelCusGender.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusGender.Location = new Point(30, 110);
            labelCusGender.Name = "labelCusGender";
            labelCusGender.Size = new Size(72, 23);
            labelCusGender.TabIndex = 8;
            labelCusGender.Text = "Gender";
            // 
            // textBoxCusName
            // 
            textBoxCusName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxCusName.Location = new Point(30, 70);
            textBoxCusName.Name = "textBoxCusName";
            textBoxCusName.Size = new Size(235, 30);
            textBoxCusName.TabIndex = 3;
            // 
            // labelCusName
            // 
            labelCusName.AutoSize = true;
            labelCusName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusName.Location = new Point(30, 40);
            labelCusName.Name = "labelCusName";
            labelCusName.Size = new Size(60, 23);
            labelCusName.TabIndex = 1;
            labelCusName.Text = "Name";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 609);
            Controls.Add(tabControl1);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load;
            panelMenu.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            tabPageList.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageManage.ResumeLayout(false);
            groupBoxEmpControl.ResumeLayout(false);
            groupBoxEmpControl.PerformLayout();
            groupBoxCI.ResumeLayout(false);
            groupBoxCI.PerformLayout();
            groupBoxPI.ResumeLayout(false);
            groupBoxPI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonEtc;
        private Button buttonReport;
        private Button buttonPet;
        private Button buttonCus;
        private Button buttonEmp;
        private Button buttonHome;
        private Panel panelUser;
        private Label labelUser;
        private PictureBox pictureBoxUser;
        private PictureBox pictureBoxExit;
        private TabControl tabControl1;
        private TabPage tabPageList;
        private Label labelSearch;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private TabPage tabPageManage;
        private GroupBox groupBoxEmpControl;
        private Button buttonCusPrint;
        private Button buttonCusDelete;
        private Button buttonCusAdd;
        private Button buttonCusEdit;
        private GroupBox groupBoxCI;
        private TextBox textBoxCusAddress;
        private TextBox textBoxCusPhone;
        private Label labelCusAddress;
        private Label labelCusPhone;
        private GroupBox groupBoxPI;
        private ComboBox comboBoxCusGender;
        private Label labelCusGender;
        private TextBox textBoxCusName;
        private Label labelCusName;
        private Label labelCusPetName;
        private TextBox textBoxNickName;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Button buttonBil;
        private Button buttonSer;
    }
}
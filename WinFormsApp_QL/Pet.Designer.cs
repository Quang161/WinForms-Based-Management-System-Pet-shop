namespace WinFormsApp_QL
{
    partial class Pet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pet));
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
            button1 = new Button();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabPageManage = new TabPage();
            groupBoxPI = new GroupBox();
            comboBoxCustomer = new ComboBox();
            labelPetOwner = new Label();
            comboBoxPetAge = new ComboBox();
            labelCusPetAge = new Label();
            comboBoxPetGender = new ComboBox();
            labelPetGender = new Label();
            textBoxPetName = new TextBox();
            labelPetName = new Label();
            groupBoxEmpControl = new GroupBox();
            buttonEmpPrint = new Button();
            buttonEmpDelete = new Button();
            buttonEmpAdd = new Button();
            buttonEmpEdit = new Button();
            groupBoxPT = new GroupBox();
            comboBoxPetHealth = new ComboBox();
            textBoxPetCP = new TextBox();
            labelHealth = new Label();
            labelPetCP = new Label();
            comboBoxPetSpecies = new ComboBox();
            labelPetSpecies = new Label();
            panelMenu.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            tabControl1.SuspendLayout();
            tabPageList.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageManage.SuspendLayout();
            groupBoxPI.SuspendLayout();
            groupBoxEmpControl.SuspendLayout();
            groupBoxPT.SuspendLayout();
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
            buttonSer.TabIndex = 10;
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
            buttonBil.TabIndex = 9;
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
            buttonPet.Click += button_Click;
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
            buttonCus.Click += GotoCus;
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
            panelUser.MouseDown += panelUser_MouseDown;
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
            tabControl1.MouseDown += tabControl1_MouseDown;
            // 
            // tabPageList
            // 
            tabPageList.BackColor = Color.Transparent;
            tabPageList.BackgroundImage = (Image)resources.GetObject("tabPageList.BackgroundImage");
            tabPageList.Controls.Add(button1);
            tabPageList.Controls.Add(labelSearch);
            tabPageList.Controls.Add(textBoxSearch);
            tabPageList.Controls.Add(button2);
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
            tabPageList.Text = "Pet List";
            tabPageList.MouseDown += tabPageList_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(222, 111, 161);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(507, 29);
            button1.Name = "button1";
            button1.Size = new Size(110, 31);
            button1.TabIndex = 11;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            labelSearch.Location = new Point(4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(221, 28);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Search Pet by Species";
            labelSearch.MouseDown += labelSearch_MouseDown;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(8, 30);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(502, 30);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.MouseDown += textBoxSearch_MouseDown;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(222, 111, 161);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(617, 29);
            button2.Name = "button2";
            button2.Size = new Size(103, 31);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(8, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 528);
            groupBox1.TabIndex = 8;
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
            dataGridView1.RowHeadersWidth = 45;
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
            tabPageManage.Controls.Add(groupBoxPI);
            tabPageManage.Controls.Add(groupBoxEmpControl);
            tabPageManage.Controls.Add(groupBoxPT);
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
            // groupBoxPI
            // 
            groupBoxPI.Controls.Add(comboBoxCustomer);
            groupBoxPI.Controls.Add(labelPetOwner);
            groupBoxPI.Controls.Add(comboBoxPetAge);
            groupBoxPI.Controls.Add(labelCusPetAge);
            groupBoxPI.Controls.Add(comboBoxPetGender);
            groupBoxPI.Controls.Add(labelPetGender);
            groupBoxPI.Controls.Add(textBoxPetName);
            groupBoxPI.Controls.Add(labelPetName);
            groupBoxPI.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPI.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxPI.Location = new Point(50, 50);
            groupBoxPI.Name = "groupBoxPI";
            groupBoxPI.Size = new Size(300, 346);
            groupBoxPI.TabIndex = 15;
            groupBoxPI.TabStop = false;
            groupBoxPI.Text = "Pet Information";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20+" });
            comboBoxCustomer.Location = new Point(30, 287);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(235, 31);
            comboBoxCustomer.TabIndex = 20;
            // 
            // labelPetOwner
            // 
            labelPetOwner.AutoSize = true;
            labelPetOwner.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelPetOwner.Location = new Point(30, 256);
            labelPetOwner.Name = "labelPetOwner";
            labelPetOwner.Size = new Size(65, 23);
            labelPetOwner.TabIndex = 19;
            labelPetOwner.Text = "Owner";
            // 
            // comboBoxPetAge
            // 
            comboBoxPetAge.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPetAge.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxPetAge.FormattingEnabled = true;
            comboBoxPetAge.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20+" });
            comboBoxPetAge.Location = new Point(30, 216);
            comboBoxPetAge.Name = "comboBoxPetAge";
            comboBoxPetAge.Size = new Size(235, 31);
            comboBoxPetAge.TabIndex = 15;
            // 
            // labelCusPetAge
            // 
            labelCusPetAge.AutoSize = true;
            labelCusPetAge.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelCusPetAge.Location = new Point(30, 186);
            labelCusPetAge.Name = "labelCusPetAge";
            labelCusPetAge.Size = new Size(43, 23);
            labelCusPetAge.TabIndex = 12;
            labelCusPetAge.Text = "Age";
            // 
            // comboBoxPetGender
            // 
            comboBoxPetGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPetGender.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxPetGender.FormattingEnabled = true;
            comboBoxPetGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxPetGender.Location = new Point(30, 146);
            comboBoxPetGender.Name = "comboBoxPetGender";
            comboBoxPetGender.Size = new Size(235, 31);
            comboBoxPetGender.TabIndex = 11;
            // 
            // labelPetGender
            // 
            labelPetGender.AutoSize = true;
            labelPetGender.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelPetGender.Location = new Point(30, 116);
            labelPetGender.Name = "labelPetGender";
            labelPetGender.Size = new Size(72, 23);
            labelPetGender.TabIndex = 8;
            labelPetGender.Text = "Gender";
            // 
            // textBoxPetName
            // 
            textBoxPetName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxPetName.Location = new Point(30, 70);
            textBoxPetName.Name = "textBoxPetName";
            textBoxPetName.Size = new Size(235, 30);
            textBoxPetName.TabIndex = 3;
            // 
            // labelPetName
            // 
            labelPetName.AutoSize = true;
            labelPetName.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelPetName.Location = new Point(30, 40);
            labelPetName.Name = "labelPetName";
            labelPetName.Size = new Size(60, 23);
            labelPetName.TabIndex = 1;
            labelPetName.Text = "Name";
            // 
            // groupBoxEmpControl
            // 
            groupBoxEmpControl.Controls.Add(buttonEmpPrint);
            groupBoxEmpControl.Controls.Add(buttonEmpDelete);
            groupBoxEmpControl.Controls.Add(buttonEmpAdd);
            groupBoxEmpControl.Controls.Add(buttonEmpEdit);
            groupBoxEmpControl.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxEmpControl.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxEmpControl.Location = new Point(380, 305);
            groupBoxEmpControl.Name = "groupBoxEmpControl";
            groupBoxEmpControl.Size = new Size(295, 174);
            groupBoxEmpControl.TabIndex = 8;
            groupBoxEmpControl.TabStop = false;
            groupBoxEmpControl.Text = "Control";
            // 
            // buttonEmpPrint
            // 
            buttonEmpPrint.AutoSize = true;
            buttonEmpPrint.BackColor = Color.FromArgb(222, 111, 161);
            buttonEmpPrint.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmpPrint.FlatAppearance.BorderSize = 0;
            buttonEmpPrint.FlatStyle = FlatStyle.Flat;
            buttonEmpPrint.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonEmpPrint.ForeColor = Color.LavenderBlush;
            buttonEmpPrint.Location = new Point(155, 105);
            buttonEmpPrint.Name = "buttonEmpPrint";
            buttonEmpPrint.Size = new Size(110, 45);
            buttonEmpPrint.TabIndex = 14;
            buttonEmpPrint.Text = "Print";
            buttonEmpPrint.UseVisualStyleBackColor = false;
            buttonEmpPrint.Click += buttonEmpPrint_Click;
            // 
            // buttonEmpDelete
            // 
            buttonEmpDelete.AutoSize = true;
            buttonEmpDelete.BackColor = Color.FromArgb(222, 111, 161);
            buttonEmpDelete.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmpDelete.FlatAppearance.BorderSize = 0;
            buttonEmpDelete.FlatStyle = FlatStyle.Flat;
            buttonEmpDelete.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonEmpDelete.ForeColor = Color.LavenderBlush;
            buttonEmpDelete.Location = new Point(30, 105);
            buttonEmpDelete.Name = "buttonEmpDelete";
            buttonEmpDelete.Size = new Size(110, 45);
            buttonEmpDelete.TabIndex = 13;
            buttonEmpDelete.Text = "Delete";
            buttonEmpDelete.UseVisualStyleBackColor = false;
            buttonEmpDelete.Click += buttonEmpDelete_Click;
            // 
            // buttonEmpAdd
            // 
            buttonEmpAdd.AutoSize = true;
            buttonEmpAdd.BackColor = Color.FromArgb(222, 111, 161);
            buttonEmpAdd.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmpAdd.FlatAppearance.BorderSize = 0;
            buttonEmpAdd.FlatStyle = FlatStyle.Flat;
            buttonEmpAdd.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEmpAdd.ForeColor = Color.LavenderBlush;
            buttonEmpAdd.Location = new Point(30, 45);
            buttonEmpAdd.Name = "buttonEmpAdd";
            buttonEmpAdd.Size = new Size(110, 45);
            buttonEmpAdd.TabIndex = 11;
            buttonEmpAdd.Text = "Add";
            buttonEmpAdd.UseVisualStyleBackColor = false;
            buttonEmpAdd.Click += buttonEmpAdd_Click;
            // 
            // buttonEmpEdit
            // 
            buttonEmpEdit.AutoSize = true;
            buttonEmpEdit.BackColor = Color.FromArgb(222, 111, 161);
            buttonEmpEdit.FlatAppearance.BorderColor = Color.FromArgb(222, 111, 161);
            buttonEmpEdit.FlatAppearance.BorderSize = 0;
            buttonEmpEdit.FlatStyle = FlatStyle.Flat;
            buttonEmpEdit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            buttonEmpEdit.ForeColor = Color.LavenderBlush;
            buttonEmpEdit.Location = new Point(155, 45);
            buttonEmpEdit.Name = "buttonEmpEdit";
            buttonEmpEdit.Size = new Size(110, 45);
            buttonEmpEdit.TabIndex = 12;
            buttonEmpEdit.Text = "Edit";
            buttonEmpEdit.UseVisualStyleBackColor = false;
            buttonEmpEdit.Click += buttonEmpEdit_Click;
            // 
            // groupBoxPT
            // 
            groupBoxPT.Controls.Add(comboBoxPetHealth);
            groupBoxPT.Controls.Add(textBoxPetCP);
            groupBoxPT.Controls.Add(labelHealth);
            groupBoxPT.Controls.Add(labelPetCP);
            groupBoxPT.Controls.Add(comboBoxPetSpecies);
            groupBoxPT.Controls.Add(labelPetSpecies);
            groupBoxPT.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPT.ForeColor = Color.FromArgb(255, 192, 255);
            groupBoxPT.Location = new Point(380, 50);
            groupBoxPT.Name = "groupBoxPT";
            groupBoxPT.Size = new Size(295, 229);
            groupBoxPT.TabIndex = 7;
            groupBoxPT.TabStop = false;
            groupBoxPT.Text = "Pet Traits ";
            // 
            // comboBoxPetHealth
            // 
            comboBoxPetHealth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPetHealth.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxPetHealth.FormattingEnabled = true;
            comboBoxPetHealth.Items.AddRange(new object[] { "Excellent", "Good", "Fair", "Poor", "Critical" });
            comboBoxPetHealth.Location = new Point(160, 185);
            comboBoxPetHealth.Name = "comboBoxPetHealth";
            comboBoxPetHealth.Size = new Size(105, 31);
            comboBoxPetHealth.TabIndex = 21;
            // 
            // textBoxPetCP
            // 
            textBoxPetCP.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            textBoxPetCP.Location = new Point(30, 140);
            textBoxPetCP.Name = "textBoxPetCP";
            textBoxPetCP.Size = new Size(235, 30);
            textBoxPetCP.TabIndex = 20;
            // 
            // labelHealth
            // 
            labelHealth.AutoSize = true;
            labelHealth.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelHealth.Location = new Point(30, 190);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(125, 23);
            labelHealth.TabIndex = 19;
            labelHealth.Text = "Health Status";
            // 
            // labelPetCP
            // 
            labelPetCP.AutoSize = true;
            labelPetCP.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelPetCP.Location = new Point(30, 110);
            labelPetCP.Name = "labelPetCP";
            labelPetCP.Size = new Size(163, 23);
            labelPetCP.TabIndex = 17;
            labelPetCP.Text = "Color and Pattern";
            // 
            // comboBoxPetSpecies
            // 
            comboBoxPetSpecies.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            comboBoxPetSpecies.FormattingEnabled = true;
            comboBoxPetSpecies.Items.AddRange(new object[] { "Dog", "Cat", "Bird", "Fish", "Hamster", "Turtle", "Frog", "Chicken", "Duck", "Rabbit" });
            comboBoxPetSpecies.Location = new Point(30, 70);
            comboBoxPetSpecies.Name = "comboBoxPetSpecies";
            comboBoxPetSpecies.Size = new Size(235, 31);
            comboBoxPetSpecies.TabIndex = 16;
            // 
            // labelPetSpecies
            // 
            labelPetSpecies.AutoSize = true;
            labelPetSpecies.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            labelPetSpecies.Location = new Point(30, 40);
            labelPetSpecies.Name = "labelPetSpecies";
            labelPetSpecies.Size = new Size(73, 23);
            labelPetSpecies.TabIndex = 14;
            labelPetSpecies.Text = "Species";
            // 
            // Pet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 609);
            Controls.Add(tabControl1);
            Controls.Add(panelMenu);
            DoubleBuffered = true;
            Name = "Pet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet";
            Load += Pet_Load;
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
            groupBoxPI.ResumeLayout(false);
            groupBoxPI.PerformLayout();
            groupBoxEmpControl.ResumeLayout(false);
            groupBoxEmpControl.PerformLayout();
            groupBoxPT.ResumeLayout(false);
            groupBoxPT.PerformLayout();
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
        private TextBox textBoxSearch;
        private TabPage tabPageManage;
        private GroupBox groupBoxEmpControl;
        private Button buttonEmpPrint;
        private Button buttonEmpDelete;
        private Button buttonEmpAdd;
        private Button buttonEmpEdit;
        private GroupBox groupBoxPT;
        private Label labelPetSpecies;
        private ComboBox comboBoxPetSpecies;
        private Label labelPetCP;
        private Label labelHealth;
        private TextBox textBoxPetCP;
        private ComboBox comboBoxPetHealth;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBoxPI;
        private ComboBox comboBoxCustomer;
        private Label labelPetOwner;
        private ComboBox comboBoxPetAge;
        private Label labelCusPetAge;
        private ComboBox comboBoxPetGender;
        private Label labelPetGender;
        private TextBox textBoxPetName;
        private Label labelPetName;
        private Button buttonBil;
        private Button buttonSer;
    }
}
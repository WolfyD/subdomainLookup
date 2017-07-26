namespace subdomainLookup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ss_Status = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_Tools = new System.Windows.Forms.ToolStrip();
            this.btn_Start = new System.Windows.Forms.ToolStripButton();
            this.btn_Reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Save = new System.Windows.Forms.ToolStripButton();
            this.btn_Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_List = new System.Windows.Forms.ToolStripButton();
            this.btn_Google = new System.Windows.Forms.ToolStripButton();
            this.btn_Brute = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.tb_Domain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lv_Brute = new System.Windows.Forms.ListView();
            this.ch_Brute_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Brute_String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Brute_URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Pages = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_At = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Google_Subs = new System.Windows.Forms.Label();
            this.lbl_Google_Checks = new System.Windows.Forms.Label();
            this.lv_Google = new System.Windows.Forms.ListView();
            this.ch_Google_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Google_String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Google_Url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pb_List_Index = new System.Windows.Forms.ProgressBar();
            this.lbl_List_Subs = new System.Windows.Forms.Label();
            this.lbl_List_Index = new System.Windows.Forms.Label();
            this.lv_List = new System.Windows.Forms.ListView();
            this.ch_List_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_List_String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_List_Url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ss_Status.SuspendLayout();
            this.ts_Tools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc_Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_Status
            // 
            this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status});
            this.ss_Status.Location = new System.Drawing.Point(0, 471);
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(557, 22);
            this.ss_Status.TabIndex = 0;
            this.ss_Status.Text = "statusStrip1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(22, 17);
            this.lbl_Status.Text = "0|0";
            // 
            // ts_Tools
            // 
            this.ts_Tools.BackColor = System.Drawing.Color.Transparent;
            this.ts_Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Start,
            this.btn_Reset,
            this.toolStripSeparator1,
            this.btn_Save,
            this.btn_Settings,
            this.toolStripSeparator2,
            this.btn_List,
            this.btn_Google,
            this.btn_Brute});
            this.ts_Tools.Location = new System.Drawing.Point(0, 0);
            this.ts_Tools.Name = "ts_Tools";
            this.ts_Tools.Size = new System.Drawing.Size(557, 25);
            this.ts_Tools.TabIndex = 1;
            this.ts_Tools.Text = "toolStrip1";
            // 
            // btn_Start
            // 
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(80, 22);
            this.btn_Start.Text = "Start/Stop";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(55, 22);
            this.btn_Reset.Text = "Reset";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Save
            // 
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 22);
            this.btn_Save.Text = "Save Results";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(23, 22);
            this.btn_Settings.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_List
            // 
            this.btn_List.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_List.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_List.Image = ((System.Drawing.Image)(resources.GetObject("btn_List.Image")));
            this.btn_List.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(23, 22);
            this.btn_List.Text = "toolStripButton4";
            // 
            // btn_Google
            // 
            this.btn_Google.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Google.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Google.Image = ((System.Drawing.Image)(resources.GetObject("btn_Google.Image")));
            this.btn_Google.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Google.Name = "btn_Google";
            this.btn_Google.Size = new System.Drawing.Size(23, 22);
            this.btn_Google.Text = "toolStripButton4";
            // 
            // btn_Brute
            // 
            this.btn_Brute.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Brute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Brute.Image = ((System.Drawing.Image)(resources.GetObject("btn_Brute.Image")));
            this.btn_Brute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Brute.Name = "btn_Brute";
            this.btn_Brute.Size = new System.Drawing.Size(23, 22);
            this.btn_Brute.Text = "toolStripButton4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_StartStop);
            this.panel1.Controls.Add(this.tb_Domain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 35);
            this.panel1.TabIndex = 2;
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StartStop.Location = new System.Drawing.Point(470, 5);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(75, 23);
            this.btn_StartStop.TabIndex = 2;
            this.btn_StartStop.Text = "Start / Stop";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // tb_Domain
            // 
            this.tb_Domain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Domain.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_Domain.Location = new System.Drawing.Point(58, 2);
            this.tb_Domain.Name = "tb_Domain";
            this.tb_Domain.Size = new System.Drawing.Size(406, 29);
            this.tb_Domain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain: ";
            // 
            // tc_Tabs
            // 
            this.tc_Tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc_Tabs.Controls.Add(this.tabPage1);
            this.tc_Tabs.Controls.Add(this.tabPage2);
            this.tc_Tabs.Controls.Add(this.tabPage3);
            this.tc_Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Tabs.Location = new System.Drawing.Point(0, 60);
            this.tc_Tabs.Name = "tc_Tabs";
            this.tc_Tabs.SelectedIndex = 0;
            this.tc_Tabs.Size = new System.Drawing.Size(557, 411);
            this.tc_Tabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lv_Brute);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbl_Pages);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_At);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Using BruteForce";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lv_Brute
            // 
            this.lv_Brute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Brute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Brute_Id,
            this.ch_Brute_String,
            this.ch_Brute_URL});
            this.lv_Brute.FullRowSelect = true;
            this.lv_Brute.GridLines = true;
            this.lv_Brute.Location = new System.Drawing.Point(11, 74);
            this.lv_Brute.Name = "lv_Brute";
            this.lv_Brute.Size = new System.Drawing.Size(530, 305);
            this.lv_Brute.TabIndex = 5;
            this.lv_Brute.UseCompatibleStateImageBehavior = false;
            this.lv_Brute.View = System.Windows.Forms.View.Details;
            this.lv_Brute.Click += new System.EventHandler(this.lv_Brute_Click);
            this.lv_Brute.DoubleClick += new System.EventHandler(this.lv_Brute_DoubleClick);
            this.lv_Brute.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Brute_MouseClick);
            // 
            // ch_Brute_Id
            // 
            this.ch_Brute_Id.Text = "#";
            // 
            // ch_Brute_String
            // 
            this.ch_Brute_String.Text = "String";
            // 
            // ch_Brute_URL
            // 
            this.ch_Brute_URL.Text = "URL";
            this.ch_Brute_URL.Width = 400;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Existing results:";
            // 
            // lbl_Pages
            // 
            this.lbl_Pages.AutoSize = true;
            this.lbl_Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Pages.Location = new System.Drawing.Point(138, 29);
            this.lbl_Pages.Name = "lbl_Pages";
            this.lbl_Pages.Size = new System.Drawing.Size(15, 15);
            this.lbl_Pages.TabIndex = 3;
            this.lbl_Pages.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pages checked/found: ";
            // 
            // tb_At
            // 
            this.tb_At.Location = new System.Drawing.Point(138, 3);
            this.tb_At.Name = "tb_At";
            this.tb_At.Size = new System.Drawing.Size(124, 20);
            this.tb_At.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Currently at: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_Google_Subs);
            this.tabPage2.Controls.Add(this.lbl_Google_Checks);
            this.tabPage2.Controls.Add(this.lv_Google);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Using Google";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Google_Subs
            // 
            this.lbl_Google_Subs.AutoSize = true;
            this.lbl_Google_Subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Google_Subs.Location = new System.Drawing.Point(138, 29);
            this.lbl_Google_Subs.Name = "lbl_Google_Subs";
            this.lbl_Google_Subs.Size = new System.Drawing.Size(15, 15);
            this.lbl_Google_Subs.TabIndex = 8;
            this.lbl_Google_Subs.Text = "0";
            // 
            // lbl_Google_Checks
            // 
            this.lbl_Google_Checks.AutoSize = true;
            this.lbl_Google_Checks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Google_Checks.Location = new System.Drawing.Point(138, 6);
            this.lbl_Google_Checks.Name = "lbl_Google_Checks";
            this.lbl_Google_Checks.Size = new System.Drawing.Size(15, 15);
            this.lbl_Google_Checks.TabIndex = 7;
            this.lbl_Google_Checks.Text = "0";
            // 
            // lv_Google
            // 
            this.lv_Google.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Google.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Google_Id,
            this.ch_Google_String,
            this.ch_Google_Url});
            this.lv_Google.FullRowSelect = true;
            this.lv_Google.GridLines = true;
            this.lv_Google.Location = new System.Drawing.Point(11, 74);
            this.lv_Google.Name = "lv_Google";
            this.lv_Google.Size = new System.Drawing.Size(530, 305);
            this.lv_Google.TabIndex = 6;
            this.lv_Google.UseCompatibleStateImageBehavior = false;
            this.lv_Google.View = System.Windows.Forms.View.Details;
            // 
            // ch_Google_Id
            // 
            this.ch_Google_Id.Text = "#";
            // 
            // ch_Google_String
            // 
            this.ch_Google_String.Text = "String";
            // 
            // ch_Google_Url
            // 
            this.ch_Google_Url.Text = "URL";
            this.ch_Google_Url.Width = 400;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(8, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Existing results:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subdomains found: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Checks ran: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pb_List_Index);
            this.tabPage3.Controls.Add(this.lbl_List_Subs);
            this.tabPage3.Controls.Add(this.lbl_List_Index);
            this.tabPage3.Controls.Add(this.lv_List);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(549, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Using List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pb_List_Index
            // 
            this.pb_List_Index.Location = new System.Drawing.Point(185, 6);
            this.pb_List_Index.Name = "pb_List_Index";
            this.pb_List_Index.Size = new System.Drawing.Size(100, 15);
            this.pb_List_Index.TabIndex = 15;
            // 
            // lbl_List_Subs
            // 
            this.lbl_List_Subs.AutoSize = true;
            this.lbl_List_Subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_List_Subs.Location = new System.Drawing.Point(138, 29);
            this.lbl_List_Subs.Name = "lbl_List_Subs";
            this.lbl_List_Subs.Size = new System.Drawing.Size(15, 15);
            this.lbl_List_Subs.TabIndex = 14;
            this.lbl_List_Subs.Text = "0";
            // 
            // lbl_List_Index
            // 
            this.lbl_List_Index.AutoSize = true;
            this.lbl_List_Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_List_Index.Location = new System.Drawing.Point(138, 6);
            this.lbl_List_Index.Name = "lbl_List_Index";
            this.lbl_List_Index.Size = new System.Drawing.Size(15, 15);
            this.lbl_List_Index.TabIndex = 13;
            this.lbl_List_Index.Text = "0";
            // 
            // lv_List
            // 
            this.lv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_List_Id,
            this.ch_List_String,
            this.ch_List_Url});
            this.lv_List.FullRowSelect = true;
            this.lv_List.GridLines = true;
            this.lv_List.Location = new System.Drawing.Point(11, 74);
            this.lv_List.Name = "lv_List";
            this.lv_List.Size = new System.Drawing.Size(530, 305);
            this.lv_List.TabIndex = 12;
            this.lv_List.UseCompatibleStateImageBehavior = false;
            this.lv_List.View = System.Windows.Forms.View.Details;
            // 
            // ch_List_Id
            // 
            this.ch_List_Id.Text = "#";
            // 
            // ch_List_String
            // 
            this.ch_List_String.Text = "String";
            // 
            // ch_List_Url
            // 
            this.ch_List_Url.Text = "URL";
            this.ch_List_Url.Width = 400;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(8, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Existing results:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Subdomains found: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Current Index: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 493);
            this.Controls.Add(this.tc_Tabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ts_Tools);
            this.Controls.Add(this.ss_Status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ss_Status.ResumeLayout(false);
            this.ss_Status.PerformLayout();
            this.ts_Tools.ResumeLayout(false);
            this.ts_Tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tc_Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_Status;
        private System.Windows.Forms.ToolStrip ts_Tools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.TextBox tb_Domain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tc_Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lv_Brute;
        private System.Windows.Forms.ColumnHeader ch_Brute_Id;
        private System.Windows.Forms.ColumnHeader ch_Brute_String;
        private System.Windows.Forms.ColumnHeader ch_Brute_URL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Pages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_At;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_Google;
        private System.Windows.Forms.ColumnHeader ch_Google_Id;
        private System.Windows.Forms.ColumnHeader ch_Google_String;
        private System.Windows.Forms.ColumnHeader ch_Google_Url;
        private System.Windows.Forms.Label lbl_Google_Subs;
        private System.Windows.Forms.Label lbl_Google_Checks;
        private System.Windows.Forms.Label lbl_List_Subs;
        private System.Windows.Forms.Label lbl_List_Index;
        private System.Windows.Forms.ListView lv_List;
        private System.Windows.Forms.ColumnHeader ch_List_Id;
        private System.Windows.Forms.ColumnHeader ch_List_String;
        private System.Windows.Forms.ColumnHeader ch_List_Url;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pb_List_Index;
        private System.Windows.Forms.ToolStripButton btn_Start;
        private System.Windows.Forms.ToolStripButton btn_Reset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Save;
        private System.Windows.Forms.ToolStripButton btn_Settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_List;
        private System.Windows.Forms.ToolStripButton btn_Google;
        private System.Windows.Forms.ToolStripButton btn_Brute;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
    }
}


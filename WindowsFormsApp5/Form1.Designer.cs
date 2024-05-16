namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkbds = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkbtrai = new System.Windows.Forms.CheckedListBox();
            this.cchkbphai = new System.Windows.Forms.CheckedListBox();
            this.btntrai = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulifeNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnufileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufile1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btntest = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btncreat = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnmo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnthoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mnufile1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbds
            // 
            this.chkbds.FormattingEnabled = true;
            this.chkbds.Items.AddRange(new object[] {
            "sp1",
            "sp2",
            "sp3",
            "sp4"});
            this.chkbds.Location = new System.Drawing.Point(506, 303);
            this.chkbds.Name = "chkbds";
            this.chkbds.Size = new System.Drawing.Size(127, 119);
            this.chkbds.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkbtrai
            // 
            this.chkbtrai.FormattingEnabled = true;
            this.chkbtrai.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chkbtrai.Location = new System.Drawing.Point(59, 85);
            this.chkbtrai.Name = "chkbtrai";
            this.chkbtrai.Size = new System.Drawing.Size(155, 188);
            this.chkbtrai.TabIndex = 5;
            // 
            // cchkbphai
            // 
            this.cchkbphai.FormattingEnabled = true;
            this.cchkbphai.Location = new System.Drawing.Point(494, 85);
            this.cchkbphai.Name = "cchkbphai";
            this.cchkbphai.Size = new System.Drawing.Size(155, 188);
            this.cchkbphai.TabIndex = 6;
            // 
            // btntrai
            // 
            this.btntrai.Location = new System.Drawing.Point(308, 90);
            this.btntrai.Name = "btntrai";
            this.btntrai.Size = new System.Drawing.Size(75, 35);
            this.btntrai.TabIndex = 7;
            this.btntrai.Text = ">";
            this.btntrai.UseVisualStyleBackColor = true;
            this.btntrai.Click += new System.EventHandler(this.btntrai_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(308, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(308, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 35);
            this.button6.TabIndex = 9;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(308, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufileOpen,
            this.mnulifeNew,
            this.toolStripMenuItem1,
            this.mnufileExit});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(54, 30);
            this.mnufile.Text = "File";
            // 
            // mnufileOpen
            // 
            this.mnufileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnufileOpen.Image")));
            this.mnufileOpen.Name = "mnufileOpen";
            this.mnufileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnufileOpen.Size = new System.Drawing.Size(270, 34);
            this.mnufileOpen.Text = "Open";
            this.mnufileOpen.Click += new System.EventHandler(this.mnufileOpen_Click);
            // 
            // mnulifeNew
            // 
            this.mnulifeNew.Name = "mnulifeNew";
            this.mnulifeNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnulifeNew.Size = new System.Drawing.Size(270, 34);
            this.mnulifeNew.Text = "New";
            this.mnulifeNew.Click += new System.EventHandler(this.mnulifeNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnufileExit
            // 
            this.mnufileExit.Name = "mnufileExit";
            this.mnufileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnufileExit.Size = new System.Drawing.Size(270, 34);
            this.mnufileExit.Text = "Exit";
            this.mnufileExit.Click += new System.EventHandler(this.mnufileExit_Click);
            // 
            // mnufile1
            // 
            this.mnufile1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnufile1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnufile1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.exitToolStripMenuItem});
            this.mnufile1.Location = new System.Drawing.Point(0, 0);
            this.mnufile1.Name = "mnufile1";
            this.mnufile1.Size = new System.Drawing.Size(1057, 33);
            this.mnufile1.TabIndex = 11;
            this.mnufile1.Text = "File";
            this.mnufile1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnufile_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 100);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // btntest
            // 
            this.btntest.ContextMenuStrip = this.contextMenuStrip1;
            this.btntest.Location = new System.Drawing.Point(308, 39);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(115, 37);
            this.btntest.TabIndex = 13;
            this.btntest.Text = "Chuột phải";
            this.btntest.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.Location = new System.Drawing.Point(452, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "chuột phải";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(753, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 264);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btncreat
            // 
            this.btncreat.Location = new System.Drawing.Point(741, 75);
            this.btncreat.Name = "btncreat";
            this.btncreat.Size = new System.Drawing.Size(87, 33);
            this.btncreat.TabIndex = 0;
            this.btncreat.Text = "Creat";
            this.btncreat.UseVisualStyleBackColor = true;
            this.btncreat.Click += new System.EventHandler(this.btncreat_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.tsbtnmo,
            this.tsbtnthoat,
            this.toolStripLabel1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1057, 33);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 38);
            // 
            // tsbtnmo
            // 
            this.tsbtnmo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnmo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnmo.Image")));
            this.tsbtnmo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnmo.Name = "tsbtnmo";
            this.tsbtnmo.Size = new System.Drawing.Size(34, 33);
            this.tsbtnmo.Text = "toolStripButton1";
            this.tsbtnmo.Click += new System.EventHandler(this.tsbtnmo_Click);
            // 
            // tsbtnthoat
            // 
            this.tsbtnthoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnthoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnthoat.Image")));
            this.tsbtnthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnthoat.Name = "tsbtnthoat";
            this.tsbtnthoat.Size = new System.Drawing.Size(34, 33);
            this.tsbtnthoat.Text = "toolStripButton2";
            this.tsbtnthoat.Click += new System.EventHandler(this.tsbtnthoat_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(131, 33);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 33);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btncreat);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btntrai);
            this.Controls.Add(this.cchkbphai);
            this.Controls.Add(this.chkbtrai);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkbds);
            this.Controls.Add(this.mnufile1);
            this.MainMenuStrip = this.mnufile1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mnufile1.ResumeLayout(false);
            this.mnufile1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chkbds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox chkbtrai;
        private System.Windows.Forms.CheckedListBox cchkbphai;
        private System.Windows.Forms.Button btntrai;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnufileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnulifeNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnufileExit;
        private System.Windows.Forms.MenuStrip mnufile1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btncreat;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tsbtnmo;
        private System.Windows.Forms.ToolStripButton tsbtnthoat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}


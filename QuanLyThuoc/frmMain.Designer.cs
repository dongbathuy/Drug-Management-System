namespace QuanLyThuoc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccountInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrescriptionStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportDrugStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userAccountInformation1 = new QuanLyThuoc.userAccountInformation();
            this.userControlPatientStatistic1 = new QuanLyThuoc.userControlPatientStatistic();
            this.userControlImportDrugStatistic1 = new QuanLyThuoc.userControlImportDrugStatistic();
            this.userControlPrescriptionStatistic1 = new QuanLyThuoc.userControlPrescriptionStatistic();
            this.userControlImportDrug1 = new QuanLyThuoc.userControlImportDrug();
            this.userControlPrescription1 = new QuanLyThuoc.userControlPrescription();
            this.userControlProvider1 = new QuanLyThuoc.userControlProvider();
            this.userControlDrug1 = new QuanLyThuoc.userControlDrug();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccountInformation,
            this.mnuLogout});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuAccountInformation
            // 
            this.mnuAccountInformation.Image = ((System.Drawing.Image)(resources.GetObject("mnuAccountInformation.Image")));
            this.mnuAccountInformation.Name = "mnuAccountInformation";
            this.mnuAccountInformation.Size = new System.Drawing.Size(220, 26);
            this.mnuAccountInformation.Text = "Thông tin tài khoản";
            this.mnuAccountInformation.Click += new System.EventHandler(this.mnuAccountInformation_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogout.Image")));
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(220, 26);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrug,
            this.mnuProvider});
            this.sảnPhẩmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sảnPhẩmToolStripMenuItem.Image")));
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // mnuDrug
            // 
            this.mnuDrug.Image = ((System.Drawing.Image)(resources.GetObject("mnuDrug.Image")));
            this.mnuDrug.Name = "mnuDrug";
            this.mnuDrug.Size = new System.Drawing.Size(183, 26);
            this.mnuDrug.Text = "Thuốc";
            this.mnuDrug.Click += new System.EventHandler(this.mnuDrug_Click);
            // 
            // mnuProvider
            // 
            this.mnuProvider.Image = ((System.Drawing.Image)(resources.GetObject("mnuProvider.Image")));
            this.mnuProvider.Name = "mnuProvider";
            this.mnuProvider.Size = new System.Drawing.Size(183, 26);
            this.mnuProvider.Text = "Nhà cung cấp";
            this.mnuProvider.Click += new System.EventHandler(this.mnuProvider_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrescription,
            this.mnuImportDrug});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuPrescription
            // 
            this.mnuPrescription.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrescription.Image")));
            this.mnuPrescription.Name = "mnuPrescription";
            this.mnuPrescription.Size = new System.Drawing.Size(176, 26);
            this.mnuPrescription.Text = "Ra toa thuốc";
            this.mnuPrescription.Click += new System.EventHandler(this.mnuPrescription_Click);
            // 
            // mnuImportDrug
            // 
            this.mnuImportDrug.Image = ((System.Drawing.Image)(resources.GetObject("mnuImportDrug.Image")));
            this.mnuImportDrug.Name = "mnuImportDrug";
            this.mnuImportDrug.Size = new System.Drawing.Size(176, 26);
            this.mnuImportDrug.Text = "Nhập thuốc";
            this.mnuImportDrug.Click += new System.EventHandler(this.mnuImportDrug_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrescriptionStatistic,
            this.mnuImportDrugStatistic,
            this.mnuPatientStatistic});
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnuPrescriptionStatistic
            // 
            this.mnuPrescriptionStatistic.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrescriptionStatistic.Image")));
            this.mnuPrescriptionStatistic.Name = "mnuPrescriptionStatistic";
            this.mnuPrescriptionStatistic.Size = new System.Drawing.Size(258, 26);
            this.mnuPrescriptionStatistic.Text = "Thống kê thuốc đã ra toa";
            this.mnuPrescriptionStatistic.Click += new System.EventHandler(this.mnuPrescriptionStatistic_Click);
            // 
            // mnuImportDrugStatistic
            // 
            this.mnuImportDrugStatistic.Image = ((System.Drawing.Image)(resources.GetObject("mnuImportDrugStatistic.Image")));
            this.mnuImportDrugStatistic.Name = "mnuImportDrugStatistic";
            this.mnuImportDrugStatistic.Size = new System.Drawing.Size(258, 26);
            this.mnuImportDrugStatistic.Text = "Thống kê thuốc đã nhập";
            this.mnuImportDrugStatistic.Click += new System.EventHandler(this.mnuImportDrugStatistic_Click);
            // 
            // mnuPatientStatistic
            // 
            this.mnuPatientStatistic.Image = ((System.Drawing.Image)(resources.GetObject("mnuPatientStatistic.Image")));
            this.mnuPatientStatistic.Name = "mnuPatientStatistic";
            this.mnuPatientStatistic.Size = new System.Drawing.Size(258, 26);
            this.mnuPatientStatistic.Text = "Thống kê bệnh nhân";
            this.mnuPatientStatistic.Click += new System.EventHandler(this.mnuPatientStatistic_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 759);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(315, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 81);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hiệu thuốc ĐBT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userAccountInformation1
            // 
            this.userAccountInformation1.BackColor = System.Drawing.Color.SkyBlue;
            this.userAccountInformation1.Location = new System.Drawing.Point(0, 31);
            this.userAccountInformation1.Name = "userAccountInformation1";
            this.userAccountInformation1.Size = new System.Drawing.Size(1118, 757);
            this.userAccountInformation1.TabIndex = 1;
            this.userAccountInformation1.Load += new System.EventHandler(this.userAccountInformation1_Load);
            // 
            // userControlPatientStatistic1
            // 
            this.userControlPatientStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlPatientStatistic1.Location = new System.Drawing.Point(0, 31);
            this.userControlPatientStatistic1.Name = "userControlPatientStatistic1";
            this.userControlPatientStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.userControlPatientStatistic1.TabIndex = 8;
            // 
            // userControlImportDrugStatistic1
            // 
            this.userControlImportDrugStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlImportDrugStatistic1.Location = new System.Drawing.Point(0, 32);
            this.userControlImportDrugStatistic1.Name = "userControlImportDrugStatistic1";
            this.userControlImportDrugStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.userControlImportDrugStatistic1.TabIndex = 7;
            // 
            // userControlPrescriptionStatistic1
            // 
            this.userControlPrescriptionStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlPrescriptionStatistic1.Location = new System.Drawing.Point(0, 31);
            this.userControlPrescriptionStatistic1.Name = "userControlPrescriptionStatistic1";
            this.userControlPrescriptionStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.userControlPrescriptionStatistic1.TabIndex = 6;
            // 
            // userControlImportDrug1
            // 
            this.userControlImportDrug1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlImportDrug1.Location = new System.Drawing.Point(0, 31);
            this.userControlImportDrug1.Name = "userControlImportDrug1";
            this.userControlImportDrug1.Size = new System.Drawing.Size(1117, 757);
            this.userControlImportDrug1.TabIndex = 5;
            // 
            // userControlPrescription1
            // 
            this.userControlPrescription1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlPrescription1.Location = new System.Drawing.Point(0, 32);
            this.userControlPrescription1.Name = "userControlPrescription1";
            this.userControlPrescription1.Size = new System.Drawing.Size(1117, 757);
            this.userControlPrescription1.TabIndex = 4;
            // 
            // userControlProvider1
            // 
            this.userControlProvider1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlProvider1.Location = new System.Drawing.Point(1, 31);
            this.userControlProvider1.Name = "userControlProvider1";
            this.userControlProvider1.Size = new System.Drawing.Size(1117, 757);
            this.userControlProvider1.TabIndex = 3;
            // 
            // userControlDrug1
            // 
            this.userControlDrug1.BackColor = System.Drawing.Color.SkyBlue;
            this.userControlDrug1.Location = new System.Drawing.Point(0, 31);
            this.userControlDrug1.Name = "userControlDrug1";
            this.userControlDrug1.Size = new System.Drawing.Size(1117, 757);
            this.userControlDrug1.TabIndex = 2;
            this.userControlDrug1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userAccountInformation1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userControlPatientStatistic1);
            this.Controls.Add(this.userControlImportDrugStatistic1);
            this.Controls.Add(this.userControlPrescriptionStatistic1);
            this.Controls.Add(this.userControlImportDrug1);
            this.Controls.Add(this.userControlPrescription1);
            this.Controls.Add(this.userControlProvider1);
            this.Controls.Add(this.userControlDrug1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý thuốc - Đồng Bá Thùy";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountInformation;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDrug;
        private System.Windows.Forms.ToolStripMenuItem mnuProvider;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrescription;
        private System.Windows.Forms.ToolStripMenuItem mnuImportDrug;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPrescriptionStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnuImportDrugStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientStatistic;
        private userAccountInformation userAccountInformation1;
        private userControlDrug userControlDrug1;
        private userControlProvider userControlProvider1;
        private userControlPrescription userControlPrescription1;
        private userControlImportDrug userControlImportDrug1;
        private userControlPrescriptionStatistic userControlPrescriptionStatistic1;
        private userControlImportDrugStatistic userControlImportDrugStatistic1;
        private userControlPatientStatistic userControlPatientStatistic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
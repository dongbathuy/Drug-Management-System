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
            this.ucAccountInformation1 = new QuanLyThuoc.ucAccountInformation();
            this.ucPatientStatistic1 = new QuanLyThuoc.ucPatientStatistic();
            this.ucImportDrugStatistic1 = new QuanLyThuoc.ucImportDrugStatistic();
            this.ucPrescriptionStatistic1 = new QuanLyThuoc.ucPrescriptionStatistic();
            this.ucImportDrug1 = new QuanLyThuoc.ucImportDrug();
            this.ucPrescription1 = new QuanLyThuoc.ucPrescription();
            this.ucProvider1 = new QuanLyThuoc.ucProvider();
            this.ucDrug1 = new QuanLyThuoc.ucDrug();
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
            this.mnuAccountInformation.Size = new System.Drawing.Size(224, 26);
            this.mnuAccountInformation.Text = "Thông tin tài khoản";
            this.mnuAccountInformation.Click += new System.EventHandler(this.mnuAccountInformation_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Image = ((System.Drawing.Image)(resources.GetObject("mnuLogout.Image")));
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(224, 26);
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
            // ucAccountInformation1
            // 
            this.ucAccountInformation1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucAccountInformation1.Location = new System.Drawing.Point(0, 31);
            this.ucAccountInformation1.Name = "ucAccountInformation1";
            this.ucAccountInformation1.Size = new System.Drawing.Size(1118, 757);
            this.ucAccountInformation1.TabIndex = 1;
            // 
            // ucPatientStatistic1
            // 
            this.ucPatientStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucPatientStatistic1.Location = new System.Drawing.Point(0, 31);
            this.ucPatientStatistic1.Name = "ucPatientStatistic1";
            this.ucPatientStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.ucPatientStatistic1.TabIndex = 8;
            // 
            // ucImportDrugStatistic1
            // 
            this.ucImportDrugStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucImportDrugStatistic1.Location = new System.Drawing.Point(0, 32);
            this.ucImportDrugStatistic1.Name = "ucImportDrugStatistic1";
            this.ucImportDrugStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.ucImportDrugStatistic1.TabIndex = 7;
            // 
            // ucPrescriptionStatistic1
            // 
            this.ucPrescriptionStatistic1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucPrescriptionStatistic1.Location = new System.Drawing.Point(0, 31);
            this.ucPrescriptionStatistic1.Name = "ucPrescriptionStatistic1";
            this.ucPrescriptionStatistic1.Size = new System.Drawing.Size(1117, 757);
            this.ucPrescriptionStatistic1.TabIndex = 6;
            // 
            // ucImportDrug1
            // 
            this.ucImportDrug1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucImportDrug1.Location = new System.Drawing.Point(0, 31);
            this.ucImportDrug1.Name = "ucImportDrug1";
            this.ucImportDrug1.Size = new System.Drawing.Size(1117, 757);
            this.ucImportDrug1.TabIndex = 5;
            // 
            // ucPrescription1
            // 
            this.ucPrescription1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucPrescription1.Location = new System.Drawing.Point(0, 32);
            this.ucPrescription1.Name = "ucPrescription1";
            this.ucPrescription1.Size = new System.Drawing.Size(1117, 757);
            this.ucPrescription1.TabIndex = 4;
            // 
            // ucProvider1
            // 
            this.ucProvider1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucProvider1.Location = new System.Drawing.Point(1, 31);
            this.ucProvider1.Name = "ucProvider1";
            this.ucProvider1.Size = new System.Drawing.Size(1117, 757);
            this.ucProvider1.TabIndex = 3;
            // 
            // ucDrug1
            // 
            this.ucDrug1.BackColor = System.Drawing.Color.SkyBlue;
            this.ucDrug1.Location = new System.Drawing.Point(0, 31);
            this.ucDrug1.Name = "ucDrug1";
            this.ucDrug1.Size = new System.Drawing.Size(1117, 757);
            this.ucDrug1.TabIndex = 2;
            this.ucDrug1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucAccountInformation1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ucPatientStatistic1);
            this.Controls.Add(this.ucImportDrugStatistic1);
            this.Controls.Add(this.ucPrescriptionStatistic1);
            this.Controls.Add(this.ucImportDrug1);
            this.Controls.Add(this.ucPrescription1);
            this.Controls.Add(this.ucProvider1);
            this.Controls.Add(this.ucDrug1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý thuốc - Đồng Bá Thùy";
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
        private ucAccountInformation ucAccountInformation1;
        private ucDrug ucDrug1;
        private ucProvider ucProvider1;
        private ucPrescription ucPrescription1;
        private ucImportDrug ucImportDrug1;
        private ucPrescriptionStatistic ucPrescriptionStatistic1;
        private ucImportDrugStatistic ucImportDrugStatistic1;
        private ucPatientStatistic ucPatientStatistic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
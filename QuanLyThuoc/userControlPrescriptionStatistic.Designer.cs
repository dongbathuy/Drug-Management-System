namespace QuanLyThuoc
{
    partial class userControlPrescriptionStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlPrescriptionStatistic));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.dgvPrescriptionStatistic = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.cbFind);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbFind);
            this.groupBox2.Location = new System.Drawing.Point(31, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 74);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightCyan;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(963, 28);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 36);
            this.btnExport.TabIndex = 45;
            this.btnExport.Text = "Xuất file";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.LightCyan;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(870, 28);
            this.btnAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(85, 36);
            this.btnAll.TabIndex = 44;
            this.btnAll.Text = "Tất cả";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbFind
            // 
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Tên thuốc",
            "ĐVT",
            "Số lượng",
            "Mã hóa đơn"});
            this.cbFind.Location = new System.Drawing.Point(413, 38);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(201, 24);
            this.cbFind.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txbFind
            // 
            this.txbFind.Location = new System.Drawing.Point(9, 40);
            this.txbFind.Margin = new System.Windows.Forms.Padding(4);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(397, 22);
            this.txbFind.TabIndex = 41;
            this.txbFind.TextChanged += new System.EventHandler(this.txbFind_TextChanged);
            // 
            // dgvPrescriptionStatistic
            // 
            this.dgvPrescriptionStatistic.AllowUserToAddRows = false;
            this.dgvPrescriptionStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrescriptionStatistic.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrescriptionStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionStatistic.Location = new System.Drawing.Point(31, 133);
            this.dgvPrescriptionStatistic.Name = "dgvPrescriptionStatistic";
            this.dgvPrescriptionStatistic.RowHeadersWidth = 51;
            this.dgvPrescriptionStatistic.RowTemplate.Height = 24;
            this.dgvPrescriptionStatistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptionStatistic.Size = new System.Drawing.Size(1055, 611);
            this.dgvPrescriptionStatistic.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(298, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 40);
            this.label1.TabIndex = 51;
            this.label1.Text = "Bảng thống kê thuốc đã ra toa";
            // 
            // userControlPrescriptionStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPrescriptionStatistic);
            this.Controls.Add(this.label1);
            this.Name = "userControlPrescriptionStatistic";
            this.Size = new System.Drawing.Size(1117, 757);
            this.Load += new System.EventHandler(this.userControlPrescriptionStatistic_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.DataGridView dgvPrescriptionStatistic;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

namespace QuanLyThuoc
{
    partial class userControlDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlDrug));
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbDrugCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDrugEffect = new System.Windows.Forms.TextBox();
            this.txbQuantityAvailable = new System.Windows.Forms.TextBox();
            this.txbDrugUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDrugIngredient = new System.Windows.Forms.TextBox();
            this.txbDrugName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDrugID = new System.Windows.Forms.Label();
            this.txbDrugID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvListDrugs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightCyan;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(993, 26);
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
            this.btnAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.Image")));
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(900, 26);
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
            "Mã thuốc",
            "Tên thuốc",
            "Thành phần thuốc",
            "Tác dụng của thuốc",
            "ĐVT",
            "Số lượng hiện có",
            "Giá thuốc"});
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
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tìm kiếm thuốc:";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnAll);
            this.groupBox2.Controls.Add(this.cbFind);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbFind);
            this.groupBox2.Location = new System.Drawing.Point(16, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 80);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // txbDrugCost
            // 
            this.txbDrugCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugCost.Location = new System.Drawing.Point(734, 136);
            this.txbDrugCost.Name = "txbDrugCost";
            this.txbDrugCost.Size = new System.Drawing.Size(343, 27);
            this.txbDrugCost.TabIndex = 40;
            this.txbDrugCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDrugCost_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDrugCost);
            this.groupBox1.Controls.Add(this.txbDrugEffect);
            this.groupBox1.Controls.Add(this.txbQuantityAvailable);
            this.groupBox1.Controls.Add(this.txbDrugUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbDrugIngredient);
            this.groupBox1.Controls.Add(this.txbDrugName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDrugID);
            this.groupBox1.Controls.Add(this.txbDrugID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(16, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 231);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            // 
            // txbDrugEffect
            // 
            this.txbDrugEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugEffect.Location = new System.Drawing.Point(734, 20);
            this.txbDrugEffect.Name = "txbDrugEffect";
            this.txbDrugEffect.Size = new System.Drawing.Size(343, 27);
            this.txbDrugEffect.TabIndex = 41;
            // 
            // txbQuantityAvailable
            // 
            this.txbQuantityAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantityAvailable.Location = new System.Drawing.Point(734, 97);
            this.txbQuantityAvailable.Name = "txbQuantityAvailable";
            this.txbQuantityAvailable.Size = new System.Drawing.Size(343, 27);
            this.txbQuantityAvailable.TabIndex = 39;
            this.txbQuantityAvailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantityAvailable_KeyPress);
            // 
            // txbDrugUnit
            // 
            this.txbDrugUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugUnit.Location = new System.Drawing.Point(734, 60);
            this.txbDrugUnit.Name = "txbDrugUnit";
            this.txbDrugUnit.Size = new System.Drawing.Size(343, 27);
            this.txbDrugUnit.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "ĐVT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tác dụng thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số lượng hiện có:";
            // 
            // txbDrugIngredient
            // 
            this.txbDrugIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugIngredient.Location = new System.Drawing.Point(167, 104);
            this.txbDrugIngredient.Multiline = true;
            this.txbDrugIngredient.Name = "txbDrugIngredient";
            this.txbDrugIngredient.Size = new System.Drawing.Size(343, 64);
            this.txbDrugIngredient.TabIndex = 12;
            // 
            // txbDrugName
            // 
            this.txbDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugName.Location = new System.Drawing.Point(167, 60);
            this.txbDrugName.Name = "txbDrugName";
            this.txbDrugName.Size = new System.Drawing.Size(343, 27);
            this.txbDrugName.TabIndex = 14;
            this.txbDrugName.TextChanged += new System.EventHandler(this.txbDrugName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thành phần thuốc:";
            // 
            // lblDrugID
            // 
            this.lblDrugID.AutoSize = true;
            this.lblDrugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugID.Location = new System.Drawing.Point(6, 27);
            this.lblDrugID.Name = "lblDrugID";
            this.lblDrugID.Size = new System.Drawing.Size(83, 20);
            this.lblDrugID.TabIndex = 1;
            this.lblDrugID.Text = "Mã thuốc:";
            // 
            // txbDrugID
            // 
            this.txbDrugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrugID.Location = new System.Drawing.Point(167, 20);
            this.txbDrugID.Name = "txbDrugID";
            this.txbDrugID.Size = new System.Drawing.Size(343, 27);
            this.txbDrugID.TabIndex = 13;
            this.txbDrugID.TextChanged += new System.EventHandler(this.txbDrugID_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(992, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 36);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightCyan;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(899, 188);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 36);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "    Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên thuốc:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCyan;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(806, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvListDrugs
            // 
            this.dgvListDrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDrugs.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDrugs.Location = new System.Drawing.Point(16, 359);
            this.dgvListDrugs.Name = "dgvListDrugs";
            this.dgvListDrugs.RowHeadersWidth = 51;
            this.dgvListDrugs.RowTemplate.Height = 24;
            this.dgvListDrugs.Size = new System.Drawing.Size(1084, 385);
            this.dgvListDrugs.TabIndex = 51;
            this.dgvListDrugs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDrugs_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(444, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 41);
            this.label1.TabIndex = 50;
            this.label1.Text = "Kho Thuốc";
            // 
            // userControlDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListDrugs);
            this.Controls.Add(this.label1);
            this.Name = "userControlDrug";
            this.Size = new System.Drawing.Size(1117, 757);
            this.Load += new System.EventHandler(this.userControlDrug_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbDrugCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDrugEffect;
        private System.Windows.Forms.TextBox txbQuantityAvailable;
        private System.Windows.Forms.TextBox txbDrugUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDrugIngredient;
        private System.Windows.Forms.TextBox txbDrugName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDrugID;
        private System.Windows.Forms.TextBox txbDrugID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvListDrugs;
        private System.Windows.Forms.Label label1;
    }
}

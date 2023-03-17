namespace QuanLyThuoc
{
    partial class ucImportDrug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucImportDrug));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvListImportDrug = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbDrugID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDrugIngredient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDrugEffect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDrugUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDrugCost = new System.Windows.Forms.TextBox();
            this.cbProvider = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbImportID = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbDrugName = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtImportDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImportDrug)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txbTotalPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dgvListImportDrug);
            this.groupBox2.Location = new System.Drawing.Point(9, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1102, 327);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(827, 302);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Tổng tiền:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(902, 297);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(182, 22);
            this.txbTotalPrice.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(478, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 72;
            this.label11.Text = "Danh sách thuốc";
            // 
            // dgvListImportDrug
            // 
            this.dgvListImportDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListImportDrug.BackgroundColor = System.Drawing.Color.White;
            this.dgvListImportDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListImportDrug.Location = new System.Drawing.Point(18, 43);
            this.dgvListImportDrug.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListImportDrug.MultiSelect = false;
            this.dgvListImportDrug.Name = "dgvListImportDrug";
            this.dgvListImportDrug.RowHeadersWidth = 51;
            this.dgvListImportDrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListImportDrug.Size = new System.Drawing.Size(1066, 246);
            this.dgvListImportDrug.TabIndex = 71;
            this.dgvListImportDrug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListImportDrug_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(965, 701);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 31);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Hủy hóa đơn";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCyan;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(829, 701);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 31);
            this.btnSave.TabIndex = 76;
            this.btnSave.Text = "Lưu hóa đơn";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "Mã thuốc:";
            // 
            // txbDrugID
            // 
            this.txbDrugID.Location = new System.Drawing.Point(146, 32);
            this.txbDrugID.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugID.Name = "txbDrugID";
            this.txbDrugID.Size = new System.Drawing.Size(394, 22);
            this.txbDrugID.TabIndex = 85;
            this.txbDrugID.TextChanged += new System.EventHandler(this.txbDrugID_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(986, 208);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 36);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "  Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCyan;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(893, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 36);
            this.btnAdd.TabIndex = 83;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Thành phần thuốc: ";
            // 
            // txbDrugIngredient
            // 
            this.txbDrugIngredient.Location = new System.Drawing.Point(146, 122);
            this.txbDrugIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugIngredient.Multiline = true;
            this.txbDrugIngredient.Name = "txbDrugIngredient";
            this.txbDrugIngredient.Size = new System.Drawing.Size(394, 71);
            this.txbDrugIngredient.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tác dụng thuốc:";
            // 
            // txbDrugEffect
            // 
            this.txbDrugEffect.Location = new System.Drawing.Point(691, 32);
            this.txbDrugEffect.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugEffect.Name = "txbDrugEffect";
            this.txbDrugEffect.Size = new System.Drawing.Size(380, 22);
            this.txbDrugEffect.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "ĐVT:";
            // 
            // txbDrugUnit
            // 
            this.txbDrugUnit.Location = new System.Drawing.Point(691, 76);
            this.txbDrugUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugUnit.Name = "txbDrugUnit";
            this.txbDrugUnit.Size = new System.Drawing.Size(380, 22);
            this.txbDrugUnit.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Số lượng nhập:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(691, 125);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(380, 22);
            this.txbQuantity.TabIndex = 64;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Giá:";
            // 
            // txbDrugCost
            // 
            this.txbDrugCost.Location = new System.Drawing.Point(691, 174);
            this.txbDrugCost.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugCost.Name = "txbDrugCost";
            this.txbDrugCost.Size = new System.Drawing.Size(380, 22);
            this.txbDrugCost.TabIndex = 62;
            this.txbDrugCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDrugCost_KeyPress);
            // 
            // cbProvider
            // 
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(390, 85);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(378, 24);
            this.cbProvider.TabIndex = 93;
            this.cbProvider.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbProvider_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Tên thuốc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 91;
            this.label9.Text = "Nhà cung cấp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(869, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 90;
            this.label10.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // txbImportID
            // 
            this.txbImportID.Enabled = false;
            this.txbImportID.Location = new System.Drawing.Point(101, 48);
            this.txbImportID.Margin = new System.Windows.Forms.Padding(4);
            this.txbImportID.Name = "txbImportID";
            this.txbImportID.Size = new System.Drawing.Size(209, 22);
            this.txbImportID.TabIndex = 88;
            // 
            // txbDrugName
            // 
            this.txbDrugName.Location = new System.Drawing.Point(146, 73);
            this.txbDrugName.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugName.Name = "txbDrugName";
            this.txbDrugName.Size = new System.Drawing.Size(394, 22);
            this.txbDrugName.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txbDrugID);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbDrugIngredient);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbDrugEffect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbDrugUnit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbDrugCost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbDrugName);
            this.groupBox1.Location = new System.Drawing.Point(9, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 249);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            // 
            // dtImportDate
            // 
            this.dtImportDate.CustomFormat = "dd/MM/yyyy";
            this.dtImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtImportDate.Location = new System.Drawing.Point(958, 48);
            this.dtImportDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtImportDate.Name = "dtImportDate";
            this.dtImportDate.Size = new System.Drawing.Size(153, 22);
            this.dtImportDate.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(378, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 41);
            this.label1.TabIndex = 86;
            this.label1.Text = "Hóa đơn nhập thuốc";
            // 
            // userControlImportDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbProvider);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbImportID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtImportDate);
            this.Controls.Add(this.label1);
            this.Name = "userControlImportDrug";
            this.Size = new System.Drawing.Size(1117, 757);
            this.Load += new System.EventHandler(this.userControlImportDrug_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListImportDrug)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvListImportDrug;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbDrugID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDrugIngredient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDrugEffect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDrugUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDrugCost;
        private System.Windows.Forms.ComboBox cbProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbImportID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbDrugName;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtImportDate;
        private System.Windows.Forms.Label label1;
    }
}

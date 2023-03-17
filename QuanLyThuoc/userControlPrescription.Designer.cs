namespace QuanLyThuoc
{
    partial class userControlPrescription
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userControlPrescription));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtPrescriptionDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDiagnostic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPatientDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPatientAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrescriptionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.GroupBox();
            this.txbDrugUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDirection = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.cbDrugName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvListSoldDrug = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSoldDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 9);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtPrescriptionDate);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txbPrescriptionID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gr);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.txbTotalPrice);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.dgvListSoldDrug);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1106, 739);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 2;
            // 
            // dtPrescriptionDate
            // 
            this.dtPrescriptionDate.CustomFormat = "dd/MM/yyyy";
            this.dtPrescriptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPrescriptionDate.Location = new System.Drawing.Point(930, 60);
            this.dtPrescriptionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtPrescriptionDate.Name = "dtPrescriptionDate";
            this.dtPrescriptionDate.Size = new System.Drawing.Size(153, 22);
            this.dtPrescriptionDate.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDiagnostic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtPatientDateBirth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbPatientPhoneNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbPatientAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbPatientName);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bênh nhân";
            // 
            // txbDiagnostic
            // 
            this.txbDiagnostic.Location = new System.Drawing.Point(108, 111);
            this.txbDiagnostic.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiagnostic.Multiline = true;
            this.txbDiagnostic.Name = "txbDiagnostic";
            this.txbDiagnostic.Size = new System.Drawing.Size(963, 111);
            this.txbDiagnostic.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Chuẩn đoán :";
            // 
            // dtPatientDateBirth
            // 
            this.dtPatientDateBirth.CustomFormat = "dd/MM/yyyy";
            this.dtPatientDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPatientDateBirth.Location = new System.Drawing.Point(107, 69);
            this.dtPatientDateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtPatientDateBirth.Name = "dtPatientDateBirth";
            this.dtPatientDateBirth.Size = new System.Drawing.Size(276, 22);
            this.dtPatientDateBirth.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Ngày sinh :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Số điện thoại :";
            // 
            // txbPatientPhoneNumber
            // 
            this.txbPatientPhoneNumber.Location = new System.Drawing.Point(794, 33);
            this.txbPatientPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txbPatientPhoneNumber.MaxLength = 10;
            this.txbPatientPhoneNumber.Name = "txbPatientPhoneNumber";
            this.txbPatientPhoneNumber.Size = new System.Drawing.Size(276, 22);
            this.txbPatientPhoneNumber.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Địa chỉ :";
            // 
            // txbPatientAddress
            // 
            this.txbPatientAddress.Location = new System.Drawing.Point(794, 69);
            this.txbPatientAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txbPatientAddress.Name = "txbPatientAddress";
            this.txbPatientAddress.Size = new System.Drawing.Size(276, 22);
            this.txbPatientAddress.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Họ tên :";
            // 
            // txbPatientName
            // 
            this.txbPatientName.Location = new System.Drawing.Point(107, 31);
            this.txbPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txbPatientName.Name = "txbPatientName";
            this.txbPatientName.Size = new System.Drawing.Size(276, 22);
            this.txbPatientName.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày ra toa :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã hóa đơn :";
            // 
            // txbPrescriptionID
            // 
            this.txbPrescriptionID.Enabled = false;
            this.txbPrescriptionID.Location = new System.Drawing.Point(120, 57);
            this.txbPrescriptionID.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrescriptionID.Name = "txbPrescriptionID";
            this.txbPrescriptionID.Size = new System.Drawing.Size(182, 22);
            this.txbPrescriptionID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(365, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 41);
            this.label1.TabIndex = 24;
            this.label1.Text = "Hóa đơn ra toa thuốc";
            // 
            // gr
            // 
            this.gr.Controls.Add(this.txbDrugUnit);
            this.gr.Controls.Add(this.label13);
            this.gr.Controls.Add(this.btnDelete);
            this.gr.Controls.Add(this.btnAdd);
            this.gr.Controls.Add(this.label6);
            this.gr.Controls.Add(this.label5);
            this.gr.Controls.Add(this.txbDirection);
            this.gr.Controls.Add(this.txbQuantity);
            this.gr.Controls.Add(this.cbDrugName);
            this.gr.Location = new System.Drawing.Point(17, 266);
            this.gr.Margin = new System.Windows.Forms.Padding(4);
            this.gr.Name = "gr";
            this.gr.Padding = new System.Windows.Forms.Padding(4);
            this.gr.Size = new System.Drawing.Size(1066, 96);
            this.gr.TabIndex = 45;
            this.gr.TabStop = false;
            this.gr.Text = "Thêm thuốc vào hóa đơn";
            // 
            // txbDrugUnit
            // 
            this.txbDrugUnit.Location = new System.Drawing.Point(187, 57);
            this.txbDrugUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txbDrugUnit.Name = "txbDrugUnit";
            this.txbDrugUnit.Size = new System.Drawing.Size(90, 22);
            this.txbDrugUnit.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 26);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Hướng dẫn";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(993, 20);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 57);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCyan;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(910, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 57);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Số lượng - ĐVT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tên thuốc";
            // 
            // txbDirection
            // 
            this.txbDirection.Location = new System.Drawing.Point(366, 23);
            this.txbDirection.Margin = new System.Windows.Forms.Padding(4);
            this.txbDirection.Multiline = true;
            this.txbDirection.Name = "txbDirection";
            this.txbDirection.Size = new System.Drawing.Size(539, 56);
            this.txbDirection.TabIndex = 46;
            // 
            // txbQuantity
            // 
            this.txbQuantity.Location = new System.Drawing.Point(124, 57);
            this.txbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(55, 22);
            this.txbQuantity.TabIndex = 44;
            this.txbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantity_KeyPress);
            // 
            // cbDrugName
            // 
            this.cbDrugName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrugName.FormattingEnabled = true;
            this.cbDrugName.Location = new System.Drawing.Point(93, 23);
            this.cbDrugName.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrugName.Name = "cbDrugName";
            this.cbDrugName.Size = new System.Drawing.Size(184, 24);
            this.cbDrugName.TabIndex = 43;
            this.cbDrugName.SelectedIndexChanged += new System.EventHandler(this.cbDrugName_SelectedIndexChanged);
            this.cbDrugName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDrugName_MouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(956, 370);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 31);
            this.btnCancel.TabIndex = 75;
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
            this.btnSave.Location = new System.Drawing.Point(820, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 31);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Lưu hóa đơn";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(826, 245);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Tổng tiền:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(901, 240);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(182, 22);
            this.txbTotalPrice.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(477, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "Danh sách thuốc";
            // 
            // dgvListSoldDrug
            // 
            this.dgvListSoldDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSoldDrug.BackgroundColor = System.Drawing.Color.White;
            this.dgvListSoldDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSoldDrug.Location = new System.Drawing.Point(17, 34);
            this.dgvListSoldDrug.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListSoldDrug.MultiSelect = false;
            this.dgvListSoldDrug.Name = "dgvListSoldDrug";
            this.dgvListSoldDrug.RowHeadersWidth = 51;
            this.dgvListSoldDrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSoldDrug.Size = new System.Drawing.Size(1066, 200);
            this.dgvListSoldDrug.TabIndex = 44;
            this.dgvListSoldDrug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSoldDrug_CellClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // userControlPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.splitContainer1);
            this.Name = "userControlPrescription";
            this.Size = new System.Drawing.Size(1117, 741);
            this.Load += new System.EventHandler(this.userControlPrescription_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr.ResumeLayout(false);
            this.gr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSoldDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtPrescriptionDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbDiagnostic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPatientDateBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbPatientPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPatientAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPrescriptionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDirection;
        private System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.ComboBox cbDrugName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvListSoldDrug;
        private System.Windows.Forms.TextBox txbDrugUnit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

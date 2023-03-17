using System;
using System.Windows.Forms;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc {
    public partial class frmMain : Form, IReset {
        public frmMain() {
            InitializeComponent();
        }

        public void Reset() {
/*            ucAccountInformation1.Visible = false;
            ucDrug1.Visible = false;
            ucImportDrug1.Visible = false;
            ucImportDrugStatistic1.Visible = false;
            ucPrescription1.Visible = false;
            ucProvider1.Visible = false;
            ucPrescriptionStatistic1.Visible = false;
            ucPatientStatistic1.Visible = false;*/
        }

        private void mnuAccountInformation_Click(object sender, EventArgs e) {
            Reset();
            ucAccountInformation1.BringToFront();
            ucAccountInformation1.Visible = true;
        }

        private void mnuDrug_Click(object sender, EventArgs e) {
            Reset();
            ucDrug1.BringToFront();
            ucDrug1.Visible = true;
        }

        private void mnuProvider_Click(object sender, EventArgs e) {
            Reset();
            ucProvider1.BringToFront();
            ucProvider1.Visible = true;
        }

        private void mnuPrescription_Click(object sender, EventArgs e) {
            Reset();
            ucPrescription1.BringToFront();
            ucPrescription1.Visible = true;
        }

        private void mnuImportDrug_Click(object sender, EventArgs e) {
            Reset();
            ucImportDrug1.BringToFront();
            ucImportDrug1.Visible = true;
        }

        private void mnuPrescriptionStatistic_Click(object sender, EventArgs e) {
            Reset();
            ucPrescriptionStatistic1.BringToFront();
            ucPrescriptionStatistic1.Visible = true;
        }

        private void mnuImportDrugStatistic_Click(object sender, EventArgs e) {
            Reset();
            ucImportDrugStatistic1.BringToFront();
            ucImportDrugStatistic1.Visible = true;
        }

        private void mnuPatientStatistic_Click(object sender, EventArgs e) {
            Reset();
            ucPatientStatistic1.BringToFront();
            ucPatientStatistic1.Visible = true;
        }

        private void mnuLogout_Click(object sender, EventArgs e) {
            frmLogIn f = new frmLogIn();
            f.Show();
            this.Close();
        }
    }
}

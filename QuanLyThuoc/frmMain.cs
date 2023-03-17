using System;
using System.Windows.Forms;
using QuanLyThuoc.CreateOrReset;

namespace QuanLyThuoc
{
    public partial class frmMain : Form, IReset
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            userAccountInformation1.Visible = false;
            userControlDrug1.Visible = false;
            userControlImportDrug1.Visible = false;
            userControlImportDrugStatistic1.Visible = false;
            userControlPrescription1.Visible = false;
            userControlProvider1.Visible = false;
            userControlPrescriptionStatistic1.Visible = false;
            userControlPatientStatistic1.Visible = false;
        }

        private void mnuAccountInformation_Click(object sender, EventArgs e)
        {
            Reset();
            userAccountInformation1.BringToFront();
            userAccountInformation1.Visible = true;
        }

        private void mnuDrug_Click(object sender, EventArgs e)
        {
            Reset();
            userControlDrug1.BringToFront();
            userControlDrug1.Visible = true;
        }

        private void mnuProvider_Click(object sender, EventArgs e)
        {
            Reset();
            userControlProvider1.BringToFront();
            userControlProvider1.Visible = true;
        }

        private void mnuPrescription_Click(object sender, EventArgs e)
        {
            Reset();
            userControlPrescription1.BringToFront();
            userControlPrescription1.Visible = true;
        }

        private void mnuImportDrug_Click(object sender, EventArgs e)
        {
            Reset();
            userControlImportDrug1.BringToFront();
            userControlImportDrug1.Visible = true;  
        }

        private void mnuPrescriptionStatistic_Click(object sender, EventArgs e)
        {
            Reset();
            userControlPrescriptionStatistic1.BringToFront();
            userControlPrescriptionStatistic1.Visible = true;
        }

        private void mnuImportDrugStatistic_Click(object sender, EventArgs e)
        {
            Reset();
            userControlImportDrugStatistic1.BringToFront();
            userControlImportDrugStatistic1.Visible = true;
        }

        private void mnuPatientStatistic_Click(object sender, EventArgs e)
        {
            Reset();
            userControlPatientStatistic1.BringToFront();
            userControlPatientStatistic1.Visible = true;
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            frmLogIn f = new frmLogIn();
            f.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Reset();
        }

        private void userAccountInformation1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

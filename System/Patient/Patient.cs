using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuoc {
    class Patient {
        #region Fields
        private string prescriptionID; // Mã hóa đơn
        private string prescriptionDate; // Ngày ra toa
        private string patientName; // Tên bệnh nhân
        private string patientPhoneNumber; // SĐT bệnh nhân
        private string patientDateBirth; // Ngày sinh
        private string patientAddress;// Địa chỉ
        private string diagnostic;  // Chuẩn đoán
        #endregion
        #region Properties
        public string PrescriptionID { get => prescriptionID; set => prescriptionID = value; }
        public string PrescriptionDate { get => prescriptionDate; set => prescriptionDate = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientPhoneNumber { get => patientPhoneNumber; set => patientPhoneNumber = value; }
        public string PatientDateBirth { get => patientDateBirth; set => patientDateBirth = value; }
        public string PatientAddress { get => patientAddress; set => patientAddress = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        #endregion
        #region Constructor
        public Patient(string iPrescriptionID, string iPrescriptionDate, string iPatientName, string iPatientPhoneNumber
            , string iPatientDateBirth, string iPatientAddress, string iDiagnostic) {
            this.PrescriptionID = iPrescriptionID;
            this.PrescriptionDate = iPrescriptionDate;
            this.PatientName = iPatientName;
            this.PatientPhoneNumber = iPatientPhoneNumber;
            this.PatientDateBirth = iPatientDateBirth;
            this.PatientAddress = iPatientAddress;
            this.Diagnostic = iDiagnostic;
        }
        #endregion
    }
}

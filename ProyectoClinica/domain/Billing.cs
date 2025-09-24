using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Billing
    {
        private ulong billingID;
        private ulong patientID;
        private string patientName;
        private int patientAge;
        private ulong patientDocument;
        private string doctorName;
        private string insuranceCompany;
        private ulong policyNumber;
        private int policyDaysRemaining;
        private DateTime policyExpiration;

        private List<BillingItem> items = new List<BillingItem>();

        private double totalCost;
        private double copay;

        public ulong BillingID { get => billingID; set => billingID = value; }
        public ulong PatientID { get => patientID; set => patientID = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public int PatientAge { get => patientAge; set => patientAge = value; }
        public ulong PatientDocument { get => patientDocument; set => patientDocument = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string InsuranceCompany { get => insuranceCompany; set => insuranceCompany = value; }
        public ulong PolicyNumber { get => policyNumber; set => policyNumber = value; }
        public int PolicyDaysRemaining { get => policyDaysRemaining; set => policyDaysRemaining = value; }
        public DateTime PolicyExpiration { get => policyExpiration; set => policyExpiration = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public double Copay { get => copay; set => copay = value; }
        internal List<BillingItem> Items { get => items; set => items = value; }
    }
}

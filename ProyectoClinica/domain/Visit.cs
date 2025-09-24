using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Visit
    {
        private ulong visitID;
        private ulong patientID;
        private ulong nurseID;
        private DateTime visitDate;
        private VitalSigns vitalSigns;
        private string notes;

        public ulong VisitID { get => visitID; set => visitID = value; }
        public ulong PatientID { get => patientID; set => patientID = value; }
        public ulong NurseID { get => nurseID; set => nurseID = value; }
        public DateTime VisitDate { get => visitDate; set => visitDate = value; }
        public string Notes { get => notes; set => notes = value; }
        internal VitalSigns VitalSigns { get => vitalSigns; set => vitalSigns = value; }
    }
}

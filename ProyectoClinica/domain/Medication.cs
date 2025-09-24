using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Medication
    {
        private ulong medicationID;
        private string medicationName;
        private string medicationDescription;
        private double unitCost;

        public ulong MedicationID { get => medicationID; set => medicationID = value; }
        public string MedicationName { get => medicationName; set => medicationName = value; }
        public string MedicationDescription { get => medicationDescription; set => medicationDescription = value; }
        public double UnitCost { get => unitCost; set => unitCost = value; }
    }
}

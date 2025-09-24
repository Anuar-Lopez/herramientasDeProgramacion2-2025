using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Order
    {
        private ulong orderNumber;
        private ulong patientID;
        private ulong doctorID;
        private DateTime creationDate;
        private int itemNumber;

        public ulong OrderNumber { get => orderNumber; set => orderNumber = value; }
        public ulong PatientID { get => patientID; set => patientID = value; }
        public ulong DoctorID { get => doctorID; set => doctorID = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public int ItemNumber { get => itemNumber; set => itemNumber = value; }
    }
}

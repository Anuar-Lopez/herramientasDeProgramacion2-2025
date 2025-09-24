using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class MedicalHistory
    {
        private DateTime attentionDate;
        private ulong doctorID;
        private string reasonConsultation;
        private string symptomatology;
        private string diagnosis;

        public DateTime AttentionDate { get => attentionDate; set => attentionDate = value; }
        public ulong MedicalID { get => doctorID; set => doctorID = value; }
        public string ReasonConsultation { get => reasonConsultation; set => reasonConsultation = value; }
        public string Symptomatology { get => symptomatology; set => symptomatology = value; }
        public string Diagnosis { get => diagnosis; set => diagnosis = value; }
        public ulong DoctorID { get => doctorID; set => doctorID = value; }
    }
}

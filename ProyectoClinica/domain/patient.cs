using ProyectoClinica.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class patient : Person
    {
        private ulong idPatient;
        private string gender;
        private medical_insurance medical_insurance;
        private emergencyContact emergencyContact;

        public ulong IdPatient { get => idPatient; set => idPatient = value; }
        public string Gender { get => gender; set => gender = value; }
        internal medical_insurance Medical_insurance { get => medical_insurance; set => medical_insurance = value; }
        internal emergencyContact EmergencyContact { get => emergencyContact; set => emergencyContact = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Medication_Order : Order
    {
        private Medication medication;
        private string dosage;
        private string duration;
        

     
        public string Dosage { get => dosage; set => dosage = value; }
        public string Duration { get => duration; set => duration = value; }
        internal Medication Medication { get => medication; set => medication = value; }
    }
}

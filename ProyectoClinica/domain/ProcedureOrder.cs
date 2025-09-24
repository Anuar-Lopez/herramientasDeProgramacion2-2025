using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class ProcedureOrder : Order
    {
        private Procedure procedure;
        private int repetitions;
        private string frecuency;
        private ulong specialistID;

       
     
        public ulong SpecialistID { get => SpecialistID; set => SpecialistID = value; }
        public int Repetitions { get => repetitions; set => repetitions = value; }
        public string Frecuency { get => frecuency; set => frecuency = value; }
        internal Procedure Procedure { get => procedure; set => procedure = value; }
    }
}

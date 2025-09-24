using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class DiagnosticHelpOrder
    {
        private DiagnosticTest diagnosticTest;
        private ulong specialistID;

        public ulong SpecialistID { get => specialistID; set => specialistID = value; }
        internal DiagnosticTest DiagnosticTest { get => diagnosticTest; set => diagnosticTest = value; }
    }
}

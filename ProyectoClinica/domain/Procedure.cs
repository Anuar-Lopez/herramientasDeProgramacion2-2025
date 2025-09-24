using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class Procedure
    {
        private ulong procedureID;
        private string procedureName;
        private string procedureDescription;
        private double unitCost;
        private bool requiresSpecialist;
        private string specialistType;

        public ulong ProcedureID { get => procedureID; set => procedureID = value; }
        public string ProcedureName { get => procedureName; set => procedureName = value; }
        public string ProcedureDescription { get => procedureDescription; set => procedureDescription = value; }
        public double UnitCost { get => unitCost; set => unitCost = value; }
        public bool RequiresSpecialist { get => requiresSpecialist; set => requiresSpecialist = value; }
        public string SpecialistType { get => specialistType; set => specialistType = value; }
    }
}

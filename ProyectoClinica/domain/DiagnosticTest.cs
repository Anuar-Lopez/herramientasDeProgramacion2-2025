using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class DiagnosticTest
    {
        private ulong testID;
        private string testName;
        private string testDescription;
        private double unitCost;
        private bool requiresSpecialist;
        private string specalistType;
        private int availableQuantity;

        public ulong TestID { get => testID; set => testID = value; }
        public string TestName { get => testName; set => testName = value; }
        public string TestDescription { get => testDescription; set => testDescription = value; }
        public double UnitCost { get => unitCost; set => unitCost = value; }
        public bool RequiresSpecialist { get => requiresSpecialist; set => requiresSpecialist = value; }
        public string SpecalistType { get => specalistType; set => specalistType = value; }
        public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain.model
{
    class emergencyContact
    {
        private string name;
        private string relationship;
        private long cellPhone;

        public string Name { get => name; set => name = value; }
        public string Relationship { get => relationship; set => relationship = value; }
        public long CellPhone { get => cellPhone; set => cellPhone = value; }
    }
}

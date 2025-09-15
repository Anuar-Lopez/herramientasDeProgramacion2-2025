using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain.model
{
    class medical_insurance
    {
        private string company;
        private long policyNumber;
        private bool status;
        private DateTime validity;

        public string Company { get => company; set => company = value; }
        public long PolicyNumber { get => policyNumber; set => policyNumber = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Validity { get => validity; set => validity = value; }
    }
}

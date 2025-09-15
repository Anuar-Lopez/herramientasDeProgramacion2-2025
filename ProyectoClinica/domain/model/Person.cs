using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain.model
{
    class Person
    {
        private ulong id;
        private string name;
        private long CellPhone;
        private long document;
        private string mail;
        private string birthDate;
        private string address;

        public Person() { }

        public ulong Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public long CellPhone1 { get => CellPhone; set => CellPhone = value; }
        public long Document { get => document; set => document = value; }
        public string Mail { get => mail; set => mail = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Address { get => address; set => address = value; }
    }
}

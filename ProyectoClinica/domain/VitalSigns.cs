using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain
{
    internal class VitalSigns
    {
        private string bloodPressure;
        private double temperature;
        private int pulse;
        private int oxygenLeve;

        public string BloodPressure { get => bloodPressure; set => bloodPressure = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public int Pulse { get => pulse; set => pulse = value; }
        public int OxygenLeve { get => oxygenLeve; set => oxygenLeve = value; }
    }
}

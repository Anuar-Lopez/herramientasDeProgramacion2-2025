using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClinica.domain.Services
{
    internal class AppointmentService
    {
        private string CreateAppointment(string patientId, string doctorId, DateTime date)
        {
            
            return $"Appointment created for patient {patientId} with doctor {doctorId} on {date}";
        }
    }
}

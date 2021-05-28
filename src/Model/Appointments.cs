using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Models
{
    public class Appointments
    {
        [Key]
        public int Appointment_Id { get; set; }
        [Display(Name = "Patients_Id")]
        public int PatientsPatient_Id { get; set; }
        public string Specialization_Required { get; set; }
        public string Doctor { get; set; }
        [Display(Name = "Appointment Date and Time")]
        public DateTime Appointment_time { get; set; }
        
    }
}
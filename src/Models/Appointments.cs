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
        [Display(Name = "Patient's Name")]
        public String Name { get; set; }

        [Display(Name = "Specialization Required")]
        public string Specialization_Required { get; set; }

        public string Doctor { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Appointment_Date { get; set; }

        [Display(Name = "Appointment Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:h:mm tt}")]
        public DateTime Appointment_Time{ get; set; }


    }
}
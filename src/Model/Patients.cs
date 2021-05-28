using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Models
{
    public class Patients
    {
        [Key]
        public int Patient_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public DateTime Date  { get; set; }
        [Display(Name = "Patient_Id")]
        public List<Appointments> Appointments { get; set; }
    }
}
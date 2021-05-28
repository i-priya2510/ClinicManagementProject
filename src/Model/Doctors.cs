using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementProject.Models
{
    public class Doctors
    {
        [Key]
        public int Doctor_Id { get; set; }
        public String FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public String Specialization { get; set; }
        [Display(Name="Available From")]
        public int VH_From { get; set; }
        [Display(Name = "Available To")]
        public int VH_To { get; set; }
    }
}
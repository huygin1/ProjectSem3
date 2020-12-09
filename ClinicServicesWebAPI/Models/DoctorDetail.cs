using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class DoctorDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorID { get; set; }
        [Required(ErrorMessage = "DrQualification is required...")]
        [DataType(DataType.MultilineText)]
        public string DrQualification { get; set; }
        [Required(ErrorMessage = "Specialist is required...")]
        public string Specialist { get; set; } // chuyen khoa

        [Required(ErrorMessage = "DrDescription is required...")]
        [DataType(DataType.MultilineText)]
        public string DrDescription { get; set; }
        [Required(ErrorMessage = "DrPosition is required...")]
        public string DrPosition { get; set; }
        [Required(ErrorMessage = "DrExperiences is required...")]
        public string DrExperiences { get; set; }
        [StringLength(1000)]
        public string DrImage { get; set; }
        public int AccountID { get; set; }
        public bool DrLock { get; set; } 
    }
}

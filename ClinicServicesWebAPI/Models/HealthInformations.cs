using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    [Table("HealthInformations")]
    public class HealthInformations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HealthInfoID { get; set; }
        [Required(ErrorMessage = "Header is required...")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Header from 3 to 50 characters!")]
        public string Header { get; set; }
        [Required(ErrorMessage = "Content is required...")]
        [DataType(DataType.MultilineText)]
        public string HeathContent { get; set; }
        public string HealthImage { get; set; }
        public string HeathReferences { get; set; }
        public bool InfoLock { get; set; }
    }
}

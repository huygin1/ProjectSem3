using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class Seminar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeminarID { get; set; }
        [Required(ErrorMessage = "Seminar Topic is required...")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "AccountName from 3 to 20 characters!")]
        public string SeminarTopic { get; set; }
        [Required(ErrorMessage = "Staff Name is required...")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Staff Name from 3 to 20 characters!")]
        public string Staff { get; set; }
        [Required(ErrorMessage = "SeminarDate is required...")]
        [DataType(DataType.DateTime)]
        public DateTime SeminarDate { get; set; }

        public string SeminarMaterials { get; set; }
     
        [DataType(DataType.MultilineText)]
        public string SeminarDescription { get; set; }
        public string NumOfParticipants { get; set; }
     
        public string Staff_Info { get; set; }
        public bool SeminarLock { get; set; }
    }
}

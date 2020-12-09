using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    [Table("Feedback")]
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackID { get; set; }
        [Required]
        [Range(1, 5)]
        public int FeedbackStar { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Feedback Content from 3 to 500 characters!")]
        public string FeedbackContent { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FeedbackDate { get; set; }
        public int AccountID { get; set; }
        public bool FeedbackLock { get; set; }      
        public int MedicineID { get; set; }
        public int Medi_Equip_ID  { get; set; }

    }
}

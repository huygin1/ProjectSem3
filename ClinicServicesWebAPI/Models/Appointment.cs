using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentID { get; set; }
        [Required(ErrorMessage = "Appointment Date is required...")]
        [DataType(DataType.DateTime)]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.MultilineText)]
        public string Reasons { get; set; }
        public int AccountID { get; set; }   
        public int DoctorID { get; set; }      

    }
}

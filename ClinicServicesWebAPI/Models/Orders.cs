using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "OrderDate is required...")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "OrderStatus is required...")]
        public string OrderStatus { get; set; }
        [Required(ErrorMessage = "Quantity is required...")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "PaymentMethod is required...")]
        public string PaymentMethod { get; set; }
        public int AccountID { get; set; }
        public int MedicineID { get; set; }
        public int Medi_Equip_ID { get; set; }


    }
}

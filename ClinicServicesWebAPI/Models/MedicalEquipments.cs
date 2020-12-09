using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class MedicalEquipments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Medi_Equip_ID { get; set; }
        [Required(ErrorMessage = "Equipment Name is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Equipment Name from 3 to 30 characters!")]
        public string EquipName { get; set; }

        [Required(ErrorMessage = "Equipment SKU is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Equipment SKU from 3 to 30 characters!")]
        public string EquipSKU { get; set; } // so hieu san pham , Stock-keeping Unit
        [Required(ErrorMessage = "Equipment Status is required...")]
        public string EquipStatus { get; set; }
        [Required(ErrorMessage = "Equipment Tag is required...")]
        public string EquipTag { get; set; }
        [Required(ErrorMessage = "Equipment Description is required...")]
        [DataType(DataType.MultilineText)]

        public string EquipDescription { get; set; }
        [Required(ErrorMessage = "Equipment Price is required...")]
        [DataType(DataType.Currency)] // dấu $
        [Range(1, 100000, ErrorMessage = "Price from $1 to $100,000")]
        public double EquipPrice { get; set; }
        [StringLength(1000)]
        public string EquipImage { get; set; }      
        public bool EquipLock { get; set; } 
        public int CategoryChild_ID { get; set; }
    }
}

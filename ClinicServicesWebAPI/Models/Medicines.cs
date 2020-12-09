using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class Medicines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicineID { get; set; }
        [Required(ErrorMessage = "Medicine Name is required...")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Medicine Name from 3 to 20 characters!")]
        public string MedicineName { get; set; }
        [Required(ErrorMessage = "Medicine SKU  is required...")]
        public string MedicineSKU { get; set; } // so hieu san pham , Stock-keeping Unit

        [Required(ErrorMessage = "Medicine Status  is required...")]
        public string MedicineStatus { get; set; }
        [Required(ErrorMessage = "Medicine Tag  is required...")]
        public string MedicineTag { get; set; }
        [Required(ErrorMessage = "Medicine Description  is required...")]
        [DataType(DataType.MultilineText)]
        public string MedicineDescription { get; set; }
        [Required(ErrorMessage = "Medicine Price is required...")]
        [DataType(DataType.Currency)] // dấu $
        [Range(1, 100000, ErrorMessage = "Price from $1 to $100,000")]       
       
        public double MedicinePrice { get; set; }
        [StringLength(1000)]
        public string MedicineImage { get; set; }
        public bool MedicineLock { get; set; }
        [Required(ErrorMessage = "Medicine Expiry Date is required...")]
        [DataType(DataType.DateTime)]
        public DateTime MedicineExpiryDate { get; set; }
        public int CategoryChild_ID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    [Table("CategoryChild")]
    public class CategoryChild
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryChild_ID { get; set; }
        [Required(ErrorMessage = "CateChild_Name is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "CateChild_Name from 3 to 30 characters!")]
        public string CateChild_Name { get; set; }
        [Required(ErrorMessage = "CateChild_Desciption is required...")]
        [DataType(DataType.MultilineText)]
       
        [StringLength(30, MinimumLength = 3, ErrorMessage = "CateChild_Desciption from 3 to 30 characters!")]
        public string CateChild_Description { get; set; }
        public int CategoriesID { get; set; }
    }
}

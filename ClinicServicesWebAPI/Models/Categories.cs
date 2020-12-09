using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicServicesWebAPI.Models
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriesID { get; set; }
        [Required(ErrorMessage = "Categories'name is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Categories'name from 3 to 30 characters!")]
        public string CategoriesName { get; set; }
        [Required(ErrorMessage = "Categories' description is required...")]
        [DataType(DataType.MultilineText)]
        public string CategoriesDescription { get; set; }
      

    }
}

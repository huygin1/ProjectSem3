using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicServicesWebAPI.Models
{
    [Table("Accounts")]
    public class Accounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountID { get; set; }
       
        [Required(ErrorMessage = "Account Name is required...")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "AccountName from 3 to 20 characters!")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Password is required...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "FirstName is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "FirstName from 3 to 30 characters!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "LastName from 3 to 30 characters!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required...")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Email from 3 to 30 characters!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Role is required...")]
        public string Role { get; set; }
        [Required(ErrorMessage = "Phone is required...")] 
        [DataType(DataType.PhoneNumber)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Phone from 6 to 30 numbers!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Date of Birth is required...")]
        [DataType(DataType.DateTime)]      
        public DateTime DoB { get; set; }
        [DataType(DataType.MultilineText)]
        public string AccountHistory { get; set; }
        public bool AccountLock { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string District { get; set; }
       
        public string Street { get; set; }
        public string Zipcode { get; set; }
        public string Image { get; set; }

    }
}

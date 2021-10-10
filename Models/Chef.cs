using System;
using System.ComponentModel.DataAnnotations;

namespace cd_c_chefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage = "First Name required.")]
        [Display(Name = "First Name: ")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Last Name required.")]
        [Display(Name = "Last Name: ")]
        public string LastName {get;set;}

        [Required(ErrorMessage = "Date of Birth required.")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:MMMM ddd, yyyy")]
        [Display(Name = "Date of Birth: ")]
        public DateTime BirthDate {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}
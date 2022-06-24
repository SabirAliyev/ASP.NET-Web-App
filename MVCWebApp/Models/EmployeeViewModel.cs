using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class EmployeeViewModel
    {
        [Display(Name = "ID")]
        [Range(100000, 999999, ErrorMessage = "You need to enter a valid ID number")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us youe First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us youe Last Name")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "You need to provide us your E-mail address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm E-mail")]
        [Compare("EmailAddress", ErrorMessage = "E-mai addresses does not match")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Your passwords does not match")]
        [DataType(DataType.Password)]
        public string ConirmPassword { get; set; }

        
    }
}
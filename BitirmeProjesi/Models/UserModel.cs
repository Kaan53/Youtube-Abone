using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="First Name is Required")]
        [Display(Name = "FirstName:")]
        public String FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        [Display(Name = "LastName:")]
        public String LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Name is Required")]
        [Display(Name = "Email:")]
        public String Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public String Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm-Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password Should be Same")]
        public String ConfirmPassword { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SuccessMessage { get; set; }
    }
}
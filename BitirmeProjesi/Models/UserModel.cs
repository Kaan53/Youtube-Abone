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
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is Required")]
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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Şifre giriniz")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password:")]
        [Compare("Password", ErrorMessage = "Şifre giriniz")]

        public String ConfirmPassword { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Youtube Abone Linki Giriniz.")]
        [Display(Name = "Youtube Abone Linki:")]
        public String YoutubeAbone { get; set; }
       






        public DateTime CreatedOn { get; set; }
        public string SuccessMessage { get; set; }
        
      
    }
}
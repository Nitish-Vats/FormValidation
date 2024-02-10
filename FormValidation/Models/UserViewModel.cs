using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FormValidation.Attributes;

namespace FormValidation.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Please Enter the Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the Email")]
        [RegularExpression(".+@.+\\..+",ErrorMessage ="Please Enter Correct Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter the Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", 
            ErrorMessage = "Password required (1 Upper case,1 Number,1 Special Char and 1 Lower case Char) with Min Length 8 Chars")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter the Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm Password Doesn't Match")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter the Contact Number")]
        [RegularExpression("^[6789]\\d{9}$",ErrorMessage ="Please Enter Valid Contact Number")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Please Enter the Gender")]

        public string Gender { get; set; }
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Terms { get; set; }
    }
}

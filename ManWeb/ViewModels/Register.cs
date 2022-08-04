using System;
using System.ComponentModel.DataAnnotations;

namespace ManWeb.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage= "Password and ConfirmPassword didnt match")]
        public string ConfirmPassword { get; set; } = null!;


    }
}

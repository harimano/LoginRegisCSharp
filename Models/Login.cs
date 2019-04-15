using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegistration.Models
{

    public class LoginUser
    {
        public int UserId { get; set; }

        [Display(Name = "Email:")] 
        [Required]
        public string LoginEmail {get;set;}

        [Display(Name = "Password:")] 
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage="Password must be 8 characters or longer!")]
        public string LoginPassword {get;set;}

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Models
{
    public class Register
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [UIHint("Date")]
        [Required(ErrorMessage = "Lütfen Birthdate giriniz")]
        public DateTime Birthdate { get; set; }
        public bool TermsAccepted { get; set; }
    }
}

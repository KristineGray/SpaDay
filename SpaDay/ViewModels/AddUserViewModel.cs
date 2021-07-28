using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Username Required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Username must be between 5 and 15 characters long")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Password Required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters long")]
        public string Password { get; set; }
        
        [EmailAddress(ErrorMessage = "Verify Password Required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Verify Password must be between 6 and 20 characters long")]
        public string Email { get; set; }
        
        [Required]
        public string VerifyPassword { get; set; }
    }
}

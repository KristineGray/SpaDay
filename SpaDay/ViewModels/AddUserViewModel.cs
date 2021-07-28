using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength =5)]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string VerifyPassword { get; set; }
    }
}

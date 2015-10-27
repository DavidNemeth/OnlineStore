using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="User name is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [StringLength(50,MinimumLength =5)]
        public string Password { get; set; } 
    }
}

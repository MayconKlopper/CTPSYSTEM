using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.Identity.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Role { get; set; }
    }
}

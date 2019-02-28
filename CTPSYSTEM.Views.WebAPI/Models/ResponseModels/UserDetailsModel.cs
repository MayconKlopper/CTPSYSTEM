using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class UserDetailsModel
    {
        public UserDetailsModel(string userName, string email, List<string> role)
        {
            this.UserName = userName;
            this.Email = email;
            this.Role = role;
        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<string> Role { get; set; }
    }
}

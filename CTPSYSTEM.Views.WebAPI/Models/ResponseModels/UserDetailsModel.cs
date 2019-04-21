using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTPSYSTEM.Views.WebAPI.Models.ResponseModels
{
    public class UserDetailsModel
    {
        public UserDetailsModel()
        {

        }

        public UserDetailsModel(string userName, string email, List<string> role, string token)
        {
            this.UserName = userName;
            this.Email = email;
            this.Role = role;
            this.Token = token;
        }

        public string Token { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public List<string> Role { get; set; }

        #region Relacionamentos

        public FuncionarioDetailsModel Funcionario { get; set; }

        public EmpresaDetailsModel Empresa { get; set; }

        #endregion
    }
}

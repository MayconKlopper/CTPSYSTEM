using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Views.WebAPI.Models.RequestModels;

namespace CTPSYSTEM.Views.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Empresa")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            this.empresaService = empresaService;
        }

        [HttpPost("Cadastrar")]
        public ActionResult Cadastrar([FromBody] AddContratoTrabalhoModel contratoTrabalho)
        {

        }
    }
}
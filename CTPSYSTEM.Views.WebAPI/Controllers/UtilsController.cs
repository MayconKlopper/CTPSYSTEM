using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Views.WebAPI.ArquivosRecurso;
using CTPSYSTEM.Views.WebAPI.Models.ResponseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CTPSYSTEM.Views.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Utils")]
    public class UtilsController : Controller
    {
        private readonly IUtilsReadOnlyStorage utilsReadOnlyStorage;

        public UtilsController(IUtilsReadOnlyStorage utilsReadOnlyStorage)
        {
            this.utilsReadOnlyStorage = utilsReadOnlyStorage;
        }

        [HttpGet("RecuperaEstados")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public IActionResult RecuperaEstados()
        {
            try
            {
                List<Estado> estadoList = this.utilsReadOnlyStorage.RecuperaEstados().ToList();
                return Ok(estadoList);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }
    }
}
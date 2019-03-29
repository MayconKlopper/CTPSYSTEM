using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Views.WebAPI.ArquivosRecurso;
using CTPSYSTEM.Views.WebAPI.Models.RequestModels;
using CTPSYSTEM.Views.WebAPI.Models.ResponseModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CTPSYSTEM.Views.WebAPI.Controllers
{
    [Authorize("Bearer", Roles = "empresa, usuario, funcionario")]
    [Produces("application/json")]
    [Route("api/Hash")]
    public class HashController : Controller
    {
        private readonly IHashService hashService;

        public HashController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        [HttpPost("GerarHash")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult GerarHash([FromBody] AddHashModel model)
        {
            try
            {
                var chave = this.hashService.GerarHash(model.IdFuncionario, model.IdCarteiraTrabalho);

                return Ok(chave);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("VerificarValidadeHash")]
        [ProducesResponseType(typeof(MessageModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult VerificarValidadeHash([FromBody] HashDetailsModel model)
        {
            try
            {
                this.hashService.verificaValidadeHash(model.HashCode, model.IdFuncionario, model.IdCarteiraTrabalho);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
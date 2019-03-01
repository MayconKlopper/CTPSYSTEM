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
    [Authorize("Bearer", Roles = "funcionario, usuario")]
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
                this.hashService.GerarHash(model.IdFuncionario, model.IdCarteiraTrabalho);

                return Ok();
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
        public ActionResult VerificarValidadeHash([FromBody] AddHashModel model)
        {
            try
            {
                MessageModel mensagem = this.hashService.verificaValidadeHash(model.hashCode, model.IdFuncionario, model.IdCarteiraTrabalho);

                if (mensagem.tipo == 1)
                {
                    return BadRequest(mensagem);
                }
                else
                {
                    return Ok(mensagem);
                }
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }
    }
}
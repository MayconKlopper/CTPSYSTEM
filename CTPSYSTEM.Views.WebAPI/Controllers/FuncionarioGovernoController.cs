using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Views.WebAPI.ArquivosRecurso;
using CTPSYSTEM.Views.WebAPI.Models.RequestModels;
using CTPSYSTEM.Views.WebAPI.Models.ResponseModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CTPSYSTEM.Views.WebAPI.Controllers
{
    [Authorize("Bearer", Roles = "funcionario")]
    [Produces("application/json")]
    [Route("api/FuncionarioGoverno")]
    public class FuncionarioGovernoController : Controller
    {
        private readonly IFuncionarioGovernoService funcionarioGovernoService;

        public FuncionarioGovernoController(IFuncionarioGovernoService funcionarioGovernoService)
        {
            this.funcionarioGovernoService = funcionarioGovernoService;
        }

        [HttpGet("RecuperaEmpresa")]
        [ProducesResponseType(typeof(IEnumerable<EmpresaDetailsModel>), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaEmpresa()
        {
            try
            {
                IEnumerable<EmpresaDetailsModel> model = this.funcionarioGovernoService.RecuperaEmpresa()
                    .Select(empresa => (EmpresaDetailsModel)empresa);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaFuncionario")]
        [ProducesResponseType(typeof(IEnumerable<FuncionarioDetailsModel>), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaFuncionario()
        {
            try
            {
                List<FuncionarioDetailsModel> model = this.funcionarioGovernoService.RecuperaFuncionario()
                    .Select(funcionario => (FuncionarioDetailsModel)funcionario)
                    .ToList();

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastarCarteiraTrabalho")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastarCarteiraTrabalho([FromBody] AddCarteiraTrabalhoModel model)
        {
            try
            {
                CarteiraTrabalho carteiraTrabalho = model;
                this.funcionarioGovernoService.Cadastrar(carteiraTrabalho);
                MessageModel message = new MessageModel(1, Mensagens.CarteiraTrabalhoCriadaSucesso);
                return Ok(message);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarFuncionario")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarFuncionario([FromBody] AddFuncionarioModel model)
        {
            try
            {
                Funcionario funcionario = model;

                this.funcionarioGovernoService.Cadastrar(funcionario);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarEmpresa")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarEmpresa([FromBody] AddEmpresaModel model)
        {
            try
            {
                Empresa empresa = model;

                this.funcionarioGovernoService.Cadastrar(empresa);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }
    }
}
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Servicos;
using CTPSYSTEM.Views.WebAPI.ArquivosRecurso;
using CTPSYSTEM.Views.WebAPI.Models.RequestModels;
using CTPSYSTEM.Views.WebAPI.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CTPSYSTEM.Views.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Empresa")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService empresaService;
        private readonly IEmpresaReadOnlyStorage empresaReadOnlyStorage;

        public EmpresaController(IEmpresaService empresaService, IEmpresaReadOnlyStorage empresaReadOnlyStorage)
        {
            this.empresaService = empresaService;
            this.empresaReadOnlyStorage = empresaReadOnlyStorage;
        }

        [HttpGet("RecuperaEmpresa/{CNPJ}")]
        [ProducesResponseType(typeof(EmpresaDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaEmpresa(string CNPJ)
        {
            try
            {
                var empresa = this.empresaReadOnlyStorage.RecuperaEmpresa(CNPJ);

                return Ok(empresa);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarContratoTrabalho")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarContratoTrabalho([FromBody] AddContratoTrabalhoModel model)
        {
            try
            {
                ContratoTrabalho contratoTrabalho = model;

                this.empresaService.Cadastrar(contratoTrabalho);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarAlteracaoSalarial")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarAlteracaoSalarial([FromBody] AddAlteracaoSalarialModel model)
        {
            try
            {
                AlteracaoSalarial alteracaoSalarial = model;

                this.empresaService.Cadastrar(alteracaoSalarial);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarContribuicaoSindical")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarContribuicaoSindical([FromBody] AddContribuicaoSindicalModel model)
        {
            try
            {
                ContribuicaoSindical contribuicaoSindical = model;

                this.empresaService.Cadastrar(contribuicaoSindical);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarAnotacaoGeral")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarAnotacaoGeral([FromBody] AddAnotacaoGeralModel model)
        {
            try
            {
                AnotacaoGeral anotacaoGeral = model;

                this.empresaService.Cadastrar(anotacaoGeral);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarFerias")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarFerias([FromBody] AddFeriasModel model)
        {
            try
            {
                Ferias ferias = model;

                this.empresaService.Cadastrar(ferias);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarLicenca")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarLicenca([FromBody] AddLicencaModel model)
        {
            try
            {
                Licenca licenca = model;

                this.empresaService.Cadastrar(licenca);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarInternacao")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarLicenca([FromBody] AddInternacaoModel model)
        {
            try
            {
                Internacao internacao = model;

                this.empresaService.Cadastrar(internacao);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("VincularFuncionario")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult VincularFuncionario([FromBody] VinculaFuncionarioModel model)
        {
            try
            {
                this.empresaService.VincularFuncionario(model.IdFuncionario, model.IdEmpresa);

                return Ok();
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpPost("DesvincularFuncionario")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult DesvincularFuncionario([FromBody] int idFuncionario)
        {
            try
            {
                this.empresaService.DesvincularFuncionario(idFuncionario);

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
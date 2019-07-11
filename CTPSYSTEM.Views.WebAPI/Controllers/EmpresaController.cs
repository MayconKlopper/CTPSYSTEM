using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
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
    [Authorize("Bearer", Roles = "empresa")]
    [Produces("application/json")]
    [Route("api/Empresa")]
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService empresaService;
        private readonly IEmpresaReadOnlyStorage empresaReadOnlyStorage;
        private readonly IFuncionarioGovernoService funcionarioGovernoService;
        private readonly IHashService hashService;
        private readonly IFuncionarioReadOnlyStorage funcionarioReadOnlyStorage;

        public EmpresaController(IEmpresaService empresaService,
            IEmpresaReadOnlyStorage empresaReadOnlyStorage,
            IFuncionarioGovernoService funcionarioGovernoService,
            IFuncionarioReadOnlyStorage funcionarioReadOnlyStorage,
            IHashService hashService)
        {
            this.empresaService = empresaService;
            this.empresaReadOnlyStorage = empresaReadOnlyStorage;
            this.funcionarioGovernoService = funcionarioGovernoService;
            this.funcionarioReadOnlyStorage = funcionarioReadOnlyStorage;
            this.hashService = hashService;
        }

        [AllowAnonymous]
        [HttpPost("CadastrarEmpresa")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastarEmpresa([FromBody] AddEmpresaModel model)
        {
            try
            {
                Empresa empresa = model;
                this.funcionarioGovernoService.Cadastrar(empresa);
                MessageModel message = new MessageModel(1, Mensagens.EmpresaCriadaSucesso);
                return Ok(message);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaFuncionarios/{idEmpresa}")]
        [ProducesResponseType(typeof(List<FuncionarioDetailsModel>), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaFuncionarios(int idEmpresa)
        {
            try
            {
                List<FuncionarioDetailsModel> modelList = this.empresaReadOnlyStorage.RecuperaFuncionarios(idEmpresa)
                    .Select(funcionario => (FuncionarioDetailsModel)funcionario)
                    .ToList();

                return Ok(modelList);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaHistoricoFuncionarios/{idEmpresa}")]
        [ProducesResponseType(typeof(List<FuncionarioHistoricoDetailsModel>), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaHistoricoFuncionarios(int idEmpresa)
        {
            try
            {
                List<FuncionarioHistoricoDetailsModel> modelList = this.empresaReadOnlyStorage.RecuperaHistoricoFuncionarios(idEmpresa)
                    .Select(funcionario => (FuncionarioHistoricoDetailsModel)funcionario)
                    .ToList();

                return Ok(modelList);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaEmpresa/{CNPJ}")]
        [ProducesResponseType(typeof(EmpresaDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaEmpresa(string CNPJ)
        {
            try
            {
                EmpresaDetailsModel model = this.empresaReadOnlyStorage.RecuperaEmpresa(CNPJ);

                return Ok(model);
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
            MessageModel message = new MessageModel();

            try
            {
                ContratoTrabalho contratoTrabalho = model;

                this.empresaService.Cadastrar(contratoTrabalho);

                message = new MessageModel(1, Mensagens.ContratoTrabalhoCriadoSucesso);
                return Ok(contratoTrabalho.Id);
            }
            catch (Exception ex)
            {
                message = new MessageModel(1, ex.Message);
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
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
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
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarFGTS")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarFGTS([FromBody] AddFGTSModel model)
        {
            try
            {
                FGTS fgts = model;

                this.empresaService.Cadastrar(fgts);

                return Ok();
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
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
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
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
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
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
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
                return BadRequest(message);
            }
        }

        [HttpPost("CadastrarInternacao")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarInternacao([FromBody] AddInternacaoModel model)
        {
            try
            {
                Internacao internacao = model;

                this.empresaService.Cadastrar(internacao);

                return Ok();
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, ex.Message);
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
                MessageModel message = new MessageModel();

                Funcionario funcionario = this.funcionarioReadOnlyStorage.RecuperaFuncionario(model.CPF);

                if (ReferenceEquals(funcionario, null))
                {
                    message = new MessageModel(1, "Funcionário Não encontrado. Por favor verifique o CPF");
                }
                else if (!ReferenceEquals(funcionario.IdEmpresa, null))
                {
                    message = new MessageModel(1, "O Funcionário já está vinculado a outra empresa.");
                }
                else
                {
                    int idCarteiraTrabalho = funcionario.CarteiraTrabalho.FirstOrDefault(carteiraTrabalho => carteiraTrabalho.Ativo).Id;

                    this.hashService.verificaValidadeHash(model.HashCode, funcionario.Id, idCarteiraTrabalho);

                    this.empresaService.VincularFuncionario(funcionario, model.IdEmpresa);

                    message = new MessageModel(2, "O Funcionário foi vinculado a sua empresa com sucesso. Crie um registro de contrato de trabalho");
                    return Ok(message);
                }

                return BadRequest(message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DesvincularFuncionario")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult DesvincularFuncionario([FromBody] DesvincularFuncionarioModel model)
        {
            MessageModel message = new MessageModel();

            try
            {
                this.empresaService.DesvincularFuncionario(model.IdFuncionario, model.IdContratoTrabalho);

                message = new MessageModel(2, "Funcionário teve seu contrato encerrado e foi desvinculado da empresa.");
                return Ok(message);
            }
            catch (Exception ex)
            {
                message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }
    }
}
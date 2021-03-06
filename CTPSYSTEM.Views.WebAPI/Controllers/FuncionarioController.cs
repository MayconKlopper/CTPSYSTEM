﻿using CTPSYSTEM.Domain;
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
    [Authorize("Bearer", Roles = "usuario")]
    [Produces("application/json")]
    [Route("api/Funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioReadOnlyStorage funcionarioReadOnlyStorage;
        private readonly IFuncionarioGovernoService funcionarioGovernoService;

        public FuncionarioController(IFuncionarioReadOnlyStorage funcionarioReadOnlyStorage,
            IFuncionarioGovernoService funcionarioGovernoService)
        {
            this.funcionarioReadOnlyStorage = funcionarioReadOnlyStorage;
            this.funcionarioGovernoService = funcionarioGovernoService;
        }

        [AllowAnonymous]
        [HttpPost("CadastrarFuncionario")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult CadastrarFuncionario([FromBody] AddFuncionarioModel model)
        {
            try
            {
                Funcionario funcionario = model;
                this.funcionarioGovernoService.Cadastrar(funcionario);
                MessageModel message = new MessageModel(1, Mensagens.FuncionarioCriadoSucesso);
                return Ok(message);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaFuncionario/{CPF}")]
        [ProducesResponseType(typeof(FuncionarioDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaFuncionario(string CPF)
        {
            try
            {
                FuncionarioDetailsModel funcionario = this.funcionarioReadOnlyStorage.RecuperaFuncionario(CPF);

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaEmpresaHistorico/{idFuncionario}")]
        [ProducesResponseType(typeof(EmpresaDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaEmpresaHistorico(int idFuncionario)
        {
            try
            {
                IEnumerable<EmpresaDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaHistoricoEmpresa(idFuncionario)
                    .Select(empresaHistorico => (EmpresaDetailsModel)empresaHistorico);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaCarteiraTrabalhoHistorico/{idFuncionario}")]
        [ProducesResponseType(typeof(IEnumerable<CarteiraTrabalhoDetailsModel>), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaCarteiraTrabalhoHistorico(int idFuncionario)
        {
            try
            {
                IEnumerable<CarteiraTrabalhoDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaHistoricoCarteiraTrabalho(idFuncionario)
                    .Select(empresaHistorico => (CarteiraTrabalhoDetailsModel)empresaHistorico);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaCarteiraTrabalho/{idFuncionario}")]
        [ProducesResponseType(typeof(CarteiraTrabalhoDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaCarteiraTrabalho(int idFuncionario)
        {
            try
            {
                CarteiraTrabalhoDetailsModel model = this.funcionarioReadOnlyStorage
                    .RecuperaCarteiraTrabalho(idFuncionario);

                return Ok(model);
            }
            catch (Exception ex)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaInternacao/{idCarteiraTrabalho}")]
        [ProducesResponseType(typeof(InternacaoDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaInternacao(int idCarteiraTrabalho)
        {
            try
            {
                IEnumerable<InternacaoDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaInternacao(idCarteiraTrabalho)
                    .Select(internacao => (InternacaoDetailsModel)internacao);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaLicenca/{idCarteiraTrabalho}")]
        [ProducesResponseType(typeof(LicencaDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaLicenca(int idCarteiraTrabalho)
        {
            try
            {
                IEnumerable<LicencaDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaLicenca(idCarteiraTrabalho)
                    .Select(licenca => (LicencaDetailsModel)licenca);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaContratoTrabalho/{idCarteiraTrabalho}")]
        [ProducesResponseType(typeof(ContratoTrabalhoDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaContratoTrabalho(int idCarteiraTrabalho)
        {
            try
            {
                IEnumerable<ContratoTrabalhoDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaContratoTrabalho(idCarteiraTrabalho)
                    .Select(contratoTrabalho => (ContratoTrabalhoDetailsModel)contratoTrabalho);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaAlteracaoSalarial/{idContratoTrabalho}")]
        [ProducesResponseType(typeof(AlteracaoSalarialDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaAlteracaoSalarial(int idContratoTrabalho)
        {
            try
            {
                IEnumerable<AlteracaoSalarialDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaAlteracaoSalarial(idContratoTrabalho)
                    .Select(alteracaoSalarial => (AlteracaoSalarialDetailsModel)alteracaoSalarial);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaFerias/{idContratoTrabalho}")]
        [ProducesResponseType(typeof(FeriasDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaFerias(int idContratoTrabalho)
        {
            try
            {
                IEnumerable<FeriasDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaFerias(idContratoTrabalho)
                    .Select(ferias => (FeriasDetailsModel)ferias);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaAnotacaoGeral/{idContratoTrabalho}")]
        [ProducesResponseType(typeof(AnotacaoGeralDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaAnotacaoGeral(int idContratoTrabalho)
        {
            try
            {
                IEnumerable<AnotacaoGeralDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaAnotacaoGeral(idContratoTrabalho)
                    .Select(anotacaoGeral => (AnotacaoGeralDetailsModel)anotacaoGeral);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaContribuicaoSindical/{idContratoTrabalho}")]
        [ProducesResponseType(typeof(ContribuicaoSindicalDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaContribuicaoSindical(int idContratoTrabalho)
        {
            try
            {
                IEnumerable<ContribuicaoSindicalDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaContribuicaoSindical(idContratoTrabalho)
                    .Select(contribuicaoSindical => (ContribuicaoSindicalDetailsModel)contribuicaoSindical);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }

        [HttpGet("RecuperaFGTS/{idContratoTrabalho}")]
        [ProducesResponseType(typeof(ContribuicaoSindicalDetailsModel), 200)]
        [ProducesResponseType(typeof(MessageModel), 400)]
        public ActionResult RecuperaFGTS(int idContratoTrabalho)
        {
            try
            {
                IEnumerable<FGTSDetailsModel> model = this.funcionarioReadOnlyStorage
                    .RecuperaFGTS(idContratoTrabalho)
                    .Select(fgts => (FGTSDetailsModel)fgts);

                return Ok(model);
            }
            catch (Exception)
            {
                MessageModel message = new MessageModel(1, Mensagens.ErroGenerico);
                return BadRequest(message);
            }
        }
    }
}
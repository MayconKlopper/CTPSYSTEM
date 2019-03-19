﻿using CTPSYSTEM.Database.EntityFramework.FonteDados;
using CTPSYSTEM.Domain;
using CTPSYSTEM.Domain.Dados;
using CTPSYSTEM.Domain.Historico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CTPSYSTEM.Database.EntityFramework.Persistencia
{
    public class EmpresaContext : BaseContext<ContratoTrabalho>, IEmpresaReadOnlyStorage, IEmpresaStorage
    {
        public EmpresaContext(Conexao conexao) : base(conexao)
        {
        }

        public void Insert(AlteracaoSalarial alteracaoSalarial)
        {
            conexao.AlteracaoSalarial.Add(alteracaoSalarial);
        }

        public void Insert(ContribuicaoSindical contribuicaoSindical)
        {
            conexao.ContribuicaoSindical.Add(contribuicaoSindical);
        }

        public void Insert(AnotacaoGeral anotacaoGeral)
        {
            conexao.AnotacaoGeral.Add(anotacaoGeral);
        }

        public void Insert(Ferias ferias)
        {
            conexao.Ferias.Add(ferias);
        }

        public void Insert(Licenca licenca)
        {
            conexao.Licenca.Add(licenca);
        }

        public void Insert(Internacao internacao)
        {
            conexao.Internacao.Add(internacao);
        }

        public void Update(Funcionario funcionario, params Expression<Func<Funcionario, object>>[] expressions)
        {
            var x = this.conexao.Attach(funcionario);
            foreach (var expression in expressions)
            {
                x.Property(expression).IsModified = true;
            }
        }

        public Empresa RecuperaEmpresa(string CNPJ)
        {
            return conexao.Empresa
                          .Include(empresa => empresa.Endereco)
                          .ThenInclude(endereco => endereco.Estado)
                          .FirstOrDefault(empresa => empresa.CNPJ == CNPJ);
        }

        public IEnumerable<Funcionario> RecuperaFuncionarios(int idEmpresa)
        {
            return conexao.Funcionario
                          .Include(funcionario => funcionario.CarteiraTrabalho)
                           .ThenInclude(carteiraTrabalho => carteiraTrabalho.ContratoTrabalho)
                          .Include(funcionario => funcionario.LocalNascimento)
                           .ThenInclude(localNascimento => localNascimento.Estado)
                          .Where(funcionario => funcionario.IdEmpresa == idEmpresa);
        }

        public Funcionario RecuperaFuncionario(int idFuncionario)
        {
            return conexao.Funcionario
                          .Find(idFuncionario);
        }

        public IEnumerable<FuncionarioHistorico> RecuperaHistoricoFuncionario(int idEmpresa)
        {
            return conexao.FuncionarioHistorico
                          .Where(funcionarioHistorico => funcionarioHistorico.IdEmpresa == idEmpresa);
        }
    }
}
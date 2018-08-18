using System;
using System.Collections.Generic;
using System.Text;

namespace CTPSYSTEM.Domain.Servicos
{
    public interface IEmpresaService
    {
        void Cadastrar(ContratoTrabalho contratoTrabalho);

        void Cadastrar(AlteracaoSalarial alteracaoSalarial);

        void Cadastrar(ContribuicaoSindical contribuicaoSindical);

        void Cadastrar(AnotacaoGeral anotacaoGeral);

        void Cadastrar(Ferias ferias);

        void Cadastrar(Licenca licenca);

        void Cadastrar(Internacao internacao);

        void VincularFuncionario(int idFuncionario, int idEmpresa);

        void DesvincularFuncionario(int idFuncionario);
    }
}

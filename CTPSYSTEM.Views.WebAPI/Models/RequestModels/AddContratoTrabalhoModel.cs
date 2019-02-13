﻿using CTPSYSTEM.Domain;

using System;

namespace CTPSYSTEM.Views.WebAPI.Models.RequestModels
{
    public class AddContratoTrabalhoModel
    {
        /// <summary>
        /// Identificador único do registro de contrato de trabalho
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador único do registro de carteira trabalho
        /// ao qual este registro de contrato de trabalho está vinculado
        /// </summary>
        public int IdCarteiraTrabalho { get; set; }

        /// <summary>
        /// Identificador único da empresa ao qual este registro de
        /// contrato de trabalho está vinculado
        /// </summary>
        public int IdEmpresa { get; set; }

        /// <summary>
        /// Nome do cargo
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Número do CBO da empresa empregadora
        /// </summary>
        public int CBONumero { get; set; }

        /// <summary>
        /// Data de firmação do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataAdmissao { get; set; }

        /// <summary>
        /// Data de finalização do contrato de trabalho
        /// </summary>
        public DateTimeOffset DataSaida { get; set; }

        /// <summary>
        /// Valor de remuneração em decimal
        /// </summary>
        public decimal Remuneracao { get; set; }

        /// <summary>
        /// Valor de remuneração escrita por extenso
        /// </summary>
        public string RemuneracaoExtenso { get; set; }

        /// <summary>
        /// FlsFicha da empresa empregadora. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int FlsFicha { get; set; }

        /// <summary>
        /// Número de registro da empresa. OBS: a maioria vem com o valor 0 que é o valor default
        /// </summary>
        public int RegistroNumero { get; set; }

        public static implicit operator ContratoTrabalho(AddContratoTrabalhoModel model)
        {
            var contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Ativo = true;
            contratoTrabalho.Cargo = model.Cargo;
            contratoTrabalho.CBONumero = model.CBONumero;
            contratoTrabalho.DataAdmissao = model.DataAdmissao;
            contratoTrabalho.DataSaida = model.DataSaida;
            contratoTrabalho.FlsFicha = model.FlsFicha;
            contratoTrabalho.IdCarteiraTrabalho = model.IdCarteiraTrabalho;
            contratoTrabalho.IdEmpresa = model.IdEmpresa;
            contratoTrabalho.RegistroNumero = model.RegistroNumero;
            contratoTrabalho.Remuneracao = model.Remuneracao;
            contratoTrabalho.RemuneracaoExtenso = model.RemuneracaoExtenso;

            return contratoTrabalho;
        }
    }
}
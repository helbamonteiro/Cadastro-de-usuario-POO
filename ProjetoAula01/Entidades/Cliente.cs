using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Entidades
{
    /// <summary>
    /// Modelo de entidade para cliente.
    /// </summary>
    public class Cliente
    {
        #region Atributos

        private Guid? _id;
        private string? _nome;
        private string? _email;
        private string? _telefone;
        private string? _cpf;
        private DateTime? _dataHoraInclusao;

        #endregion

        #region Propriedades (Métodos de encapsulamento)

        public Guid? Id
        {
            set => _id = value; //entrada de dados
            get => _id; //saída de dados
        }

        public string? Nome
        {
            set => _nome = value;
            get => _nome;
        }

        public string? Email
        {
            set => _email = value;
            get => _email;
        }

        public string? Telefone
        {
            set => _telefone = value;
            get => _telefone;
        }

        public string? Cpf
        {
            set => _cpf = value;
            get => _cpf;
        }

        public DateTime? DataHoraInclusao
        {
            set => _dataHoraInclusao = value;
            get => _dataHoraInclusao;
        }

        #endregion
    }
}



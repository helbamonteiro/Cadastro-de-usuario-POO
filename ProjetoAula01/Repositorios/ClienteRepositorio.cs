using ProjetoAula01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Repositorios
{

    /// <summary>
    /// Classe para gravar, ler, editar ou excluir dados de clientes em arquivos.
    /// </summary>
    public class ClienteRepositorio
    {
        /// <summary>
        /// Método para gravar os dados do cliente em um arquivo de extensão TXT
        /// </summary>
        public void ExportarDados(Cliente cliente)
        {
            var streamWriter = new StreamWriter("c:\\temp\\clientes.txt", true);

            streamWriter.WriteLine("ID DO CLIENTE.....: " + cliente.Id);
            streamWriter.WriteLine("NOME..............: " + cliente.Nome);
            streamWriter.WriteLine("EMAIL.............: " + cliente.Email);
            streamWriter.WriteLine("TELEFONE..........: " + cliente.Telefone);
            streamWriter.WriteLine("CPF...............: " + cliente.Cpf);
            streamWriter.WriteLine("INCLUÍDO EM.......: " + cliente.DataHoraInclusao);
            streamWriter.WriteLine("...");

            streamWriter.Close();


        }
    }
}

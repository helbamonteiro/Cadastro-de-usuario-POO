//definindo a localização da classe dentro do projeto
using ProjetoAula01.Entidades;
using ProjetoAula01.Repositorios;

namespace ProjetoAula01
{
    //declaração da classe
    public class Program
    {
        //Método / função para execuar a class
        public static void Main(string[] args)
        {
            //imprimindo mensagem
            Console.WriteLine("\n*** SISTEMA DE CADASTRO DE CLIENTE ***\n");
            
            var cliente = new Cliente();

            cliente.Id = Guid.NewGuid();
            cliente.DataHoraInclusao = DateTime.Now;

            Console.WriteLine("INFORME O NOME DO CLIENTE........:");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE...........:");
            cliente.Email = Console.ReadLine();

            Console.Write("INFORME O TELEFONE DO CLIENTE........:");
            cliente.Telefone = Console.ReadLine();

            Console.Write("INFORME O CPF DO CLIENTE.............:");
            cliente.Cpf = Console.ReadLine();   

       
            Console.WriteLine("\nDADOS DO CLIENTE");
            Console.WriteLine("\nID DO CLIENTE............:" + cliente.Id);
            Console.WriteLine("\nNOME.....................:" + cliente.Nome);
            Console.WriteLine("\nEMAIL....................:" + cliente.Email);
            Console.WriteLine("\nTELEFONE.................:" + cliente.Telefone);
            Console.WriteLine("\nCPF......................:" + cliente.Cpf);
            Console.WriteLine("\nINCLUÍDO EM..............:" + cliente.DataHoraInclusao);

            var clienteRepositorio = new ClienteRepositorio();
            clienteRepositorio.ExportarDados(cliente);

            Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO!");

            Console.ReadKey();

        }
    }
}
using Cadastro;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ClienteRepositorio
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void GravarDadosClientes()
        {
            string json = JsonConvert.SerializeObject(clientes);
            File.WriteAllText("clientes.txt", json);  
        }

        public void LerDadosClientes()
        {
            if (File.Exists("Clientes.txt"))
            {
                var dados = File.ReadAllText("clientes.txt");
           // string json = JsonConvert.SerializeObject(clientes);
            var clientesArquivo = JsonConvert.DeserializeObject<List<Cliente>>(dados);

            clientes.AddRange(clientesArquivo);

            }

        }

        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine("Id................:" + cliente.Id);
            Console.WriteLine("Nome..............:" + cliente.Name);
            Console.WriteLine("Desconto..........:" + cliente.Desconto);
            Console.WriteLine("Data Nascimento...:" + cliente.DataNascimento);
            Console.WriteLine("Data Cadastro.....:" + cliente.CadastradoEm);
            Console.WriteLine("-------------------------------------------");

        }

        public void ExibirClientes()
        {
            Console.Clear();
            foreach (var cliente in clientes)
            {
                ImprimirCliente (cliente);
            }

            Console.ReadKey();
        }

        public void CadastrarCliente()
        {
            Console.Clear();

            Console.Write("Nome do Cliente:");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento:");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto:");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            var cliente = new Cliente();
            cliente.Id = clientes.Count + 1;
            cliente.Name = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;

            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
            ImprimirCliente(cliente);
            Console.ReadKey();  
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.Write("Informe o código do cliente:");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(p => p.Id== int.Parse(codigo));

            if (cliente == null) 
            {
                Console.WriteLine("Cliente não encontrado!");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            Console.Write("Nome do Cliente:");
            var nome = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Data de Nascimento:");
            var dataNascimento = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Desconto:");
            var desconto = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            cliente.Name = nome;
            cliente.DataNascimento = dataNascimento;
            cliente.Desconto = desconto;
            cliente.CadastradoEm = DateTime.Now;


            Console.WriteLine("Cliente alterado com sucesso!");
            ImprimirCliente(cliente);
            Console.ReadKey();

        }

        public void ExcluirCliente()
        {
            Console.Clear();
            Console.Write("Informe o código do cliente:");
            var codigo = Console.ReadLine();

            var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado!");
                Console.ReadKey();
                return;
            }

            ImprimirCliente(cliente);

            clientes.Remove(cliente);

            Console.WriteLine("Cliente excluído com sucesso!");
            Console.ReadKey();


        }
    }
}

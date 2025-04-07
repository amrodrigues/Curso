using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        { return a * b; }
    }
    public class Produto
    {
        private int Id;

        public string Descricao { get; set; }

        //public readonly int Estoque;
        public int Estoque { get; }
        public Produto()
        {
            Estoque = 1;
        }
        
        public void ImprimirDescricao()
        {

            Console.WriteLine(Getid()+ " - " + Descricao);
        }

        public void Setid(int id)
            { Id = id; }

        public int Getid() { return Id; }

    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereco: " + Endereco);
            Console.WriteLine("Cidade: " +Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCPF()
        { Console.WriteLine("CPF: " + CPF); }
    }

    public class Funcionario : PessoaFisica
    { 
        public string Matricula {  get; set; }

        public void ImprimirMatricula()
        {
            Console.WriteLine("Matricula: " + Matricula);
        }
    }

}

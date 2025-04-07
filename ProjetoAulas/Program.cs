public class Program
{

    static void Main(string[] args)
    {

        // AulaClasse();
        AulaHeranca();
        AulaHeranca2();
    }

    private static void AulaClasse()
    {
        var produto = new Cadastro.Produto();
        produto.Setid(1);
        produto.Descricao = "Teclado";

        produto.ImprimirDescricao();
        Console.WriteLine(produto.Getid());

        Console.WriteLine(produto.Estoque);

        var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
        Console.WriteLine(resultado);
    }

    private static void AulaHeranca()
    {
        var pessoaFisica = new Cadastro.PessoaFisica();
        pessoaFisica.Id = 13;
        pessoaFisica.Endereco = "Rua das Paineiras, 34";
        pessoaFisica.Cidade = "Piracicaba";
        pessoaFisica.Cep = "23420-230";
        pessoaFisica.CPF = "15356565646";
        pessoaFisica.ImprimirDados();
        pessoaFisica.ImprimirCPF();

    }

    private static void AulaHeranca2()
    {
        var funcionario = new Cadastro.Funcionario();
        funcionario.Id = 123;
        funcionario.Endereco = "Rua das Paineiras, 34";
        funcionario.Cidade = "Piracicaba";
        funcionario.Cep = "23420-230";
        funcionario.CPF = "15356565646";
        funcionario.Matricula = "46465";
        funcionario.ImprimirMatricula();
        funcionario.ImprimirDados();
        funcionario.ImprimirCPF();
        



    }

}

        

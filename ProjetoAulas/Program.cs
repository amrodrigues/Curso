using Cadastro;
using Modulo10;

public class Program
{

    static void Main(string[] args)
    {
        //AulaClasse();
        //AulaHeranca();
        //AulaHeranca2();
        //AulaClasseSelada()
        // AulaClasseAbstrata()
        //AulaRecord();
        // AulaInterface();
        // Conversores();
        //TrabalhandoComStrings();
        // TrabalhandocomDatas();
        // TrabalhandoComExcecoes();
        //TrabalhandoComArquivos();
        TrabalhandoComLinq();

    }

    public static void TrabalhandoComLinq()
    {
        var linq = new Modulo14.TrabalahndocomLInq();
        // linq.AulaWhere();
        //linq.AulaOrdenacao();
        //linq.AulaTake();
       // linq.AulaCount();
      
       linq.AulaFristOrDefault();

    }

    public static void TrabalhandoComArquivos()
    {
        var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
        // trabalhandoComArquivos.AulaCriandoArquivo();
        //trabalhandoComArquivos.AulaLendoArquivo();
        trabalhandoComArquivos.AulaExcluindoArquivo();
    }
    public static void TrabalhandoComExcecoes()
    {
        var trabalhandoComExececoes = new Modulo12.TrabalhandoComExececoes();
        trabalhandoComExececoes.AulaGerandoException();

    }

    public static void TrabalhandocomDatas()
    {
        var trabalhandocomDatas = new Modulo11.TrabalahandoComDatas();
        //trabalhandocomDatas.AulaDatetime();
        // trabalhandocomDatas.AulaSubitrairDatas();
        //trabalhandocomDatas.AulaAdicionandoDiasMesAno();
        //trabalhandocomDatas.AulaAdicionandoHoraMinutoSegundos();
       // trabalhandocomDatas.AulaDiadaSemana();
        //trabalhandocomDatas.AulaDateOnly();
        trabalhandocomDatas.AulaTimeOnly();
    }


    private static void TrabalhandoComStrings()
    {
        var trabalhandoComStrings = new Modulo10.TrabalhandocomStrings();
        //trabalhandoComStrings.ConverterParaLetrasMinusculas();    
        //trabalhandoComStrings.ConverterParaLetrasMaiusculas();
        //trabalhandoComStrings.AulaSubstrings();
        // trabalhandoComStrings.AulaRange();
        // trabalhandoComStrings.AulaContains();   
        // trabalhandoComStrings.AulaTrim();
        // trabalhandoComStrings.AulaStart();
        //  trabalhandoComStrings.AulaReplace();
        //trabalhandoComStrings.AulaLength();
    }

    
 

    public static void Conversores()
    {
        var conversores = new Conversores.Conversor();
        conversores.ConvertAndParse();
        conversores.AulaTryParse();
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

    public static void AulaClasseSelada()
    {

        var configuracao = new Cadastro.Configuracao();
        configuracao.Host = "localhost";
        configuracao.Porta = "25";

        var configuracao2 = new Cadastro.Configuracao { Host = "localhost", Porta = "25" };

        Console.WriteLine(configuracao2.Host);
    }


    public static void AulaClasseAbstrata()
    {
        var animal = new Cadastro.Cachorro();
        animal.Nome = "Bolinha";
        animal.ImprimirDados();
    }

    public static void AulaRecord()
    {
        var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
        var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

        //Console.WriteLine(curso1.Equals(curso2));

        Console.WriteLine(curso1 == curso2);
    }
    public static void AulaRecord1()
    {
        var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
        var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

        //Console.WriteLine(curso1.Equals(curso2));

        Console.WriteLine(curso1 == curso2);
    }


    public static void AulaRecord2()
    {
        var curso1 = new Cadastro.Curso1(1, "Curso");
        var curso2 = new Cadastro.Curso1(1, "Curso");


        Console.WriteLine(curso1 == curso2);
    }

    public static void AulaRecord3()
    {
        // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
        //   var curso2 = curso1;
        //    curso2.Descricao = "Teste";
        // var curso2 = new Cadastro.CursoTeste();
        //curso2.Id = curso1.Id;
        //curso2.Descricao = "Nova Descricao";

        var curso1 = new Cadastro.Curso1(1, "Curso");
        var curso2 = curso1 with { Descricao = "Curso 2" };


        Console.WriteLine(curso1.Descricao);
        Console.WriteLine(curso2.Descricao);
    }

    public static void AulaInterface()
    {
        var notificacaoCliente = new Cadastro.NotificacaoCliente();
        notificacaoCliente.Notificar();
        notificacaoCliente.NotificarOutros();

        Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
        notificacao.Notificar();
        
    }

}




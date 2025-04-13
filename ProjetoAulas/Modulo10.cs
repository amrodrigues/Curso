using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo10;

public class TrabalhandocomStrings
{ 
    public void ConverterParaLetrasMinusculas()
    {
    Console.Write("Favor digitar alguma informação:");
    var linha = Console.ReadLine();
    Console.WriteLine(linha.ToLower());
    }

    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informação:");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstrings()
    {
        Console.Write("Favor digitar alguma informação:");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0,6));
    }

    public void AulaRange()
    {
        string nomeArquivo = "2025_12_01_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);
        string nome = nomeArquivo[11..];
        Console.WriteLine(nome);
        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }

    public void AulaContains()
    {
        string nomeArquivo = "2025_12_01_backup.bak";
        if (nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("Palavra encontrada");
        }
        else 
        {
            Console.WriteLine("Palavra não encontrada");
        }

       // Console.WriteLine("Contém nome: "+ nomeArquivo.Contains("backup"));

    }
    public void AulaTrim()
    {
        string teste = "***Anna Maria***";

        Console.WriteLine("TRIM:" + teste.Trim('*'));
        Console.WriteLine("Inicio:" + teste.TrimStart('*'));
        Console.WriteLine("Fim:" + teste.TrimEnd('*'));
    }

    public void AulaStart()
    {
        string teste = "Anna Maria";

        Console.WriteLine("Inicio:" + teste.StartsWith("Anna"));
        Console.WriteLine("Fim:" + teste.EndsWith("Maria2"));
    }

    public void AulaReplace()
    {
        string teste = "Anna Maria";

        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("Maria", "Bittencourt"));
    }


    public void AulaLength()
    {
        string teste = "Anna Maria";

        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}

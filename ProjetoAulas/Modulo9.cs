using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores;


public class Conversor
{
    public void ConvertAndParse()
    {
        int numero = int.Parse("1");
        Console.WriteLine(numero);

        int numero2 = Convert.ToInt32("1");
        Console.WriteLine(numero2);

        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);  
    }

    public void AulaTryParse()
    {
        var numero = "abc";
        if(int.TryParse(numero,out int numeroConvertido))
        {
            Console.WriteLine("NUmero foi convertido com sucesso!");
        }

        Console.WriteLine(numeroConvertido);
    }
}

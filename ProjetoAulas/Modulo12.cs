using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo12
{
    public class TrabalhandoComExececoes
    {
        public void AulaGerandoException()
        {
            while (true)
            {
                try
            {
              
                    Console.Write("Informe um número: ");
                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine("Resultado: " + resultado);
              
            }
                catch(DivideByZeroException exception) 
                { 
                    Console.WriteLine("Ocorreu um erro de divisão" + exception.Message);
                    Console.WriteLine("Stack:" + exception.StackTrace);

                }

            catch(Exception exception)
            {
                Console.WriteLine("Ocorreu um erro" + exception.Message);
                    Console.WriteLine("Stack:" + exception.StackTrace);
            }

            }
        }
    } 
     
}

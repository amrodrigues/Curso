using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo14
{
    public class TrabalahndocomLInq
    {
       

        public void AulaWhere()
        {
            string nomeCompleto = "Anna Maria";

            Func<char, bool> filtro = c => c == 'A';

            // var resutaldo = nomeCompleto.Where(p => p == 'a');
            // var resutaldo = nomeCompleto.Where(filtro);
            var resutaldo = from c in nomeCompleto where c == 'r' select c;

            foreach (var letra in resutaldo)
            {
                Console.WriteLine(letra);
            }

            var numeros = new int[] { 16, 13, 25, 2, 9 };

            var resposta = numeros.Where(p => p >= 10);

            foreach (var numero in resposta)
            {
                Console.WriteLine(numero);
            }
        }


        public void AulaOrdenacao()
        {
            var numeros = new int[] { 16, 13, 25, 2, 9 };

            var resultado = numeros.OrderBy(p => p);

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }


            Console.WriteLine("--------------------------");

            var resultadodesc = numeros.OrderByDescending(p => p);

            foreach (var numero in resultadodesc)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("--------------------------");

            var nomes = new string[] { "Erick", "Monaliza", "Anna", "GUI" };

             var resultadonome = nomes.OrderByDescending(p => p);

            foreach (var nome in resultadonome)
            {
                Console.WriteLine(nome);
            }
        }


        public void AulaTake()
        {
            var numeros = new int[] { 16, 13, 25, 2, 9 };

            //var resultado = numeros.Take(2);

            // var resultado = numeros.Take(2).OrderBy(p => p);

            var resultado = numeros.Where(p=>p >20).Take(2).OrderBy(p => p);

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }
        }

        public void AulaCount() {

            var numeros = new int[] { 16, 13, 25, 2, 9 };

            //var resultado = numeros.Count();
            var resultado = numeros.Count(p=> p> 10);

            Console.WriteLine(resultado);


        }

        public void AulaFristOrDefault()
        {
            // usando o FristOrDefault ele não estora o erro na aplicação.


            var numeros = new int[] { 16, 13, 25, 2, 9 };

           //var numeros = new int[] { };

            //var resultado = numeros.First();

            // var resultado = numeros.First(p => p > 19);
            //var resultado = numeros.FirstOrDefault();

            //var resultado = numeros.FirstOrDefault(p => p > 193);

            var resultado = numeros.FirstOrDefault(p => p > 193, -99);


            Console.WriteLine(resultado);   
        }
    }
}

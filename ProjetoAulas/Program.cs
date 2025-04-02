using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        /*
         
        //Variáveis
        int numero1 = 2;
        int numero2 = 4;
        int Soma = numero1 + numero2;
        Console.WriteLine("Soma:" + Soma); 
        

        //Funcoes
        var nome = NomeCompleto();
        Console.WriteLine(nome);
        string NomeCompleto()
        {

            return "Anna Maria Rodrigues";
        }
        EscreverNome();
        void EscreverNome()
        {
            string nome1 = "Aloizo";
            Console.WriteLine(nome1);
        }

        var soma = SomadeValores(3, 5);
        Console.WriteLine(soma);

        int SomadeValores(int a, int b)
        {
            return  a + b;
        }

        //Lista
        var arrrylist = new ArrayList();
        arrrylist.Add(1);
        arrrylist.Add("Anna");
        arrrylist.Add(true);

        // Console.WriteLine(arrrylist[1]);

        arrrylist.RemoveAt(1);
        arrrylist.Clear();
        foreach (var i in arrrylist)
        {
            Console.WriteLine(i);
        }

        var arrayTipoNumero = new int[3] { 1, 2, 3 };

        arrayTipoNumero[1] = 10;
                
        foreach (int i in arrayTipoNumero)
        {
            Console.WriteLine(i);
         }
        
        var arrayTipoNumero = new int[3] ;

        arrayTipoNumero[0] = 1;
        arrayTipoNumero[1] = 10;
        arrayTipoNumero[2] = 5;

        Array.Resize(ref arrayTipoNumero, 100); // aumentar o tamanho do Array

        arrayTipoNumero[10] = 100;


        foreach (int i in arrayTipoNumero)
        {
            Console.WriteLine(i);
        }
       

        var lista = new List<String>(10);
        lista.Add("Anna");
        lista.Add("Aloizo");
        lista.Add("Aliete");

        var nome = lista[0];
        Console.WriteLine(nome);

        var listaNova = new List<String>(10)
        {
            "Anna",
            "Aloizo",
            "Aliete",
        };


        foreach (var item in listaNova) 
        {
            Console.WriteLine(item);
        }
        
        //Lista Genérica
        var lista = new List<string>(10);

        lista.Add("a");
        lista.Add("b");
        lista.Add("c");
        lista.Add("d");

        var alfabeto = lista[0];
        Console.WriteLine(alfabeto);

        lista.RemoveAt(3);

        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
       

        //Dicionário

        var dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Anna Maria");
        dicionario.Add(2, "Aloizo");
        dicionario[30] = "Aliete";

        var nome = dicionario[30];
        Console.WriteLine(nome);


        var diconarioAlfabeto = new Dictionary<int, string>()
        {
            { 1 , "a"},
            { 2, "b"},
        };

        foreach (var item in diconarioAlfabeto)
        {
            Console.WriteLine(item.Key);
        }

        foreach (var item in diconarioAlfabeto)
        {
            Console.WriteLine(item.Value);
        }

     
        // Queue


        var queue = new Queue<string>();
        queue.Enqueue("Anna Maria");
        queue.Enqueue("Aliete");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        //var nome = queue.Peek(); 
        var nome = queue.Dequeue();// Primeira execucao
        Console.WriteLine(nome);

        //var nome1 = queue.Peek();
        var nome1 = queue.Dequeue();//Segunda execucao
        Console.WriteLine(nome1);

     */

        //Stack

        var stack = new Stack<String>();
        stack.Push("a");
        stack.Push("b");
        stack.Push("c");
        stack.Push("d"); 
        
        //var alfabeto = stack.Pop();
        //var alfabeto2 = stack.Pop();
        //Console.WriteLine(alfabeto);
        //Console.WriteLine(alfabeto2);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

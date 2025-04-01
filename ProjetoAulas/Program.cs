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
        */

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
            
    }
}

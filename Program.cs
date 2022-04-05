using System;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));// Indice: Indica uma posição de um caracter ou de um item dentro de uma lista(Array)
            Console.WriteLine(texto.IndexOf("um"));
            Console.WriteLine(texto.IndexOf("amor"));
            Console.WriteLine(texto.IndexOf("e"));
            Console.WriteLine(texto.IndexOf("E"));// *****Lembre-se que sempre pedira do mesmo tipo*****
            Console.WriteLine(texto.LastIndexOf("s"));//LastIndexOf (Ultimo indice que ele encontrar de uma letra ou palavra)

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArvore_Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 3, 2, 1, 6, 0, 5 };
            var array2 = new[] { 7, 5, 13, 9, 1, 6, 4 };

            Console.WriteLine("Array 1 : \n");
            var array1Read = new Arvore(array1, false).ReadArray(array1);
            Console.WriteLine("[" + array1Read + "]");
            new Arvore(array1, true).PrintResultToConsole();
            Console.WriteLine("Array 2 : \n");
            var array2Read = new Arvore(array2, false).ReadArray(array2);
            Console.WriteLine("[" + array2Read + "]");
            new Arvore(array2, true).PrintResultToConsole();
            Console.WriteLine("..... Pressione qualquer tecla para encerrar o console .... \n");
            Console.ReadKey();
        }

    }
}

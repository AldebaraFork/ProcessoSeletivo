using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFonte2
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            //utilizando a sequencia de fibonacci

           
            Console.WriteLine("Digite o primeiro numero da sequencia de fibonacci");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero da sequencia de fibonacci");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
      
            //o codigo foi limitado enquanto a variavel c for menor que 100 
            while (c < 100)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

           
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esse arquivo é o exercicio feito de uma forma mais simples e sem orientação a objetos
namespace CodigoFonte1

{
    internal class Principal
    {
        static void Main(string[] args)
        {
            
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K  + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);
        }
    }
}

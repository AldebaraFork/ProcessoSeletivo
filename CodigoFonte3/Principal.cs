using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//usando a classe System.string
namespace CodigoFonte5
{
    internal class Principal
    {
        static void Main()
        {
            Console.Write("Digite uma string: ");
            string userInput = Console.ReadLine();

            string reversedString = new string(userInput.Reverse().ToArray());
            Console.WriteLine($"String invertida: {reversedString}");
        }
    }
}

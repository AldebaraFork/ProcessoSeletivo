using System;
//usando um metodo personalizado
namespace CodigoFonte5
{
    class Opcional
    {
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        
        
            Console.Write("Digite uma string: ");
            string userInput = Console.ReadLine();

            string reversedString = ReverseString(userInput);
            Console.WriteLine($"String invertida: {reversedString}");
        }
    }
}


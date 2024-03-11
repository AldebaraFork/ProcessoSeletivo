using System;

//esse arquivo é feito de uma forma um pouco mais complexa e com orientação a objetos, mas o resultado é o mesmo
namespace CodigoFonte1
{
    internal class ExercicioPOO
    {
        static void Main(string[] args)
        {
            ExercicioPOO exercicio = new ExercicioPOO();
            exercicio.Calculo();
        }

        public int INDICE = 13;
        public int SOMA = 0;
        public int k = 0;

        public void Calculo()
        {
            while (k < INDICE)
            {
                k = k + 1;
                SOMA = SOMA + k;
                Console.WriteLine("A soma é: " + SOMA);
            }
        }
    }
}

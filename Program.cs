using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos resolver sua conta de divisão, para isso:!");

            Console.Write("Digite o numerador:");
            double numerador = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Digite o denominador:");
            double denominador = Convert.ToDouble(Console.ReadLine()); 

            double resultado = numerador / denominador; 

            if (denominador == 0) 
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");
            }
        }
    }
}

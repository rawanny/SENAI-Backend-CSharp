using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] multiplicacao = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Digite um valor: ");
                multiplicacao[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("multiplicação" + multiplicacao[9] * 5);
        }
    }
}

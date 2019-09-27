using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vet1 = new int [10];
            int [] vet2 = new int [10];
            int [] vet3 = new int [20];

            for (int i = 0; i <= 9; i++){
                Console.Write("Digite um valor: ");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um valor: ");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 9; i++){
               vet3[i]=vet1[i];
               vet3[i+10]=vet2[i];
               //Console.WriteLine(vet3[i]); 
            }
            for(int i = 0; i <= 19; i++){
                Console.WriteLine(vet3[i]);
            }

        }
    }
}

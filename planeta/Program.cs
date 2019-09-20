using System;

namespace planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            String planeta, resultado;
            double peso, peso_planeta;
            Console.WriteLine("Digite seu peso no planeta Terra");
            peso = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o numero planeta que deseja saber seu peso ");
            planeta = Console.ReadLine();
            
            switch(planeta){

                case "1":
                resultado = "Planeta - Mercúrio";
                peso_planeta=(peso/10)*0.37;
                Console.WriteLine(peso_planeta);
                break;
                case "2":
                resultado = "Planeta - Vênus";
                peso_planeta=(peso/10)*0.88;
                Console.WriteLine(peso_planeta);
                break;
                case "3":
                resultado = "Planeta - Marte";
                peso_planeta=(peso/10)*0.38;
                Console.WriteLine(peso_planeta);
                break;
                case "4":
                resultado = "Planeta - Júpter";
                peso_planeta=(peso/10)*2.64;
                Console.WriteLine(peso_planeta);
                break;
                case "5":
                resultado = "Planeta - Saturno";
               peso_planeta=(peso/10)*1.15;
                Console.WriteLine(peso_planeta);
                break;
                case "6":
                resultado = "Planeta - Urano";
                peso_planeta=(peso/10)*1.17h~b;
                Console.WriteLine(peso_planeta);
                break;
            }

        }
    }
}

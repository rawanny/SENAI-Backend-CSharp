using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // somente declaramos, sem atribuir valor
            int num1;

            //declaramos atribuindo um valor
            int num2 = 5;
            //declaramos diversas variaveis de mesmo tipo
            int num3, num4 ,num5;

            //variavel do tipo decimal (real)
            float media;
            
            //variavel do tipo logico( booleana)
            bool resultado = false;

            // variavel do tipo texto caracteres
            string nomeAluno;


            //Quebra linha
            Console.WriteLine();

            //Escreve em uma linha uebrando-a
            Console.WriteLine("Bem Vindos a nossa primeira aplicação!");

            //Continua Escrevendo na mesma linha
            Console.Write("Digite");
            Console.Write(" seu nome: ");

            // Capturo o dado digitado pelo usuário e salvo na variável
            nomeAluno = Console.ReadLine();

            // Concatenação
            Console.WriteLine(nomeAluno + " , Agora Digite sua primeira nota:");


            num3 = int.Parse(Console.ReadLine());

            // Interpolação
            Console.WriteLine($"Sua Primeira Nota é {num3}");

            Console.WriteLine("Digite sua segunda nota: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota: ");
            num5 = int.Parse(Console.ReadLine());

            media = (num3 + num4 + num5) / 3;

            Console.WriteLine(nomeAluno + " sua média é: " + media);


        }
    }
}

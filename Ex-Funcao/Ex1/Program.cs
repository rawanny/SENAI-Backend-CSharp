using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[]args){
             Console.Write("Digite o valor: ");
           Double valor = double.Parse(Console.ReadLine());
            Console.Write("Digite a porcentagem: ");
            Double porcentagem = double.Parse(Console.ReadLine());
            
           Console.WriteLine(desconto(valor, porcentagem));

        } 
        public static Double desconto (Double valor, Double porcentagem)
        {
            
            Double resultado;
            
            resultado = (valor*porcentagem)/100;
            valor -= resultado;
            return resultado;
        }
    }
}

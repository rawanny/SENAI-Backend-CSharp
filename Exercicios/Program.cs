using System;

namespace Exercicios
{
    class Exercicio_1
    {
        static void Main(string[] args)
        {
            float resultado, salario, despesa;
            String retorno;

            Console.WriteLine("Digite seu salário");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas despesas");
            despesa = float.Parse(Console.ReadLine());

            resultado = salario - despesa;

            if(resultado > 0){
                retorno = "Superávit";
            }else{
                retorno = "Déficit";
            }
            Console.WriteLine("Seu saldo é " + retorno);
            
        }
    }
}

using System;

namespace sanduiche
{
    class Program
    {
        static void Main(string[] args)
        {
            String pedido, resultado;
           
            Console.WriteLine("Digite o número de seu pedido");
            pedido = Console.ReadLine();

            if(pedido == "1"){
                resultado = "Seu pedido é Hamburguer";
            }else if(pedido == "2"){
                resultado = "Seu pedido é Cheese Salada";
            }else if(pedido == "3"){
                resultado = "Seu pedido é Cheese Burguer";
            }else if(pedido == "4"){
                resultado = "Seu pedido é Cheese Bacon";
            }else{
                resultado = "Opção Inválida";
            }
            Console.WriteLine(resultado);
        }
    }
}

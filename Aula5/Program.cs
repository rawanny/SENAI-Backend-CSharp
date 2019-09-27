﻿using System;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];

            string sair = "";
            while(sair != "0"){
                
                Console.WriteLine(" Bem Vindo ao nosso sistema de Passagens!");
                Console.WriteLine(@" Menu: 1- Cadastrar                                           2- Listar Passagens                             0- Sair");

                sair = Console.ReadLine();

                switch(sair){
                    case "1":
                        for(int i = 0; i <= 4; i++){
                            Console .Write("Entre com nome de passageiro: ");
                            nome[i] = Console.ReadLine();

                            Console.Write("Digite a UF de origem: ");
                            origem[i] = Console.ReadLine();

                            Console.Write("Digite a UF de destino: ");
                            destino[i] = Console.ReadLine();

                            Console.Write("Digite a data de IDA: ");
                            data_ida[i] = DateTime.Parse(Console.ReadLine());

                            Console.Write("Digite a data de VOLTA: ");
                            data_volta[i] = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Dados cadastrados com sucesso! :) ");
                        }
                    break;  

                    case "2":
                        for(int i = 0; i <= 4; i++){
                            if(nome[i] != "" && origem[i] != "" && destino[i] != "" && data_ida[i] != null && data_volta != null){
                                Console.WriteLine();
                                Console.WriteLine("Passagem Nº" + i+1);
                                Console.WriteLine(nome[i]);
                                Console.WriteLine(origem[i]);
                                Console.WriteLine(destino[i]);
                                Console.WriteLine(data_ida[i]);
                                Console.WriteLine(data_volta[i]);
                                Console.WriteLine();
                            }
                        }
                    break;     

                    case "0":
                        Console.WriteLine("Obrigado por utilizar nosso sistemas! ;) ");
                    break; 

                    default:
                        Console.WriteLine("Entrada inválida! ");
                    break;    
                }
            }
        }
    }
}

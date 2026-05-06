using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Centro_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Console.BackgroundColor = ConsoleColor.Yellow;
            while (opcao != 4)

            {
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.Red; //corzinha legal


                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\n Seja bem vindo ao centro Pokemon!\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastrar pokemon");
                Console.WriteLine("\n 2 - Consultar pokemon");
                Console.WriteLine("\n 3 - Apagar pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Sair");
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(" \nDigite a opção esolhida \n");
                opcao = int.Parse(Console.ReadLine()); //int.parse = converter pra numero

                switch (opcao)
                {

                    case 1:
                        
                        CadastroPokemon(); //abre função

                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        Console.ForegroundColor= ConsoleColor.Blue;
                        Console.WriteLine("Adeus mestre pokemon!!");
                        Thread.Sleep(3000);
                        break;




                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
█▀█ █▀█ █▀▀ ▄▀█ █▀█   █ █▄ █ █ █ ▄▀█ █   █ █▀▄ ▄▀█
█▄█ █▀▀ █▄▄ █▀█ █▄█   █ █ ▀█ ▀▄▀ █▀█ █▄▄ █ █▄▀ █▀█");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();

                        break;
                }





            }

           


        }

        static void CadastroPokemon()
        {

            int kkk = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n digite o nome do seu Pokemon: ");
            string nomepokemon = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n digite o tipo do seu Pokemon: ");
            string tipopokemon = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n digite o tamanho do seu Pokemon: ");
            double alturapokemon = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n digite o peso do seu Pokemon: ");
            double pesopokemon = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("quantas fraquezas ele tem?");
            Console.ForegroundColor = ConsoleColor.Black;
            int quantidadefraquezapokemon = int.Parse(Console.ReadLine());


            for (int i = 1; i < quantidadefraquezapokemon; i++)
            {
                if (i < 7 && i > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 1} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon1 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 2} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 3} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon3 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 4} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon4 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 5} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon5 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 6} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon6 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Fraqueza {i = 7} :");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string fraquezapokemon7 = Console.ReadLine();
                }

                else
                {

                }



            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("quantas fraquezas ele tem?");
            Console.ForegroundColor = ConsoleColor.Black;
            int quantidadeevolucaopokemon = int.Parse(Console.ReadLine());



        }



    }
}

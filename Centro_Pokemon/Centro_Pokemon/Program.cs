using System;
using System.Collections.Generic;
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

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n Seja bem vindo ao centro Pokemon!\n");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - Cadastrar pokemon");
                Console.WriteLine("\n 2 - Consultar pokemon");
                Console.WriteLine("\n 3 - Apagar pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Sair");
                Console.ForegroundColor = ConsoleColor.White;
                opcao = int.Parse(Console.ReadLine()); //int.parse = converter pra numero

                switch (opcao)
                {

                    case 1:
                        
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
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();

                        break;
                }





            }

        }
    }
}

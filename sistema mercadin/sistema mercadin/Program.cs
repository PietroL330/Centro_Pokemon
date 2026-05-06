using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sistema_mercadin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            Console.BackgroundColor = ConsoleColor.DarkRed;


            while (escolha != 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"
 █▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 █▀▀ █  █ █▀▀█ █▀▀ █▀▀█ █▀▄▀█  ▀  █▀▀█ █  █ █▀▀ █▀▀█ █▀▀▄ █▀▀█ 
 █   █▄▄█ █  █ █▄▄█ ▀▀█   █   █▄▄▀ █  █ 　 ▀▀█ █  █ █  █ █▀▀ █▄▄▀ █ ▀ █ ▀█▀ █▄▄█ █  █ █   █▄▄█ █  █ █  █ 
 ▀▀▀ ▀  ▀ ▀▀▀  ▀  ▀ ▀▀▀   ▀   ▀ ▀▀ ▀▀▀▀ 　 ▀▀▀ ▀▀▀▀ █▀▀▀ ▀▀▀ ▀ ▀▀ ▀   ▀ ▀▀▀ ▀  ▀ ▀▀▀▀ ▀▀▀ ▀  ▀ ▀▀▀  ▀▀▀▀ ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n 1 - Miaucadorias(mercadorias/produtos");
                Console.WriteLine("\n 2 - Gatolientes(clientes)");
                Console.WriteLine("\n 3 - Gatonarios(funcionarios)");
                Console.WriteLine("\n 4 - felinedores(Fornecedores)");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n 5 - Sair");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Digite sua escolha: ");
                Console.ForegroundColor = ConsoleColor.Black;
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        produtosmiaucado();


                        break;

                    case 2:

                        clientesmiaucado();

                        break;

                    case 3:
                        funcionariosmiaucado();


                        break;

                    case 4:
                        felinedoresmiaucado();
                        break;

                    case 5:

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(@"
  █▀█ █▀█ █▀▀ ▄▀█ █▀█   █ █▄ █ █ █ ▄▀█ █   █ █▀▄ ▄▀█
  █▄█ █▀▀ █▄▄ █▀█ █▄█   █ █ ▀█ ▀▄▀ █▀█ █▄▄ █ █▄▀ █▀█");
                        Thread.Sleep(2000);


                        break;

                }



            }



        }


        static void produtosmiaucado()
        {

            Console.Clear();
           
            string nomemercadoria, marcamercadoria, quantidade, pesagem, fornecedormercadoria;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
░█▀▄▀█ ─▀─ █▀▀█ █──█ █▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀█ ─▀─ █▀▀█ █▀▀ 
░█░█░█ ▀█▀ █▄▄█ █──█ █── █▄▄█ █──█ █  █ █▄▄▀ ▀█▀ █▄▄█ ▀▀█ 
░█──░█ ▀▀▀ ▀──▀ ─▀▀▀ ▀▀▀ ▀──▀ ▀▀▀─ ▀▀▀▀ ▀ ▀▀ ▀▀▀ ▀──▀ ▀▀▀");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual a mercadoria?");
            nomemercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual a marca da mercadoria?");
            marcamercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o fornecedor?");
            fornecedormercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual a quantidade?");
            quantidade =Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n peso por unidade ou quantidade por unidade?");
            pesagem = Console.ReadLine();


            Console.WriteLine("\n Miaucadoria registrada com sucesso!");
            Thread.Sleep(4000);

        }


        static void clientesmiaucado()
        {

            Console.Clear();
           
            string nomemercadoria, marcamercadoria, quantidade, fornecedormercadoria;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
░█▀▀█ █▀▀█ ▀▀█▀▀ █▀▀█ █── ─▀─ █▀▀ █▀▀▄ ▀▀█▀▀ █▀▀ █▀▀ 
░█─▄▄ █▄▄█ ──█── █──█ █── ▀█▀ █▀▀ █──█ ──█── █▀▀ ▀▀█ 
░█▄▄█ ▀──▀ ──▀── ▀▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀──▀ ──▀── ▀▀▀ ▀▀▀");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o nome do cliente?");
            nomemercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o telefone do cliente?");
            marcamercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CEP do cliente?");
            fornecedormercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CPF do cliente?");
            quantidade =Console.ReadLine();

            

            Console.WriteLine("\n Gatoliente registrado com sucesso!");
            Thread.Sleep(4000);

        }


        static void funcionariosmiaucado()
        {

            Console.Clear();
           
            string nomemercadoria, marcamercadoria, fornecedormercadoria, quantidade, funcao, hora;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
▒█▀▀█ █▀▀█ ▀▀█▀▀ █▀▀█ █▀▀▄ █▀▀█ █▀▀█ ░▀░ █▀▀█ █▀▀ 
▒█░▄▄ █▄▄█ ░░█░░ █░░█ █░░█ █▄▄█ █▄▄▀ ▀█▀ █░░█ ▀▀█ 
▒█▄▄█ ▀░░▀ ░░▀░░ ▀▀▀▀ ▀░░▀ ▀░░▀ ▀░▀▀ ▀▀▀ ▀▀▀▀ ▀▀▀");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o nome do gatonario?");
            nomemercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o telefone do gatonario?");
            marcamercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CEP do gatonario?");
            fornecedormercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CPF do gatonario?");
            quantidade = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o a função do gatonario?");
            funcao = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual os horarios do gatonario?");
            hora = Console.ReadLine();



            Console.WriteLine("\n Gatonario registrado com sucesso!");
            Thread.Sleep(4000);

        }


        static void felinedoresmiaucado()
        {

            Console.Clear();
            
            string nomemercadoria, marcamercadoria, fornecedormercadoria, quantidade, funcao, hora;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
█▀▀ █▀▀ █░░ ░▀░ █▀▀▄ █▀▀ █▀▀▄ █▀▀█ █▀▀█ █▀▀ █▀▀ 
█▀▀ █▀▀ █░░ ▀█▀ █░░█ █▀▀ █░░█ █░░█ █▄▄▀ █▀▀ ▀▀█ 
▀░░ ▀▀▀ ▀▀▀ ▀▀▀ ▀░░▀ ▀▀▀ ▀▀▀░ ▀▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o nome do felinedor?");
            nomemercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o telefone do felinedor");
            marcamercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CEP do felinedor?");
            fornecedormercadoria = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o CNPJ do felinedor");
            quantidade = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n qual o a mercadoria fornecida pelo felinedor");
            funcao = Console.ReadLine();

            



            Console.WriteLine("\n Felinedor registrado com sucesso!");
            Thread.Sleep(4000);

        }







    }
}  


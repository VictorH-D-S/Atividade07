using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade07_Cadastro_Usuarios
{
    class Program
    {
        static List<string> nomes = new List<string>();
        static int quant = nomes.Count;

        static void Main(string[] args)
        {

            
            
            Console.WriteLine("=================== SISTEMA DE USUÁRIOS ===================");
            Console.WriteLine("1- Cadastrar novo usuário");
            Console.WriteLine("2- Buscar usuário existente");
            Console.WriteLine("3- Deletar usuário existente");
            Console.WriteLine("4- Alterar usuário existente");
            Console.WriteLine("5- Listar todos os usuários cadastrados");
            Console.Write("O que deseja fazer? ");
            string escolha = Console.ReadLine();

            //1- CADASTRO 
            if (escolha == "1")
            {
                    Console.WriteLine("======== SISTEMA DE CADASTO =========");
                    Console.Write("Digite o nome do usuário a ser cadastrado: ");
                    string nome = Console.ReadLine();
                    nomes.Add(nome);
                    Console.WriteLine("Usuário cadastrado com sucesso!");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;
            }
            //2- BUSCA
            if (escolha == "2")
            {

                if (nomes.Count == 0)
                {   

                    Console.WriteLine("A lista ainda esta vazia...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

                    Console.WriteLine("======== SISTEMA DE BUSCA =========");
                    Console.WriteLine($"Usuários cadastrados no sistema: {nomes.Count}");
                    Console.Write("Digite o índice para efetuar uma busca: ");
                    int posicao = int.Parse(Console.ReadLine());

                    if (posicao >= 1 && posicao <= nomes.Count)
                    {
                        // Quer ouvir uma piada Murray?
                        Console.WriteLine($"O usuário foi -> Localizado <-");
                        Console.WriteLine($"Nome: {nomes[posicao - 1]} ");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        return;

                    }

                    else
                    {

                        Console.WriteLine("Posição inválida.");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                        return;

                    }

            }

            // Deletamento
            if (escolha == "3")
            {

                if (nomes.Count <= 0)
                {

                    Console.WriteLine("A lista ainda esta vazia...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

                Console.WriteLine("======== SISTEMA DE DELETAMENTO =========");
                Console.WriteLine($"Usuários cadastrados no sistema: {nomes.Count}");
                Console.Write("Digite o índice para efetuar o deletamento: ");
                int posicao = int.Parse(Console.ReadLine());

                if (posicao >= 1 && posicao <= nomes.Count)
                {
                    // Please, call me Gus.
                    nomes.RemoveAt(posicao - 1);
                    Console.WriteLine("Usuário deletado com sucesso...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

                else
                {

                    Console.WriteLine("Posição inválida.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            //Alteração
            if (escolha == "4")
            {

                if (nomes.Count <= 0)
                {

                    Console.WriteLine("A lista ainda esta vazia...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

                Console.WriteLine("======== SISTEMA DE ALTERAÇÃO =========");
                Console.WriteLine($"Usuários cadastrados no sistema: {nomes.Count}");
                Console.Write("Digite o índice para efetuar a alteração: ");
                int posicao = int.Parse(Console.ReadLine());

                if (posicao >= 1 && posicao <= nomes.Count)
                {

                    // I am the danger.
                    Console.Write("Insira o novo nome de usuário: ");
                    string nome2 = Console.ReadLine();
                    nomes[posicao - 1] = nome2;
                    Console.WriteLine("O nome foi modificado com sucesso...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

                else
                {

                    Console.WriteLine("Posição inválida.");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }           

            }

            //Listagem
            if (escolha == "5")
            {
                if (nomes.Count <= 0)
                {

                    Console.WriteLine("A lista ainda esta vazia...");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }
                else
                {
                    Console.WriteLine($"\nUsuários cadastrados no sistema: {nomes.Count}");
                    int posicao = 1;
                    while (posicao <= nomes.Count)
                    {

                        string nome = nomes[posicao - 1];
                        Console.WriteLine($"\n{posicao}- {nome}");
                        posicao++;                        

                    }

                    Console.WriteLine("\n============== FIM DA LISTA ==============");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);

                }

            }

            else
            {

                Console.WriteLine("Opção inválida. Digite o número da opção que deseja acessar.");
                Console.ReadKey();
                Console.Clear();
                Main(args);
                return;

            }
            Console.ReadKey();         
        }
    }
}
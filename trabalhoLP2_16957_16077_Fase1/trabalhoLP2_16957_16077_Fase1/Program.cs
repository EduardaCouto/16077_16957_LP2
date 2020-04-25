using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            int opcao = -1;
            int idade;
            string concelho;
            char genero;
      
            #endregion

            #region Metodos adicionais
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tMENU:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t1 - Atualizar dados");
            Console.WriteLine("\t2 - Consultar dados");
            Console.Write("\t3 - Sair");
            Console.WriteLine("");
            Console.WriteLine("Introduza o numero da opcao: ");
            opcao = Int32.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tATUALIZAR DADOS");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("\t1 - Adicionar novos casos infetados");
                    Console.WriteLine("\t2 - Adicionar novos casos mortos");
                    Console.WriteLine("\t3 - Adiconar casos de pacientes recuperados");
                    Console.WriteLine("");
                    Console.WriteLine("\tOpcao: ");
                    opcao = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    if(opcao == '1')
                    {
                        Console.Write("\nIdade: ");
                        idade = Console.ReadLine();
                        Console.Write("nConcelho: ");
                        Concelho = Console.ReadLine();
                        Console.WriteLine("\nGenero:");
                        genero = Console.ReadLine();
                        Console.Clear();
                        //Cria um novo caso infetado
                        Infetados newInf = new Infetados(idade, concelho, genero);
                        //Regista o novo caso
                        Console.WriteLine(Infetados.RegistarInf);
                        
                    }
                    else if(opcao == '2')
                    {
                        Console.Write("\nIdade: ");
                        idade = Console.ReadLine();
                        Console.Write("nConcelho: ");
                        Concelho = Console.ReadLine();
                        Console.WriteLine("\nGenero:");
                        genero = Console.ReadLine();
                        Console.Clear();
                    }
                    else (opcao == '3')
                    {
                        Console.Write("\nIdade: ");
                        idade = Console.ReadLine();
                        Console.Write("\nConcelho: ");
                        Concelho = Console.ReadLine();
                        Console.WriteLine("\nGenero:");
                        genero = Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tATUALIZAR DADOS");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.WriteLine("\t1 - Consultar numero total de casos infetados);
                    Console.WriteLine("\t2 - Consultar numero de casos infetados por concelho");
                    Console.WriteLine("\t3 - Consultar numero total de pacientes recuperados");
                    Console.WriteLine("\t4 - Consultar numero de pacinetes recuperados por concelho");
                    Console.WriteLine("\t5 - Consultar numero de casos infetados por genero");
                    Console.WriteLine("\t6 - Consultar media de idades dos infetados");
                    Console.WriteLine("\t7 - Consultar numero de infetados com mais de 70 anos");
                    Console.WriteLine("");
                    Console.WriteLine("\tOpcao: ");
                    opcao = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    if (opcao == '1')



            }
           

            #endregion






        }
    }
}

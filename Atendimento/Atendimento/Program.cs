using System;

namespace ReposicaoDeAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;


                Tela.BemVindo();
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Tela.MontaTelaMedico();
                        Console.ReadKey();

                        break;
                    case 2:
                       
                        Tela.MontaTelaPaciente();
                        
                        Console.ReadKey();
                        break;
                    case 3:
                        
                        Tela.MontaTelaConsulta();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida\nTente novamente.");
                        Console.ReadKey();
                        break;
                }
           
            
            }
        }
    }


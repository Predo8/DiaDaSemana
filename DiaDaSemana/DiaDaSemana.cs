using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using DiaDaSemana;

namespace diaDaSemana
{
    class DiaDaSemana
    {
        public enum DiaSemana
        {
            Domingo = 1,
            Segunda = 2,
            Terça = 3,
            Quarta = 4,
            Quinta = 5,
            Sexta = 6,
            Sabado = 7,
        }

        public static int Menu()
        {
            string operacao;
            var menuOp = new MenuOp();
            bool validador = false;
            menuOp.MostrarMenu();
            decimal opcao;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Opção: ");
                operacao = Console.ReadLine();
                if (operacao == "1")
                {
                    validador = true;
                }
                else if (operacao == "2")
                {
                    validador = true;
                }
                else if (operacao == "3")
                {
                    validador = true;
                }
                else if (operacao == "4")
                {
                    validador = true;
                }
                else if (operacao == "5")
                {
                    validador = true;
                }
                else if (operacao == "6")
                {
                    validador = true;
                }
                else if (operacao == "7")
                {
                    validador = true;
                }
                else if (operacao == "8")
                {
                    validador= true;
                }
                else
                {
                    Console.WriteLine("Opção invalida! Tente novamente!");
                    validador = false;
                }

            } while (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "6" && operacao != "7" &&  operacao != "8");
            return Convert.ToInt32(operacao);

        }
        public static void Main()
        {
            string entrada;
            int opcao;
            bool valido, valida;
            var menuOp = new MenuOp();
            var versao = new Menu();
            versao.ApresentarHora();

            opcao = 0;
            while (opcao != 8)
            {
                opcao = Convert.ToInt32(Menu());
                switch (opcao)
                {
                    case 1:
                        do
                        {
                            DiaSemana semana1 = DiaSemana.Domingo;
                            int i1 = (int)DiaSemana.Domingo;

                            Console.WriteLine(semana1);
                            Console.WriteLine(i1);
                            valida = true;


                        } while (!valida);
                        Console.WriteLine("Voltando para o menu.");
                        Console.ReadKey();
                        break;

                    case 2:
                        do
                        {
                            DiaSemana semana2 = DiaSemana.Segunda;
                            int i2 = (int)DiaSemana.Segunda;

                            Console.WriteLine(semana2);
                            Console.WriteLine(i2);
                            valida = true;
                        } while (!valida);
                        Console.WriteLine("Voltando para o menu.");
                        Console.ReadKey();
                        break;

                    case 3:
                        do
                        {
                            DiaSemana semana3 = DiaSemana.Terça;
                            int i3 = (int)DiaSemana.Terça;


                            Console.WriteLine(semana3);
                            Console.WriteLine(i3);
                            valida = true;

                        } while (!valida);
                        Console.WriteLine("Voltando para o menu. Pressione Qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 4:
                        do
                        {
                            DiaSemana semana4 = DiaSemana.Quarta;
                            int i4 = (int)DiaSemana.Quarta;

                            Console.WriteLine(semana4);
                            Console.WriteLine(i4);
                            valida = true;
                        } while (!valida);
                        Console.WriteLine("Voltando para o menu. Pressione Qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 5:
                        do
                        {
                            DiaSemana semana5 = DiaSemana.Quinta;
                            int i5 = (int)DiaSemana.Quinta;

                            Console.WriteLine(semana5);
                            Console.WriteLine(i5);
                            valida = true;
                        } while (!valida);
                        Console.WriteLine("Voltando para o menu. Pressione Qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 6:
                        do
                        {
                            DiaSemana semana6 = DiaSemana.Sexta;
                            int i6 = (int)DiaSemana.Sexta;

                            Console.WriteLine(semana6);
                            Console.WriteLine(i6);
                            valida = true;
                        } while (!valida);
                        Console.WriteLine("Voltando para o menu. Pressione Qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 7:
                        do
                        {
                            DiaSemana semana7 = DiaSemana.Sabado;
                            int i7 = (int)DiaSemana.Sabado;

                            Console.WriteLine(semana7);
                            Console.WriteLine(i7);
                            valida = true;

                        } while (!valida);
                        Console.WriteLine("Voltando para o menu. Pressione Qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.WriteLine("Obrigado por usar o programa :D");
                        break;
                     
                        if (opcao >= 9 || opcao <= 0) ;
                        {
                            Console.WriteLine("Digite um valor válido");
                        }
                }
            }
        }
    }
}

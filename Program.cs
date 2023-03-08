using System;

namespace CalculadoraCombustivel
{

    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Oque você deseja fazer ?");
            Console.WriteLine("----------");
            Console.WriteLine("1 - Calcular qual combustível para abastecer ?");
            Console.WriteLine("2 - Calcular quantos Km seu carro está fazendo ?");
            Console.WriteLine(" ");
            Console.WriteLine("3 - Sair");


            Console.WriteLine("---------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Abastecimento(); break;
                case 2: Consumo(); break;
                case 3: System.Environment.Exit(0); break;
                default:
                    Menu(); break;

                    static void Consumo()
                    {
                        Console.Clear();
                        Console.WriteLine("Digite quantos litros você abasteceu:");
                        float v1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite quantos km você rodou antes de abastecer novamente:");
                        float v2 = float.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        float resultado = v2 / v1;

                        {

                            if (resultado <= 8.0)

                                Console.WriteLine($"Seu carro está bebendo muito fez {resultado} km/l");

                            else

                                Console.WriteLine($"Seu carro está econômico esta fazendo {resultado} km/l");

                            Console.ReadKey();
                            Menu();
                        }
                    }
            }
            static void Abastecimento()
            {
                Console.Clear();

                Console.WriteLine("Digite o valor do Etanol:");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da Gasolina");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                float resultado = v1 / v2;

                {

                    if (resultado <= 0.7)

                        Console.WriteLine("Está comepsando abastecer com o Etanol");

                    else
                        Console.WriteLine("Está compensando abastecer Gasolina");

                    Console.ReadKey();
                    Menu();


                }
            }
        }



    }

}



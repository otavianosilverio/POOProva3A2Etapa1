using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProva3A2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Resolução da Prova Tipo B
            //////////////////////////////////////
            Random random = new Random();
            int[] q1_xx = new int[10];

            int media_numeros = 0, soma_numeros = 0, qtdePares = 0;

            for (int i = 0; i < 10; i++)
            {
                q1_xx[i] = random.Next(0, 50);
                soma_numeros = soma_numeros + q1_xx[i];

                Console.WriteLine("Q1_xx -> " + i + " - " + q1_xx[i] + "\t");
            }
            media_numeros = (soma_numeros / 10);
            Console.WriteLine("A média é igual -> " + media_numeros + "\t");
            // Verificando numeros pares maior que a média
            for (int i = 0; i < 10; i++)
            {
                // Verificando se o numero é par e maior que a média.
                if ((q1_xx[i] % 2 == 0) && (q1_xx[i] > media_numeros)) {
                    qtdePares = qtdePares + 1;
                    Console.WriteLine("Número Par acima da Médida -> " + q1_xx[i] + "\t");
                }
            }
            Console.WriteLine("Qtde de Números Pares Acima da Média -> " + qtdePares + "\n");
            Console.ReadKey();

            //// 
            ///// Resolução da Prova Tipo A
            //////////////////////////////////////

            int[] q2_xx = new int[10];

            media_numeros = 0;
            soma_numeros = 0;
            int qtde_abaixoMedia = 0;

            for (int i = 0; i < 10; i++)
            {
                q2_xx[i] = random.Next(0, 50);
                soma_numeros = soma_numeros + q2_xx[i];

                Console.WriteLine("Q2_xx -> " + i + " - " + q2_xx[i] + "\t");
            }
            media_numeros = (soma_numeros / 10);
            Console.WriteLine("A média é igual -> " + media_numeros + "\t");
            // Verificando numeros menores que a média
            for (int i = 0; i < 10; i++)
            {
                // Verificando se o numero é par e maior que a média.
                if (q2_xx[i] < media_numeros)
                {
                    qtde_abaixoMedia = qtde_abaixoMedia + 1;
                    Console.WriteLine("Número Abaixo da Médida -> " + q2_xx[i] + "\t");
                }
               
            
            }

             Console.WriteLine("Qtde de Números Abaixo da Média -> " + qtde_abaixoMedia + "\n");
             Console.ReadKey();


        }

        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_c
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {

                int numero = 5;

                Console.WriteLine($"Tabuada do {numero}:");


                Console.WriteLine("Adição:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero + i;
                    Console.WriteLine($"{numero} + {i} = {resultado}");
                }


                Console.WriteLine("\nSubtração:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero - i;
                    Console.WriteLine($"{numero} - {i} = {resultado}");
                }


                Console.WriteLine("\nMultiplicação:");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }


                Console.WriteLine("\nDivisão:");
                for (int i = 1; i <= 10; i++)
                {

                    if (i != 0)
                    {
                        double resultado = (double)numero / i;
                        Console.WriteLine($"{numero} / {i} = {resultado}");
                    }
                }
            }
        }
    }

















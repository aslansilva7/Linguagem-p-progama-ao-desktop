using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_10
{
   
    
     
        
     

class Program
        {
            static void Main()
            {
                Console.WriteLine("Verificador de Relacionamentos de Ordem");

               
                Console.Write("Digite o primeiro número inteiro: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

               
                Console.Write("Digite o segundo número inteiro: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

              
                Console.WriteLine("\nRelacionamentos de Ordem:");

                if (numero1 == numero2)
                {
                    Console.WriteLine("Os números são iguais");
                }
                else
                {
                    Console.WriteLine("Os números são diferentes");

                    if (numero1 > numero2)
                    {
                        Console.WriteLine($"{numero1} é maior que {numero2}");
                        Console.WriteLine($"{numero2} é menor que {numero1}");
                    }
                    else
                    {
                        Console.WriteLine($"{numero1} é menor que {numero2}");
                        Console.WriteLine($"{numero2} é maior que {numero1}");
                    }

                    Console.WriteLine($"{numero1} é maior ou igual a {numero2}");
                    Console.WriteLine($"{numero2} é maior ou igual a {numero1}");

                    Console.WriteLine($"{numero1} é menor ou igual a {numero2}");
                    Console.WriteLine($"{numero2} é menor ou igual a {numero1}");
                }

                Console.ReadLine(); 
            }
        }

    }



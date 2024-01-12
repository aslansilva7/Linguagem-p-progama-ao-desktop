using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tubuadavar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Calculadora Simples");

                // Solicita ao usuário para inserir dois números
                Console.Write("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Exibe o menu de operações
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");

                // Solicita ao usuário para escolher uma operação
                Console.Write("Digite o número da operação desejada: ");
                int escolha = Convert.ToInt32(Console.ReadLine());

                // Realiza a operação escolhida
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1} x {num2} = {num1 * num2}");
                        break;
                    case 4:
                        // Certifica-se de evitar a divisão por zero
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        break;
                }
            }
        }

    }
}


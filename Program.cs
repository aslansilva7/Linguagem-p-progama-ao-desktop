using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_1_aslan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Program
        {
            static void Main()
            {
                Console.WriteLine("Digite um número inteiro (de 0 a 99):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number) && number >= 0 && number < 100)
                {
                    string numberInWords = ConvertNumberToWords(number);
                    Console.WriteLine($"Número por extenso: {numberInWords}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro no intervalo de 0 a 99.");
                }
            }

            static string ConvertNumberToWords(int number)
            {
                string[] units = { "", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove" };
                string[] teens = { "Dez", "Onze", "Doze", "Treze", "Catorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove" };
                string[] tens = { "", "", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };

                if (number < 10)
                {
                    return units[number];
                }
                else if (number < 20)
                {
                    return teens[number - 10];
                }
                else
                {
                    int unit = number % 10;
                    int ten = number / 10;

                    if (unit > 0)
                    {
                        return $"{tens[ten]} e {units[unit]}";
                    }
                    else
                    {
                        return tens[ten];
                    }
                }
            }
        }

    }
}
    }
}

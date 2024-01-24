using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio._5
{

    
    
        
class Program
        {
            static void Main()
            {
                Console.WriteLine("Conversor de Temperatura Fahrenheit para Celsius");

          
                Console.Write("Digite a temperatura em graus Fahrenheit: ");
                double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

      
                double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

              
                Console.WriteLine($"Temperatura em graus Celsius: {temperaturaCelsius:F2} °C");

                Console.ReadLine(); 
            }
        }

    }



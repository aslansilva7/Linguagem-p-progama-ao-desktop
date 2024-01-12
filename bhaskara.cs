using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhaskara
{
    internal class Program
    {
        static void Main(string[] args)

        {
          Console.WriteLine("bhaskara");
          Console.ReadLine();
            int a = 1;
            int b = -3;
            int c = -4;

            
            double delta = b * b - 4 * a * c;

           
            if (delta >= 0)
            {
                double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

               
                Console.WriteLine("a1 = " + a1 + "\na2 = " + a2);
            }
            else
            {
                Console.WriteLine("A equação não possui raízes reais, pois o delta é negativo.");
                Console.ReadLine();
            }

        }
    }
}

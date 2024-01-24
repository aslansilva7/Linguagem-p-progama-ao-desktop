using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
   
    
       
        
           

class Program
        {
            static void Main()
            {
                Console.WriteLine("Calculadora de Idade em Dias");

                
                Console.Write("Digite a idade em anos: ");
                int anos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a idade em meses: ");
                int meses = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a idade em dias: ");
                int dias = Convert.ToInt32(Console.ReadLine());

               
                int idadeEmDias = (anos * 365) + (meses * 30) + dias;

             
                Console.WriteLine($"A idade em dias é: {idadeEmDias} dias");

                Console.ReadLine(); 
            }
        }

    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMISSAO
{
   
    
    
        
        

class Program
        {
            static void Main()
            {
                Console.WriteLine("Calculadora de Pagamento de Comissão para Vendedores de Peças");

              
                Console.Write("Digite a identificação do vendedor: ");
                string identificacaoVendedor = Console.ReadLine();

                Console.Write("Digite o código da peça: ");
                string codigoPeca = Console.ReadLine();

                Console.Write("Digite o preço unitário da peça: ");
                double precoUnitario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade vendida: ");
                int quantidadeVendida = Convert.ToInt32(Console.ReadLine());


                double valorTotalVenda = precoUnitario * quantidadeVendida;

                
                double comissao = 0.05 * valorTotalVenda;

                
                Console.WriteLine("\nResumo da Venda:");
                Console.WriteLine($"Identificação do Vendedor: {identificacaoVendedor}");
                Console.WriteLine($"Código da Peça: {codigoPeca}");
                Console.WriteLine($"Preço Unitário: R$ {precoUnitario:F2}");
                Console.WriteLine($"Quantidade Vendida: {quantidadeVendida}");
                Console.WriteLine($"Valor Total da Venda: R$ {valorTotalVenda:F2}");
                Console.WriteLine($"Comissão (5%): R$ {comissao:F2}");

                Console.ReadLine(); 
        }

    }
}


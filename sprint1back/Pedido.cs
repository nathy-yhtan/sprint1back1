using System;
using System.Collections.Generic;

namespace sprint1back
{
    public class Pedido
    {
        // Propriedade para armazenar o nome do cliente
        public string NomeCliente { get; set; }

        public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

        public void AdicionarItem(ItemCardapio item)
        {
            Itens.Add(item);
            Console.WriteLine($"\n[+] {item.Descricao} adicionado ao pedido!");
        }

        public double CalcularTotalPedido()
        {
            double total = 0;
            foreach (var item in Itens)
            {
                total += item.CalcularPrecoFinal();
            }
            return total;
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n================ RESUMO DO PEDIDO ================");

            // Exibe o nome do cliente se estiver preenchido
            if (!string.IsNullOrEmpty(NomeCliente))
            {
                Console.WriteLine($"CLIENTE: {NomeCliente.ToUpper()}");
                Console.WriteLine("--------------------------------------------------");
            }

            if (Itens.Count == 0)
            {
                Console.WriteLine("Nenhum item no pedido no momento.");
            }
            else
            {
                foreach (var item in Itens)
                {
                    Console.WriteLine($"- {item.Descricao} | Valor: R$ {item.CalcularPrecoFinal():F2}");
                }
                Console.WriteLine($"\nTOTAL FINAL: R$ {CalcularTotalPedido():F2}");
            }
            Console.WriteLine("==================================================");
        }
    }
}

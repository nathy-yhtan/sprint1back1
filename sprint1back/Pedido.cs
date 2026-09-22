using System;
using System.Collections.Generic;

namespace sprint1back
{
    public class Pedido
    {
        public string NomeCliente { get; set; } //pra no final aparecer na "notinha"

        public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

        public void AdicionarItem(ItemCardapio item)
        {
            Itens.Add(item);
            Console.WriteLine($"\n{item.Descricao} adicionado ao pedido!");
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
            Console.WriteLine("\n================ CARRINHO DE COMPRAS ================");

            if (!string.IsNullOrEmpty(NomeCliente))
            {
                Console.WriteLine($"CLIENTE: {NomeCliente}");
                Console.WriteLine("--------------------------------------------------");
            }

            if (Itens.Count == 0)
            {
                Console.WriteLine("O seu carrinho está vazio no momento.");
            }
            else
            {
                foreach (var item in Itens)
                {
                    Console.WriteLine($"{item.Descricao} | Valor: R$ {item.CalcularPrecoFinal():F2}");
                }
                Console.WriteLine($"\nSUBTOTAL ATUAL: R$ {CalcularTotalPedido():F2}");
            }
            Console.WriteLine("====================================================");
        }

        public bool FinalizarPedido()
        {
            Console.WriteLine("\n================ FINALIZAÇÃO DA COMPRA ================");

            if (Itens.Count == 0) //finalizar sem comprar nada
            {
                Console.WriteLine("Seu carrinho está vazio! Adicione algum item antes de finalizar a compra.");
                Console.WriteLine("=======================================================");
                return false;
            }

            if (!string.IsNullOrEmpty(NomeCliente))
            {
                Console.WriteLine($"CLIENTE: {NomeCliente}");
                Console.WriteLine("-------------------------------------------------------");
            }

            Console.WriteLine("ITENS COMPRADOS:");
            foreach (var item in Itens)
            {
                Console.WriteLine($"{item.Descricao} | R$ {item.CalcularPrecoFinal():F2}");
            }

            double total = CalcularTotalPedido();
            Console.WriteLine($"\nTOTAL A PAGAR: R$ {total:F2}");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"'PAGAMENTO REALIZADO COM SUCESSO! VOLTE SEMPRE AO SIRI CASCUDO, {NomeCliente}!'");
            Console.WriteLine("=======================================================");

            return true; //acabou compra
        }
    }
}
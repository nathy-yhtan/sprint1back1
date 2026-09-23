using System.Collections.Generic;

namespace sprint1back
{
    public class Lanche : ItemCardapio
    {
        public List<string> IngredientesExtras { get; set; } = new List<string>();

        public Lanche(int codigo, string descricao, double precoBase) //construtor herdando de ItemCardapio
            : base(codigo, descricao, precoBase)
        {
        }

        public override double CalcularPrecoFinal()
        {
            double total = PrecoBase;
            total += IngredientesExtras.Count * 2.00; //cada ingrediente extra é mais 2 reais
            return total;
        }
    }
}
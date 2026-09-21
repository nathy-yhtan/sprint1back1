using System.Collections.Generic; // OBRIGATÓRIO para usar List<string>

namespace sprint1back
{
    public class Lanche : ItemCardapio
    {
        // 1. Declarar E inicializar a lista com '= new List<string>();'
        public List<string> IngredientesExtras { get; set; } = new List<string>();

        // 2. Construtor herdando de ItemCardapio
        public Lanche(int codigo, string descricao, double precoBase)
            : base(codigo, descricao, precoBase)
        {
        }

        // 3. Método de cálculo somando R$ 2,00 por cada extra adicionado
        public override double CalcularPrecoFinal()
        {
            double total = PrecoBase;
            total += IngredientesExtras.Count * 2.00;
            return total;
        }
    }
}

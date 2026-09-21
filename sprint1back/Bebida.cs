namespace sprint1back
{
    public class Bebida : ItemCardapio
    {
        public string Tamanho { get; set; }

        public Bebida(int codigo, string descricao, double precoBase, string tamanho)
            : base(codigo, descricao, precoBase)
        {
            Tamanho = tamanho;
        }

        public override double CalcularPrecoFinal()
        {
            if (Tamanho == "500ml") return PrecoBase + 2.00;
            if (Tamanho == "1L") return PrecoBase + 4.00;
            return PrecoBase; // Valor padrão para 300ml
        }
    }
}

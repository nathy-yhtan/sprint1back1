namespace sprint1back
{
    public abstract class ItemCardapio
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double PrecoBase { get; set; }

        public ItemCardapio(int codigo, string descricao, double precoBase)
        {
            Codigo = codigo;
            Descricao = descricao;
            PrecoBase = precoBase;
        }

        // Método que Lanche e Bebida vão personalizar (Polimorfismo)
        public abstract double CalcularPrecoFinal();
    }
}

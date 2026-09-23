using sprint1back.Interfaces;

namespace sprint1back
{
    public abstract class ItemCardapio : ICalcularPrecoFinal //assina a interface
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

        public abstract double CalcularPrecoFinal(); //metodo: que Lanche e Bebida vão personalizar (polimorfismo); e que: é exigido pela interface
    }
}

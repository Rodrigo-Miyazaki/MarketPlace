namespace MarketPlace.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Marca { get; set; }
        public Categoria Categorias { get; set; }

        public void Adiciona()
        {
            this.Quantidade++;
        }

        public void Remove()
        {
            this.Quantidade--;
        }
    }
}

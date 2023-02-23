namespace EcommerceMvc.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Descricao { get; set;}
        public double Peso { get; set;}
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Valor { get; set;}
        public int QuantidadeEmEstoque { get; set; }

        //Implementando a associação da produto com a subcategoria (muitos para 1)
        public Subcategoria Subcategoria { get; set; }



    }
}

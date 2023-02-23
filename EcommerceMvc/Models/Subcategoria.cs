using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;

namespace EcommerceMvc.Models
{
    public class Subcategoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime HoraCadastroSub { get; set; }

        //Implementando a associação da subcategoria com a categoria (muitos para 1)
        public Categoria Categoria { get; set; }

        //Implementando a associação da subcategoria com a produto (1 para muitos)
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}

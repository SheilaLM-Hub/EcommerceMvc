using EcommerceMvc.Models.Enums;
using System;
using System.Collections.Generic;

namespace EcommerceMvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime HoraCadastroCat { get; set; }

        public CategoriaStatus Status { get; set; }

        //Implementando a associação da categoria com a subcategoria (1 para muitos)
        public ICollection<Subcategoria>Subcategorias { get; set; } = new List<Subcategoria>();

    }
}

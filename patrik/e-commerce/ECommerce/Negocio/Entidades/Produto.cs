using System;

namespace Negocio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
    }
}
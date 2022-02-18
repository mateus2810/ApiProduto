using System;

namespace Domain
{
    public class ProdutoDto
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocao { get; set; }
        public int Quantidade { get; set; }
    }
}

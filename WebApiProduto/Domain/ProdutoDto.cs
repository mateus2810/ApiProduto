using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{

    [Table("dbo.produto ")]
    public class ProdutoDto
    {
        public string IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
        public int Quantidade { get; set; }
    }
}

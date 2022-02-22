using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    //[Table("[dbo].[OFICINA]")]
    [Table("dbo.Madeira ")]
    public class ProdutoDto
    {
        //alterar nomes propriedades
        public string IdMadeira { get; set; }
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public decimal Comprimento { get; set; }
        public int Espessura { get; set; }
    }
}

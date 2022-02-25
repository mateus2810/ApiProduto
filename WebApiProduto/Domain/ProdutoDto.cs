using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using TableAttribute = System.ComponentModel.DataAnnotations.Schema.TableAttribute;//conferir

namespace Domain
{

    [Table("dbo.produto ")]
    public class ProdutoDto
    {

        //public int IdProduto { get; set; }
        [ExplicitKey]
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPromocional { get; set; }
        public int Quantidade { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dto
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

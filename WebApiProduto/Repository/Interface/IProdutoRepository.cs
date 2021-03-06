using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface  IProdutoRepository
    {
        IEnumerable<ProdutoDto> ListarProdutoRepository();
        bool CriarProdutoRepository(ProdutoDto produto);
        bool EditarProdutoRepository(ProdutoDto produto);
        bool ExcluirProdutoRepository(ProdutoDto produto);
    }
}

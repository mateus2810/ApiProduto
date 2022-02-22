using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoDto> ListarProdutoService();
        ProdutoDto CriarProdutoService();
        ProdutoDto EditarProdutoService();
        ProdutoDto ExcluirProdutoService();
    }
}

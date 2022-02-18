using Dapper;
using Repository.Interface;
using Repository.Repository.Base;
using Services.Dto;
using System;
using System.Collections.Generic;

namespace Repository.Repository
{
    public class ProdutoRepository : RepositoryBase<ProdutoDto>, IProdutoRepository
    {

        private readonly IProdutoRepository _produtoRepository;

        public IEnumerable<ProdutoDto> ListarProdutoRepository()
        {
            try
            {
                const string sql = "SELECT * FROM dbo.Madeira ";

                ValidaConexao();

                var resultado = _conexao.Query<ProdutoDto>(sql);


                return _produtoRepository.ListarProdutoRepository(sql);
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }
    }
}

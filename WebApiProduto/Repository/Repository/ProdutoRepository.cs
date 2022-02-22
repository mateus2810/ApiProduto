using Dapper;
using Dapper.Contrib.Extensions;
using Domain;
using Repository.Interface;
using Repository.Repository.Base;
using System;
using System.Collections.Generic;

namespace Repository.Repository
{
    public class ProdutoRepository : RepositoryBase<ProdutoDto>, IProdutoRepository
    {


        public IEnumerable<ProdutoDto> ListarProdutoRepository()
        {
            try
            {
                const string sql = "SELECT * FROM dbo.produto ";

                ValidaConexao();

                var resultado = _conexao.Query<ProdutoDto>(sql);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public bool CriarProdutoRepository(ProdutoDto produto)
        {
            try
            {
                ValidaConexao();

                var resultado = _conexao.Insert(produto);
                
                Dispose();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public ProdutoDto EditarProdutoRepository()
        {
            return new ProdutoDto();
            
            //const string sql = "SELECT * FROM dbo.Madeira ";


            //var atualizar = _conexao.Execute(sql);
            //try
            //{
            //    const string sql = "SELECT * FROM dbo.Madeira ";//colocar insert

            //    ValidaConexao();

            //    var resultado = _conexao.Query<ProdutoDto>(sql);
            //    Dispose();


            //    return resultado;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception($"ERRO: {ex.Message}");
            //}
        }

        public ProdutoDto ExcluirProdutoRepository()
        {
            return new ProdutoDto();
            //try
            //{
            //    const string sql = "SELECT * FROM dbo.Madeira ";//colocar insert

            //    ValidaConexao();

            //    var resultado = _conexao.Query<ProdutoDto>(sql);
            //    Dispose();


            //    return resultado;
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception($"ERRO: {ex.Message}");
            //}
        }



    }
}

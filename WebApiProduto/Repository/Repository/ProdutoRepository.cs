﻿using Dapper;
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
                const string sql = "SELECT * FROM dbo.Madeira ";

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
    }
}

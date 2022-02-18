using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Repository.Repository.Base
{
    public class RepositoryBase<T> : IDisposable
    {
        protected readonly SqlConnection _conexao;
        public RepositoryBase()//configuração do meu banco de dados local
        {
            try
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                _conexao = new SqlConnection(config.GetConnectionString("ConexaoBancoDeDados"));
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public void ValidaConexao()
        {

            if (_conexao.State != ConnectionState.Open)
                _conexao.Open();
        }

        public void Dispose()
        {
            try
            {
                if (_conexao.State != ConnectionState.Open)
                    return;

                _conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");
            }
        }
    }
}

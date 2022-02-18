using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _app_token = config.GetSection("AppToken").Value;
                _access_token = config.GetSection("AccessToken").Value;
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

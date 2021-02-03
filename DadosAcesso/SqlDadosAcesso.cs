using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosAcesso
{
    public class SqlDadosAcesso : ISqlDadosAcesso
    {
        private readonly IConfiguration _config;
        public string NomeStringConexao { get; set; } = "Default";
        public SqlDadosAcesso(IConfiguration config)
        {
            _config = config;
        }
        public async Task<List<T>> CarregarDados<T, U>(string sql, U parametros)
        {
            string stringConexao = _config.GetConnectionString(NomeStringConexao);

            using (IDbConnection conexao = new SqlConnection(stringConexao))
            {
                var dados = await conexao.QueryAsync<T>(sql, parametros);

                return dados.ToList();
            }
        }

        public async Task SalvarDados<T>(string sql, T parametros)
        {
            string stringConexao = _config.GetConnectionString(NomeStringConexao);

            using (IDbConnection conexao = new SqlConnection(stringConexao))
            {
                await conexao.ExecuteAsync(sql, parametros);
            }
        }
    }
}

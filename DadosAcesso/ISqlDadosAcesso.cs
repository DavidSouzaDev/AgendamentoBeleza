using System.Collections.Generic;
using System.Threading.Tasks;

namespace DadosAcesso
{
    public interface ISqlDadosAcesso
    {
        string NomeStringConexao { get; set; }

        Task<List<T>> CarregarDados<T, U>(string sql, U parametros);
        Task SalvarDados<T>(string sql, T parametros);
    }
}
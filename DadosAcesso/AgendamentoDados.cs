using DadosAcesso.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DadosAcesso
{
    public class AgendamentoDados : IAgendamentoDados
    {
        private readonly ISqlDadosAcesso _db;
        public AgendamentoDados(ISqlDadosAcesso db)
        {
            _db = db;
        }

        public Task<List<AgendamentoModels>> GetAgendamentos()
        {
            string sql = "select * from dbo.TabelaAgendamento";

            return _db.CarregarDados<AgendamentoModels, dynamic>(sql, new { });
        }
        public Task InserirAgendamento(AgendamentoModels agendamento)
        {
            string sql = @"insert into dbo.TabelaAgendamento (HoraInicioAgendamento, HoraFimAgendamento, DiaHoraAgendamento)
                            values (@HoraInicioAgendamento, @HoraFimAgendamento, @DiaHoraAgendamento);";

            return _db.SalvarDados(sql, agendamento);
        }
    }
}

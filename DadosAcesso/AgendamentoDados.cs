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
            string sql = "SELECT * FROM TabelaAgendamento TA " +
                            "JOIN TabelaTipoServico TS ON(TA.IdTipoServico = TS.IdTipoServico)" +
                            "JOIN TabelaCliente TC ON(TC.IdCliente = TA.IdCliente)" +
                            "JOIN TabelaEmpresa TE ON(TE.IdEmpresa = TA.IdEmpresa)" +
                            "JOIN TabelaGerente TG ON(TG.IdGerente = TA.IdGerente);";
             
            return _db.CarregarDados<AgendamentoModels, dynamic>(sql, new { });
        }

        public Task<List<ClienteModels>> GetClientes()
        {
            string sql = "SELECT * FROM TabelaCliente;";

            return _db.CarregarDados<ClienteModels, dynamic>(sql, new { });
        }

        public Task<List<TipoServicoModels>> GetTipoServico()
        {
            string sql = "SELECT * FROM TabelaTipoServico;";

            return _db.CarregarDados<TipoServicoModels, dynamic>(sql, new { });
        }
        

        public Task InserirAgendamento(InsereAgendamentoModels agendamento)
        {                     
            var HoraInicioAgendamento = agendamento.HoraInicioAgendamento;
            var HoraFimAgendamento = agendamento.HoraFimAgendamento;
            var DiaHoraAgendamento = agendamento.DiaHoraAgendamento;
            var IdTipoServico = 1;//agendamento.IdTipoServico;
            var IdCliente = 1;//agendamento.IdCliente;
            var IdEmpresa = 1;//agendamento.IdEmpresa;
            var IdGerente = 1;//agendamento.IdGerente;

            string sql = @"INSERT INTO dbo.TabelaAgendamento (HoraInicioAgendamento, HoraFimAgendamento, DiaHoraAgendamento, 
                            IdTipoServico, IdCliente, IdEmpresa, IdGerente)
                            VALUES (" + HoraInicioAgendamento + "," + HoraFimAgendamento + "," + DiaHoraAgendamento + ","
                            + IdTipoServico + "," + IdCliente + "," + IdEmpresa + "," + IdGerente + ");";

            return _db.SalvarDados(sql, agendamento);
        }       
    }
}

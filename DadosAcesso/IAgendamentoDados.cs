using DadosAcesso.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DadosAcesso
{
    public interface IAgendamentoDados
    {
        Task<List<AgendamentoModels>> GetAgendamentos();
        Task InserirAgendamento(AgendamentoModels agendamento);
    }
}
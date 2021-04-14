using System;
using System.Collections.Generic;
using System.Text;

namespace DadosAcesso.Models
{
    public class InsereAgendamentoModels
    {
        public int IdAgendamento { get; set; }
        public DateTime HoraInicioAgendamento { get; set; }
        public DateTime HoraFimAgendamento { get; set; }
        public DateTime DiaHoraAgendamento { get; set; }
        public int IdTipoServico { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public int IdGerente { get; set; }
    }
}

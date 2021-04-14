using System;
using System.Collections.Generic;
using System.Text;

namespace DadosAcesso.Models
{
    public class AgendamentoModels
    {
        public int IdAgendamento { get; set; }
        public DateTime HoraInicioAgendamento { get; set; }
        public DateTime HoraFimAgendamento { get; set; }
        public DateTime DiaHoraAgendamento { get; set; }
        public int IdTipoServico { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpresa { get; set; }
        public int IdGerente { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string CpfCliente { get; set; }
        public string RgCliente { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string EnderecoEmpresa { get; set; }
        public string EmailGerente { get; set; }
        public string SenhaGerente { get; set; }
        public string DescricaoTipoServico { get; set; }
    }
}

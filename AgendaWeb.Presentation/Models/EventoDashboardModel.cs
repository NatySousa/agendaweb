using AgendaWeb.Infra.Data.DTOs;
using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Presentation.Models
{
    // Classe de modelo de dados para a página de dashboard de eventos
    public class EventoDashboardModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string DataMin { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string DataMax { get; set; }

        public List<ConsultaPrioridadeDTO>? ConsultaPrioridade { get; set; }

        public List<ConsultaAtivoInativoDTO>? ConsultaAtivoInativo { get; set; }

    }
}

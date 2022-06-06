using AgendaWeb.Infra.Data.DTOs;
using AgendaWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    // Interface para operações de repositório de Evento
    public interface IEventoRepository : IBaseRepository<Evento>
    {
        // Consulta de eventos por periodo de datas e usuário
        List<Evento> GetAll(DateTime dataMin, DateTime dataMax,Guid idUsuario, int ativo);

        // Consulta de eventos agrupado por prioridade,filtrando por periodo de datas e usuário
       
        List<ConsultaPrioridadeDTO> GroupByPrioridade(DateTime dataMin, DateTime dataMax, Guid idUsuario);

        // Consulta de eventos agrupado por ativo/inativo,filtrando por periodo de datas e usuário
       
        List<ConsultaAtivoInativoDTO> GroupByAtivo(DateTime dataMin, DateTime dataMax, Guid idUsuario);

    }
}

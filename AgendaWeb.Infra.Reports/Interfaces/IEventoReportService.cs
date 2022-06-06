using AgendaWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Reports.Interfaces
{
    //Interface para definição dos métodos utilizados p/geração dos relatórios de dados de evento
    public interface IEventoReportService
    {
        //Método abstrato para implementação de relatórios
        byte[] GerarRelatorio(
            Usuario usuario, //Dados do usuário logado que gerou o relatório
            List<Evento> eventos, //Lista de eventos que será exibida no relatório
            DateTime dataMin, //Data de início do filtro de pesquisa
            DateTime dataMax); //Data de fim do filtro de pesquisa
    }

}


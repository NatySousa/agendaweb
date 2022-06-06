using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.DTOs
{
    // DTO para captura dos dados da consulta de evento agrupado por ativo ou inativo

    public class ConsultaAtivoInativoDTO
    {
        public string Ativo { get; set; }
        public int Quantidade { get; set; }

    }
}

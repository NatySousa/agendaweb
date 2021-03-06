using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Entities
{
    public class Usuario
    {

        // Propriedades

        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataInclusao { get; set; }
        public int PrimeiroAcesso { get; set; }

       

      //Associações

        public List<Evento> Eventos { get; set; }


    }
}

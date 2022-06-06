using AgendaWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    //interface p/operações de repositório de usuário
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {

        Usuario Get(string email);
        Usuario Get(string email, string senha);

    }
}

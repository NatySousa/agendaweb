using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Repositories;

namespace AgendaWeb.Presentation
{
    //classe para configuração de injeção de dependencia do projeto
    public class DependencyInjection
    {
        public static void Register(WebApplicationBuilder builder)
        {
            //capturar a connectionstring mapeada no arquivo appsetings.json
            var connectionString = builder.Configuration.GetConnectionString("AgendaWeb");

            //configurando a injeção de dependencia para o repositório
            builder.Services.AddTransient<IUsuarioRepository>
                (map => new UsuarioRepository(connectionString));

            builder.Services.AddTransient<IEventoRepository>
                (map => new EventoRepository(connectionString));


        }
    }
}

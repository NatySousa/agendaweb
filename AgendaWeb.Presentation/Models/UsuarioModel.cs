namespace AgendaWeb.Presentation.Models
{
    // Classe de modelo de dados para as informações do usuário
    // autenticado que são gravadas em sessão("memória temporária", armazenando antes de salvar no BD)

    public class UsuarioModel
    {
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataInclusao { get; set; }
        public int PrimeiroAcesso { get; set; }
        public string DataHoraAcesso { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace AgendaWeb.Presentation.Models.Validations
{
    //Classe de validação para campos de senha
    public class PasswordValidation : ValidationAttribute
    {
       // Método para implementar a regra de validação
       
       //name="value"->Representa o valor do campo que será validado = retornar True/False dependendo do resultado da validação
        public override bool IsValid(object? value)
        {
            //verificar se o valor recebido não é vazio
            if (value != null)
            {
                //converter o valor para string
                var senha = value.ToString();

                //verificar o conteudo da senha
                return senha.Any(s => char.IsLower(s))//pelo menos 1 letra minúscula

                    && senha.Any(s => char.IsUpper(s))//pelo menos 1 letra maiúscula

                    && senha.Any(s => char.IsDigit(s))//pelo menos 1 número

                    && (
                        senha.Contains("@") || //pelo menos um desses caracteres especiais
                        senha.Contains("$") ||
                        senha.Contains("#") ||
                        senha.Contains("%")
                    );
            }
            return false;
        }
    }
}

   
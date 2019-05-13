namespace FinancaDeMesa.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;   
        }

        public static bool ConfirmacaoSenha (string senha, string confirmaSenha)
        {
            if (senha.Length >= 6 && confirmaSenha.Equals(senha))
            {
                return true;
            }
            return false;
        }
    }
}
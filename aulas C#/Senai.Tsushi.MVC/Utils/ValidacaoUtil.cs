namespace Senai.Tsushi.MVC.Utils
{
    public static class ValidacaoUtil
    {
        /// <summary>Retorna true caso o email possua @ e . e false se não possuir</summary>
        public static bool ValidarEmail (string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            return false;
        }
        /// <summary>Retorna true caso as senhas sejam iguais ou false</summary>
        public static bool ConfirmacaoSenha(string senha, string confirmaSenha)
        {
            if (senha.Equals(confirmaSenha) && senha.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
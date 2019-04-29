namespace senai_sushi.MVC.Utils {
    public class ValidacaoUtil {

        /// <summary>Retorna true caso o email possua @ e . e false se não possuir </summary>

        public static bool ValidarEmail (string email) {

            if (email.Contains ("@") && email.Contains (".")) {

                return true;
            }

            return false;
        }

        /// <summary>Retorna true caso as senhas sejam iguais e contenha mais de 6 caracteres ou false caso contrario</summary>
        public static bool ConfirmacaoSenha (string senha, string confirmaSenha) {
            if (senha.Equals (confirmaSenha) && senha.Length > 6) {
                return true;
            }
            return false;
        }

        public static bool ValidarCategoria(string categoria){
            if (categoria.Equals("Bebida") || categoria.Equals("Pizza"))
            {
                return true;
            }
            
            return false;
        }
    }
}
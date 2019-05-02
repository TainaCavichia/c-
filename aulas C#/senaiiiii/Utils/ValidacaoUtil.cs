namespace senaiiiii.Utils {
    public class ValidacaoUtil {
        public static bool ValidacaoEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }
        public static bool ValidacaoTipo(string tipo){
            if (tipo.Contains("administrador") || tipo.Contains("usuário"))
            {
                return true;
            }
            return false;
        }
        public static bool VaidacaoSenha(string senha){
            if (senha.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
}
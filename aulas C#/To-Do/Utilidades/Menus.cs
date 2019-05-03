namespace To_Do.Utilidades
{
    public class Menus
    {
        public static void Menu_Deslogado(){
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("|-------- Bem-vindo ao TO-DO --------|");
            System.Console.WriteLine("|- 1- Cadastrar usuário -------------|");
            System.Console.WriteLine("|- 2- Fazer Login -------------------|");
            System.Console.WriteLine("|- 0- Sair --------------------------|");
            System.Console.WriteLine("|- Digite um dos códigos acima: -----|");
            System.Console.WriteLine("--------------------------------------");
        }
        public static void Menu_Logado_ADM(){
            System.Console.WriteLine("|- Digite um dos códigos abaixo: ----|");
            System.Console.WriteLine("|- 1- Registrar tarefa --------------|");
            System.Console.WriteLine("|- 2- Listar tarefas ----------------|");
            System.Console.WriteLine("|- 0- Deslogar ----------------------|");
            System.Console.WriteLine("|------------------------------------|");
        }
        public static void Menu_Logado_USUARIO(){
            System.Console.WriteLine("|- Digite um dos códigos abaixo: ----|");
            System.Console.WriteLine("|- 1- Listar tarefaS ----------------|");
            System.Console.WriteLine("|- 0- Deslogar ----------------------|");
            System.Console.WriteLine("|------------------------------------|");
        }
    }
}
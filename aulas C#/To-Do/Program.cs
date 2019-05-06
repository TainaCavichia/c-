using System;
using To_Do.Controle;
using To_Do.Modelos;
using To_Do.Utilidades;

namespace To_Do {
    class Program {
        static void Main (string[] args) {
            int codigo;
            string teste;
            bool sair = false;

            do {
                int i = 0;
                Menus.Menu_Deslogado ();
                do {
                    if (i > 0) {
                        System.Console.WriteLine ("Comando inválido");
                        System.Console.WriteLine ("Digite novamente:");
                    }
                    teste = Console.ReadLine ();
                    i++;
                } while (!int.TryParse (teste, out codigo) || codigo != 0 & codigo != 1 & codigo != 2);

                switch (codigo) {
                    case 1:
                        ControleUsuario.CadastrarUsuario ();
                        break;

                    case 2:
                    bool sairr = false;
                        ModeloUsuario usuarioRecuperado = ControleUsuario.EfetuarLogin ();
                        System.Console.WriteLine ("|------------------------------------|");
                        System.Console.WriteLine ($"|     Bem-vindo ao TO-DO {usuarioRecuperado.Nome}       |");
                    do{
                        if (usuarioRecuperado.Tipo.Equals ("ADM")) {
                            Menus.Menu_Logado_ADM ();
                            do {
                                i = 0;
                                if (i > 0) {
                                    System.Console.WriteLine ("Comando inválido");
                                    System.Console.WriteLine ("Digite novamente:");
                                }
                                teste = Console.ReadLine ();
                                i++;
                            } while (!int.TryParse (teste, out codigo) || codigo != 0 & codigo != 1 & codigo != 2 & codigo != 3);
                            switch (codigo) {
                                case 1:
                                    ControleTarefa.RegistrarTarefa (usuarioRecuperado.Id);
                                    break;

                                case 2:
                                    ControleTarefa.ListarTarefas (usuarioRecuperado);
                                    break;

                                case 3:
                                    ControleTarefa.AlterarTipo ();
                                    break;

                                case 0:
                                    sair = true;
                                    break;
                            }
                        } else if(usuarioRecuperado.Tipo.Equals("USUARIO")){

                            Menus.Menu_Logado_USUARIO ();

                            do {
                                i = 0;
                                if (i > 0) {
                                    System.Console.WriteLine ("Comando inválido");
                                    System.Console.WriteLine ("Digite novamente:");
                                }
                                teste = Console.ReadLine ();
                                i++;
                            } while (!int.TryParse (teste, out codigo) || codigo != 0 & codigo != 1 & codigo != 2);

                            switch (codigo) {
                                case 1:
                                    ControleTarefa.ListarTarefas (usuarioRecuperado);
                                    break;

                                case 2:
                                    ControleTarefa.AlterarTipo();
                                    break;

                                case 0:
                                    sairr = true;
                                    break;
                            }
                        }
                    } while (!sairr);
                        break;

                    case 0:
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}
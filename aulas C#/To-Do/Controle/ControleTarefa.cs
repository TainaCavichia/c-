using System;
using System.Collections.Generic;
using To_Do.Enums;
using To_Do.Modelos;
using To_Do.Repositorio;

namespace To_Do.Controle {
    public class ControleTarefa {
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio ();
        public static int RegistrarTarefa (int idusuario) {
            string descricao, nome;

            System.Console.WriteLine ("Digite seu nome:");
            nome = Console.ReadLine ();
            System.Console.WriteLine ("Digite sua descrição:");
            descricao = Console.ReadLine ();

            ModeloTarefas modelotarefa = new ModeloTarefas ();
            modelotarefa.Nome = nome;
            modelotarefa.Descricao = descricao;
            modelotarefa.IdUsuário = idusuario;

            tarefaRepositorio.Inserir (modelotarefa);

            System.Console.WriteLine ("\nCadastro realizado com sucesso");

            return idusuario;
        }
        public static void ListarTarefas () {
            List<ModeloTarefas> listaDeTarefas = tarefaRepositorio.Listar ();
            foreach (var item in listaDeTarefas) {
                System.Console.WriteLine ($"--------------------------------------------\nNome: {item.Nome}\nDescrição: {item.Descricao}\nId do Usuário: {item.IdUsuário}\nData: {item.DataCriacao}\nSituação: {item.Tipo}\n--------------------------------------------");
            }
            MostrarMensagem ("Clique ENTER para continuar", TipoMensagemEnum.DESTAQUE);
            Console.ReadLine ();
        }
        public static void AlterarTipo () {
            int id;
            string situacao;

                System.Console.WriteLine ("Digite seu email:");
                id = int.Parse (Console.ReadLine ());
            do {
                System.Console.WriteLine ("Digite a situação: (A FAZER, FAZENDO, FEITO)");
                situacao = Console.ReadLine ().ToUpper ();
            } while (situacao != "A FAZER" || situacao !="FAZENDO" || situacao !="FEITO");

            ModeloTarefas tarefaRecuperada = tarefaRepositorio.BuscarTarefa (id, situacao);

            if (tarefaRecuperada != null) {
            } else {
                MostrarMensagem ("Id inválido", TipoMensagemEnum.ALERTA);
            }
        }
        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {
            switch (tipoMensagem) {
                case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;

            }
        }
    }
}
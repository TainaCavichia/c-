using System;
using System.Collections.Generic;
using System.IO;
using To_Do.Modelos;

namespace To_Do.Repositorio {
    public class UsuarioRepositorio {
        List<ModeloUsuario> listaDeUsuarios = new List<ModeloUsuario> ();
        
        public ModeloUsuario Inserir (ModeloUsuario usuario) {
            List<ModeloUsuario> listaDeUsuarios = Listar();
            int contador = 0;

            if (listaDeUsuarios != null)
            {
                contador = listaDeUsuarios.Count;
            }
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter ("usuarios.csv", true);
            sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao};{usuario.Tipo}");
            sw.Close();
            return usuario;
        }
         public List<ModeloUsuario> Listar () {
            List<ModeloUsuario> listaDeUsuarios = new List<ModeloUsuario> ();
            ModeloUsuario usuarioViewModel;
            if (!File.Exists ("usuarios.csv")) {
                return null;
            }
            string[] usuarios = File.ReadAllLines ("usuarios.csv");

            foreach (var item in usuarios) {
                if (!String.IsNullOrEmpty(item)) {
                    string[] dadosDeCadaUsuario = item.Split (";");
                    usuarioViewModel = new ModeloUsuario ();
                    usuarioViewModel.Id = int.Parse (dadosDeCadaUsuario[0]);
                    usuarioViewModel.Nome = dadosDeCadaUsuario[1];
                    usuarioViewModel.Email = dadosDeCadaUsuario[2];
                    usuarioViewModel.Senha = dadosDeCadaUsuario[3];
                    usuarioViewModel.DataCriacao = DateTime.Parse (dadosDeCadaUsuario[4]);
                    usuarioViewModel.Tipo = dadosDeCadaUsuario[5];
                    listaDeUsuarios.Add (usuarioViewModel);
                }
            }
                    return listaDeUsuarios;
        }
        public ModeloUsuario BuscarUsuario (string email, string senha) {
            List<ModeloUsuario> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios) {
                if (item.Email.Equals (email) && item.Senha.Equals (senha)) {
                    return item;
                }
            }
            return null;
        }
    }
}
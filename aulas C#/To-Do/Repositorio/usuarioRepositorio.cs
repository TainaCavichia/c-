using System;
using System.Collections.Generic;
using To_Do.Modelos;

namespace To_Do.Repositorio {
    public class UsuarioRepositorio {
        List<ModeloUsuario> listaDeUsuarios = new List<ModeloUsuario> ();
        
        public ModeloUsuario Inserir (ModeloUsuario usuario) {
            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add (usuario);
            return usuario;
        }
        public ModeloUsuario BuscarUsuario (string email, string senha) {
            foreach (var item in listaDeUsuarios) {
                if (item.Email.Equals (email) && item.Senha.Equals (senha)) {
                    return item;
                }
            }
            return null;
        }
    }
}
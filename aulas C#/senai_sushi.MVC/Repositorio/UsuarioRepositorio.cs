using System;
using System.Collections.Generic;
using senai_sushi.MVC.ViewModel;

namespace senai_sushi.MVC.Repositorio {
    public class UsuarioRepositorio {
        List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();

        /// <summary>Metodo responsavel por armazenar um usuario</summary>   

        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {

            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;
            // insere o objeto usuario dentro da lista

            listaDeUsuarios.Add (usuario);
            return usuario;
        }

        /// <summary>Retorna lista de usuarios</summary>

        public List<UsuarioViewModel> Listar () {
            return listaDeUsuarios;
        } // fim listar

        /// <summary>Verifica se o usuario é valido</summary>
        /// <param name="email">Email do Usuario</param>
        /// <param name="senha">Senha do Usuario</param>
        /// <returns>Retorna o usuario caso ele seja encontrado null ou não exista</returns>

        public UsuarioViewModel BuscarUsuario (string email, string senha) {
            foreach (var item in listaDeUsuarios) {
                if (item.Email.Equals (email) && item.Senha.Equals (senha)) {
                    return item;
                }
            } //fim foreach
            return null;
        }
    }
}
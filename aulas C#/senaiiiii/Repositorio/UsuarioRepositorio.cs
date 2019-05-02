using System;
using System.Collections.Generic;

namespace senaiiiii.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> (); 
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {

            usuario.Id = listaDeUsuarios.Count + 1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add (usuario);
            return usuario;
        }

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
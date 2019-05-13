using System;
using System.Collections.Generic;
using System.IO;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewModel;

namespace FinancaDeMesa.Repositorios
{
    public class UsuarioRepositorio
    {
        public  UsuarioViewModel Inserir(UsuarioViewModel usuario)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            StreamWriter streamwriter = new StreamWriter(DatabaseUtils.usuarios, true);
            streamwriter.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDenascimento:dd/MM/yyyy};{usuario.Saldo}");
            streamwriter.Close();
            return usuario;
        }

        public static List<UsuarioViewModel> Listar()
        {
            var listaDeUsuarios = new List<UsuarioViewModel>();
            UsuarioViewModel usuario;
            if (!File.Exists(DatabaseUtils.usuarios))
            {
                return null;
            }

            string[] usuarios = File.ReadAllLines(DatabaseUtils.usuarios);

            foreach (var item in usuarios)
            {
                if (item != null)
                {
                    usuario = new UsuarioViewModel();
                    string[] dados = item.Split(";");
                    usuario.Nome = dados[0];
                    usuario.Email = dados[1];
                    usuario.Senha = dados[2];
                    usuario.DataDenascimento = DateTime.Parse(dados[3]);
                    usuario.Saldo = double.Parse(dados[4]);
                    listaDeUsuarios.Add (usuario);
                }
            }
            return listaDeUsuarios;

        }
    
        public UsuarioViewModel ProcurarUsuario(string email, string senha)
        {
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            foreach (var usuario in listaDeUsuarios)
            {
                if (usuario.Email.Equals(email) && usuario.Senha.Equals(senha))
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
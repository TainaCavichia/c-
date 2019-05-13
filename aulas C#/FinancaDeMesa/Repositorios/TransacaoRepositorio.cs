using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using FinancaDeMesa.Utils;
using FinancaDeMesa.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace FinancaDeMesa.Repositorios
{
    public class TransacaoRepositorio
    {
        public TransacaoViewModel InserirTransacao(TransacaoViewModel transacao)
        {
            List<TransacaoViewModel> listaDeTransacoes = ListarTransacoes();

            StreamWriter sw = new StreamWriter(DatabaseUtils.transacoes, true);
            sw.WriteLine($"{transacao.Tipo};{transacao.Descricao};{transacao.DataTransacao:dd/MM/yyyy};{transacao.Valor};{transacao.Nome}");
            sw.Close();
            return transacao;
        }

        public List<TransacaoViewModel> ListarTransacoes()
        {
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel>();
            TransacaoViewModel transacao;

            if (!File.Exists(DatabaseUtils.transacoes))
            {
                return null;
            }

            string[] transacoes = File.ReadAllLines(DatabaseUtils.transacoes);
            foreach (var item in transacoes)
            {
                if (item != null)
                {
                    string[] dadosCadaTransacao = item.Split(";");
                    transacao = new TransacaoViewModel();
                    transacao.Tipo = dadosCadaTransacao[0];
                    transacao.Descricao = dadosCadaTransacao[1];
                    transacao.DataTransacao = DateTime.Parse(dadosCadaTransacao[2]);
                    transacao.Valor = double.Parse(dadosCadaTransacao[3]);
                    transacao.Nome = dadosCadaTransacao[4];
                    listaDeTransacoes.Add(transacao);

                }
            }
                    return listaDeTransacoes;
        }// ListarTransacoes()

        public void MudarSaldo(UsuarioViewModel usuario, TransacaoViewModel transacao)
        {

            string[] linhas = File.ReadAllLines(DatabaseUtils.usuarios);
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");
                
                if (linha[0].Equals(usuario.Nome))
                {
                    double saldoAntigo = double.Parse(linha[4]);
                    // double novoSaldo;

                    if (transacao.Tipo.Equals("DESPESA"))
                    {
                        usuario.Saldo =  saldoAntigo - transacao.Valor;
                    } else if (transacao.Tipo.Equals("RECEITA"))
                    {
                        usuario.Saldo =  saldoAntigo + transacao.Valor;
                    }


                    linhas[i] = $"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDenascimento:dd/MM/yyyy};{usuario.Saldo}";
                    break;
                }
            }
            File.WriteAllLines(DatabaseUtils.usuarios,linhas);
            // StreamWriter sw = new StreamWriter("usuarios.csv",false);
            // sw.WriteLine($"{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataDenascimento:dd/MM/yyyy};{usuario.Saldo}");
            // sw.Close();
        }
    
        public static void ZiparArquivos()
        {

            string startPath = @".\Database";
            string zipPath = $@".\{DateTime.Now:dd-MM-yyyy}_banco_de_dados.zip";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            
        }

        public static void FazerRelatorioUsuarios(List<UsuarioViewModel> listaDeUsuarios)
        {
            Document relatorio = new Document();
            Paragraph p1 = relatorio.AddSection().AddParagraph();

            foreach (var usuario in listaDeUsuarios)
            {
                if (usuario == null)
                {
                    break;
                }

                p1.AppendText($"\nNome: {usuario.Nome}\nEmail:{usuario.Email}\nData de nascimento: {usuario.DataDenascimento:dd/MM/yyyy}\n");
            }
                relatorio.SaveToFile("Relatorio_usuarios.docx",FileFormat.Docx);    


        }

            public static void FazerRelatorioTransacoes(List<TransacaoViewModel> listaDeTransacoes, UsuarioViewModel usuario)
        {
            Document relatorio = new Document();
            Paragraph p1 = relatorio.AddSection().AddParagraph();

            p1.AppendText($"Usuário: {usuario.Nome}\nEmail: {usuario.Email}\nData de nascimento: {usuario.DataDenascimento:dd/MM/yyyy}\n");
            p1.AppendText("\n                                                               LISTA DE TRANSAÇÕES                                                    \n");

            foreach (var item in listaDeTransacoes)
            {
                if (item == null)
                {
                    break;
                }

                p1.AppendText($"\nTipo: {item.Tipo}\nData: {item.DataTransacao:dd/MM/yyyy}\nDescrição: {item.Descricao}\nValor: R${item.Valor}\n");
            }
                relatorio.SaveToFile($"Relatorio_transicoes_{usuario.Nome}.docx",FileFormat.Docx);    
        }
    }
}
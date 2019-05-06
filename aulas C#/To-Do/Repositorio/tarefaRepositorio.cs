using System;
using System.Collections.Generic;
using System.IO;
using To_Do.Modelos;

namespace To_Do.Repositorio {
    public class TarefaRepositorio {
        List<ModeloTarefas> listaDeTarefas = new List<ModeloTarefas> ();
        public ModeloTarefas Inserir (ModeloTarefas tarefa) {
            List<ModeloTarefas> listaDeTarefas = Listar ();
            int contador = 0;
            if (listaDeTarefas != null)
            {
                contador = listaDeTarefas.Count;
            }
            tarefa.Id = contador + 1;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.Tipo = "A FAZER";

            StreamWriter sw = new StreamWriter ("tarefas.csv", true);
            sw.WriteLine ($"{tarefa.Id};{tarefa.IdUsuário};{tarefa.Nome};{tarefa.Descricao};{tarefa.DataCriacao};{tarefa.Tipo}");
            sw.Close();
            return tarefa;
        }
        public List<ModeloTarefas> Listar () {
            return listaDeTarefas;
        }
        public ModeloTarefas BuscarTarefa(int id, string situacao)
        {
            foreach (var item in listaDeTarefas)
            {
                if (item.Id.Equals(id))
                {
                    item.Tipo = situacao;
                    return item;
                }
            }
                return null;
        }
    }
}
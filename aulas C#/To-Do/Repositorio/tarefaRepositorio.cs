using System;
using System.Collections.Generic;
using To_Do.Modelos;

namespace To_Do.Repositorio {
    public class TarefaRepositorio {
        List<ModeloTarefas> listaDeTarefas = new List<ModeloTarefas> ();
        public ModeloTarefas Inserir (ModeloTarefas tarefa) {
            tarefa.Id = listaDeTarefas.Count + 1;
            tarefa.DataCriacao = DateTime.Now;
            tarefa.Tipo = "A FAZER";

            listaDeTarefas.Add (tarefa);
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
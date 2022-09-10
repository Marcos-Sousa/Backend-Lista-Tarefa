using Backend_Lista_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Repositorio
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        public Task<Tarefa> Adicionar(Tarefa tarefa)
        {
            throw new System.NotImplementedException();
        }

        public Task<Tarefa> Atualizar(Tarefa tarefa)
        {
            throw new System.NotImplementedException();
        }

        public Task<Tarefa> BuscarPorId(Guid Id)
        {
            throw new System.NotImplementedException();
        }

        public Task Deletar()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Tarefa>> ITarefaRepositorio.BuscarTodas()
        {
            throw new NotImplementedException();
        }
    }
}

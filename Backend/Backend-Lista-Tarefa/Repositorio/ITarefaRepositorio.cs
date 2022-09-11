using Backend_Lista_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Repositorio
{
    public interface ITarefaRepositorio
    {
        void Adicionar(Tarefa tarefa);
        void Atualizar(Tarefa tarefa);
        void Deletar(Tarefa tarefa);
        Task<IEnumerable<Tarefa>> BuscarTodas();
        Task<Tarefa> BuscarPorId(Guid Id);
    }
}

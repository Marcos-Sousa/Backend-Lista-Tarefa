using Backend_Lista_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Repositorio
{
    public interface ITarefaRepositorio
    {
        Task<Tarefa> Adicionar(Tarefa tarefa);
        Task<Tarefa> Atualizar(Tarefa tarefa);
        Task<IEnumerable<Tarefa>> BuscarTodas();
        Task<Tarefa> BuscarPorId(Guid Id);
        Task Deletar();
    }
}

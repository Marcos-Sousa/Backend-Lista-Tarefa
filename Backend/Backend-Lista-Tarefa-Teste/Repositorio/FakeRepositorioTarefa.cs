using Backend_Lista_Tarefa.Modelos;
using Backend_Lista_Tarefa.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa_Testes
{
    public class FakeRepositorioTarefa : ITarefaRepositorio
    {

        public FakeRepositorioTarefa()
        {

        }
        public void Adicionar(Tarefa tarefa)
        {
            IList<Tarefa> tarefas = new List<Tarefa>();
            tarefas.Add(tarefa);
        }

        public void Atualizar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<Tarefa> BuscarPorId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tarefa>> BuscarTodas()
        {
            List<Tarefa> _listaTarefa;
            _listaTarefa = new List<Tarefa>();
            _listaTarefa.Add(new Tarefa("Tarefa 1", "C#", "Lista 1"));
            _listaTarefa.Add(new Tarefa("Tarefa 2", "C#", "Lista 1"));
            _listaTarefa.Add(new Tarefa("Tarefa 3", "Angular", "Lista 2"));
            _listaTarefa.Add(new Tarefa("Tarefa 4", "Angular", "Lista 2"));
            _listaTarefa.Add(new Tarefa("Tarefa 4", "Angular", "Lista 3"));
            return _listaTarefa;
        }

        public void Deletar(Tarefa tarefa)
        {
            throw new NotImplementedException();
        }
    }
}

using Backend_Lista_Tarefa.Comandos;
using Backend_Lista_Tarefa.Comandos.Saida;
using Backend_Lista_Tarefa.Comandos.Tarefa;
using Backend_Lista_Tarefa.Modelos;
using Backend_Lista_Tarefa.Repositorio;
using Flunt.Notifications;
using System;
using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Manipuladores
{
    public class ComandoManipuladorTarefa : Notifiable, IComandoManipulador<ComandoManipuladorAdicionarTarefa>, IComandoManipulador<ComandoManipuladorAtualizarTarefa>
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public ComandoManipuladorTarefa(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        public async Task<IComandoSaida> manipulador(ComandoManipuladorAdicionarTarefa comando)
        {
            Tarefa tarefa = new Tarefa(comando.Titulo, comando.Conteudo, comando.Lista);

            comando.Validate();
            if (comando.Invalid)
            {
                return new ComandoSaida(false, 400, tarefa);
            }
            try
            {
                _tarefaRepositorio.Adicionar(tarefa);
                return new ComandoSaida(true, 200, tarefa);
            }
            catch (System.Exception)
            {
                return new ComandoSaida(false, 400, tarefa);
            }
        }

        public async Task<IComandoSaida> manipulador(ComandoManipuladorAtualizarTarefa comando)
        {
            Tarefa tarefa = await _tarefaRepositorio.BuscarPorId(comando.Id);
            tarefa.Atualizar(comando.Titulo, comando.Conteudo, comando.Lista);

            comando.Validate();
            if (comando.Invalid)
            {
                return new ComandoSaida(false, 400, tarefa);
            }
            try
            {
                _tarefaRepositorio.Atualizar(tarefa);
                return new ComandoSaida(true, 200, tarefa);
            }
            catch (System.Exception)
            {
                return new ComandoSaida(false, 400, tarefa);
            }
        }

        public async Task<IComandoSaida> Deletar(Guid id)
        {
            Tarefa tarefa = await _tarefaRepositorio.BuscarPorId(id);
            try
            {
                if (tarefa != null)
                {
                    _tarefaRepositorio.Deletar(tarefa);
                    return new ComandoSaida(true, 200, tarefa);
                }
                else
                {
                    return new ComandoSaida(false, 400, tarefa);
                }
            }
            catch (System.Exception)
            {
                return new ComandoSaida(false, 400, tarefa);
            }
        }
    }
}

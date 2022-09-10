using System.Threading.Tasks;

namespace Backend_Lista_Tarefa.Comandos
{
    public interface IComandoManipulador<T> where T : IComandoEntrada
    {
        Task<IComandoSaida> manipulador(T comando);
    }
}

using Backend_Lista_Tarefa.Comandos.Tarefa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Backend_Lista_Tarefa_Testes.Comando
{
    [TestClass]
    public class ComandoManipuladorAdicionarTarefaTeste
    {
        private readonly ComandoManipuladorAdicionarTarefa _comandoManipuladorTarefaValida = new ComandoManipuladorAdicionarTarefa("Estudar", "Estudar C#", "Curso de uma semana");
        private readonly ComandoManipuladorAdicionarTarefa _comandoManipuladorTarefaInvalida = new ComandoManipuladorAdicionarTarefa(".", "C#", "Curso de uma semana");


        public ComandoManipuladorAdicionarTarefaTeste()
        {
            _comandoManipuladorTarefaValida.Validate();
            _comandoManipuladorTarefaInvalida.Validate();
        }

        [TestMethod]
        public void Dado_Um_Comando_Valido()
        {
            Assert.AreEqual(_comandoManipuladorTarefaValida.Valid, true);
        }

        public void Dado_Um_Comando_Invalido()
        {
            Assert.AreEqual(_comandoManipuladorTarefaInvalida.Valid, false);

        }
    }
}

using Backend_Lista_Tarefa.Comandos.Tarefa;
using Backend_Lista_Tarefa.Manipuladores;
using Backend_Lista_Tarefa.Modelos;
using Backend_Lista_Tarefa.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;


namespace Backend_Lista_Tarefa_Testes.Manipulador
{
    [TestClass]

    public class ComandoManipuladorTarefaTeste
    {
        private readonly ComandoManipuladorAdicionarTarefa _comandoManipuladorTarefaValida = new ComandoManipuladorAdicionarTarefa("Estudar", "Estudar C#", "Curso de uma semana");
        private readonly ComandoManipuladorAdicionarTarefa _comandoManipuladorTarefaInvalida = new ComandoManipuladorAdicionarTarefa(".", "C#", "Curso de uma semana");
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public ComandoManipuladorTarefaTeste()
        {
            _tarefaRepositorio = new FakeRepositorioTarefa();
        }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            var _comandoManipuladorTarefa = new ComandoManipuladorTarefa(new FakeRepositorioTarefa());
            _comandoManipuladorTarefa.manipulador(_comandoManipuladorTarefaInvalida);
            Assert.AreEqual(_comandoManipuladorTarefa.Invalid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            var _comandoManipuladorTarefa = new ComandoManipuladorTarefa(new FakeRepositorioTarefa());

            _comandoManipuladorTarefa.manipulador(_comandoManipuladorTarefaValida);
            Assert.AreEqual(_comandoManipuladorTarefa.Valid, true);
        }
    }
}

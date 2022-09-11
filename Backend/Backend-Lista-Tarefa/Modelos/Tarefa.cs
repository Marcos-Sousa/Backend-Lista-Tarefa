using System;
using System.ComponentModel.DataAnnotations;

namespace Backend_Lista_Tarefa.Modelos
{
    public class Tarefa
    {
        public Tarefa()
        {

        }
        public Tarefa(string titulo, string conteudo, string lista)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Conteudo = conteudo;
            Lista = lista;
        }

        public void Atualizar(string titulo, string conteudo, string lista)
        {
            Titulo = titulo;
            Conteudo = conteudo;
            Lista = lista;
        }

        [Key]
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Conteudo { get; private set; }
        public string Lista { get; private set; }
    }
}

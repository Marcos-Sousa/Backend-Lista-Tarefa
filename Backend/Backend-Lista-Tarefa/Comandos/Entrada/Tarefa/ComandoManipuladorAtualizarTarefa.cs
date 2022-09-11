using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Backend_Lista_Tarefa.Comandos.Tarefa
{
    public class ComandoManipuladorAtualizarTarefa : Notifiable, IComandoEntrada
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Lista { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .HasMinLen(Titulo, 3, "Titulo", "O Titulo deve conter no miníno 3 carecteres!")
                    .HasMaxLen(Titulo, 150, "Titulo", "O Titulo deve conter no máximo 150 carecteres!")
                    .Requires()
                    .HasMinLen(Conteudo, 3, "Conteudo", "O Conteudo deve conter no miníno 3 carecteres!")
                    .HasMaxLen(Conteudo, 150, "Conteudo", "O Conteudo deve conter no máximo 150 carecteres!")
                    .Requires()
                    .HasMinLen(Lista, 3, "Lista", "A Lista deve conter no miníno 3 carecteres!")
                    .HasMaxLen(Lista, 150, "Lista", "A Lista deve conter no máximo 150 carecteres!")
            );
        }
    }
}

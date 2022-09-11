namespace Backend_Lista_Tarefa.Comandos.Login
{
    public class ComandoManipuladorAutenticar: IComandoEntrada
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}

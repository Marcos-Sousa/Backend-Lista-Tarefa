namespace Backend_Lista_Tarefa.Comandos.Saida
{
    public class ComandoSaida : IComandoSaida
    {

        public ComandoSaida()
        {

        }
        public ComandoSaida(bool sucesso, int statusCode, object data)
        {
            Sucesso = sucesso;
            StatusCode = statusCode;
            Data = data;
        }

        public bool Sucesso { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }
}

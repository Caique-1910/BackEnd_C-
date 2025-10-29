namespace Parte1
{
    public class EmailNotificador : INotificador
    {
        public void Enviar() => Console.WriteLine("Enviando e-mail : ");
    }
}
namespace Parte1
{
    public class AgenciaDeViagem
    {
        public readonly INotificador _notificador;

        public AgenciaDeViagem(INotificador notificador)
        {
            _notificador = notificador;
        }

        public void ConfirmarViagem(string Cliente, string Destino )
        {
            string Mensagem = $"Ola, {Cliente}, sua viagem com destino {Destino} esta confirmada";
        }

    }
}
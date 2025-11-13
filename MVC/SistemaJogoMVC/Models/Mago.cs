namespace SistemaJogoMVC.Models
{
    public class Mago : Personagem
    {
        public Mago() { }
        public Mago(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor) : base(nomeConstrutor, nivelConstrutor, tipoConstrutor) { }
        public override int CalcularPoder()
        {
            return Nivel * 8 + 20;
        }
    }
}
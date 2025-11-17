namespace SistemaJogoMVC.Models
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() { }
        public Guerreiro(string nomeConstrutor, int nivelConstrutor, string tipoConstrutor) : base(nomeConstrutor, nivelConstrutor,tipoConstrutor) { }
        public override int CalcularPoder()
        {
            return Nivel * 10;
        }

    }
}
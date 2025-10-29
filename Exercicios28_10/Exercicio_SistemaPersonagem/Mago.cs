namespace Exercicio_SistemaPersonagem
{
    public class Mago : Personagem
    {
        public override int CalcularPoder() => Nivel * 8 + 20;
    }
}
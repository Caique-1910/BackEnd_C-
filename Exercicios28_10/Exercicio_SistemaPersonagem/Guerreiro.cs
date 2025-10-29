namespace Exercicio_SistemaPersonagem
{
    public class Guerreiro : Personagem
    {
        public override int CalcularPoder() => Nivel * 10;

    }
}
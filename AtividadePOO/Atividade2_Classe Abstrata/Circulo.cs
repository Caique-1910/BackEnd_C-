namespace Atividade2_Classe_Abstrata
{
    public class Circulo : Forma
    {
        public double Raio;
        public override double CalcularArea() => Math.PI * Raio * Raio;
    }
}
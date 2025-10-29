namespace Parte1
{
    public class Aviao : Transporte
    {
        public override double CalcularTempoViagem(double distancia) => distancia / 800;
    }
}
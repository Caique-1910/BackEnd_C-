namespace Parte1
{
    public class Onibus : Transporte
    {
        public override double CalcularTempoViagem(double distancia) => distancia / 60;  
    }
}
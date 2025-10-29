namespace Parte1
{
    public abstract class Transporte
    {
        public abstract double CalcularTempoViagem(double distancia);
        public string IniciarViagem() => "Viagem iniciada...";

    }
}
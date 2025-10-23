namespace InversaoDependencias_D
{
    public class Lampada : IDispositivo
    {
        public void Ligar() => Console.WriteLine("Lampada ligada!");
    }
}
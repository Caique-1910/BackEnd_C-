namespace InversaoDependencias_D;

class Program
{
    static void Main(string[] args)
    {
        IDispositivo lampada = new Lampada();
        ArCondicionado ar = new ArCondicionado();

        Interruptor interruptor = new Interruptor(lampada);
        Interruptor interruptor2 = new Interruptor(ar);

        interruptor.Acionar();
        interruptor2.Acionar();
        
    }
}

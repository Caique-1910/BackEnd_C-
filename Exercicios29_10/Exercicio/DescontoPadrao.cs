namespace Parte1
{
    public class DescontoPadrao : DescontoViagem
    {
        public override double CalcularDesconto(double valor) => valor * 0.05;
    }
}
namespace Parte1
{
    public class DescontoFidelidade : DescontoViagem
    {
     public override double CalcularDesconto(double valor) => valor * 0.10;

    }
}
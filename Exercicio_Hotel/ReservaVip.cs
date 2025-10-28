namespace Exercicio_Hotel
{
    public class ReservaVip : Reserva
    {
        public double Desconto { get; set; }

        public new double CalcularTotal()
        {
            double totalSemDesconto = base.CalcularTotal();
            double valorDesconto = (Desconto / 100) * totalSemDesconto;
            return totalSemDesconto - valorDesconto;
        }
    }
}
namespace Exercicio_Hotel
{
public class ReservaVip : Reserva
    {
        public double Desconto { get; set; }

        public double CalcularTotal()
        {
            double valorConvertido = (double)Dias;
            double totalSemDesconto = quarto.precoDiaria * valorConvertido;
            double valorDesconto = totalSemDesconto * (Desconto / 100);
            return totalSemDesconto - valorDesconto;
        }
    }
}
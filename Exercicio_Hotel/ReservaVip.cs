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

        public void ResumoReserva()
        {
            Console.WriteLine("Resumo da Reserva VIP:");
            hospede.ExibirInformacoes();
            quarto.ExibirDetalhes();
            Console.WriteLine($"Valor total antes do desconto: {base.CalcularTotal()}");
            Console.WriteLine($"Desconto aplicado: {Desconto}%");
            Console.WriteLine($"Valor total com desconto: {CalcularTotal()}");
        }
    }
}
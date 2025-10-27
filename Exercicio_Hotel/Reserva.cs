namespace Exercicio_Hotel
{
    public class Reserva
    {
        public Quarto quarto;
        public Hospede hospede;
        public double Dias;

        public double CalcularTotal()
        {
            double valorConvertido = (double)Dias;
            return quarto.precoDiaria * valorConvertido;
        }

        public void ResumoReserva()
        {
            Console.WriteLine("Resumo da Reserva:");
            hospede.ExibirInformacoes();
            quarto.ExibirDetalhes();
            Console.WriteLine($"Dias de Estadia: {Dias}");
            Console.WriteLine($"Total a Pagar: {CalcularTotal()}");
        }
        
    }
}
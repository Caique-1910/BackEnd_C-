namespace Exercicio_Hotel;

class Program
{
    static void Main(string[] args)
    {
        Quarto quar = new Quarto(101, "Luxo", 250.0);
        Quarto quar2 = new Quarto(102, "Standard", 150.0);
        Hospede hosp = new Hospede("João Silva", "123.456.789-00", "(11) 91234-5678");
        Hospede hosp2 = new Hospede("Maria Oliveira", "987.654.321-00", "(21) 99876-5432");
        Reserva reserva = new Reserva();
        ReservaVip reservaVip = new ReservaVip();

        reserva.quarto = quar;
        reserva.hospede = hosp;
        reserva.Dias = 3;
        reservaVip.quarto = quar2;
        reservaVip.hospede = hosp2;
        reservaVip.Dias = 3;
        reservaVip.Desconto = 10.0;
        


        Console.WriteLine($"Reserva Normal de {hosp.nome}:");
        reserva.ResumoReserva();
        Console.WriteLine($"Reserva VIP de {hosp.nome  }:");
        reservaVip.ResumoReserva();
        
}
}
namespace Exercicio_Hotel;

class Program
{
    static void Main(string[] args)
    {
        Hospede hosp = new Hospede("João Silva", "123.456.789-00", "(11) 98765-4321");
        Hospede hosp2 = new Hospede("Maria Oliveira", "987.654.321-00", "(21) 91234-5678");
        Quarto quar = new Quarto(101, "Standard", 150.0);
        Quarto quar2 = new Quarto(202, "Suíte", 300.0);
        Reserva reserva = new Reserva();
        ReservaVip reservaVip = new ReservaVip();


        quar.Ocupar();
        quar2.Liberar();

        reserva.quarto = quar;
        reserva.hospede = hosp;
        reserva.Dias = 3;
        reservaVip.quarto = quar2;
        reservaVip.hospede = hosp2;
        reservaVip.Dias = 3;
        reservaVip.Desconto = 10.0;



        Console.WriteLine($"Reserva Normal de {hosp.nome}:");
        reserva.ResumoReserva();
        Console.WriteLine($"\nReserva VIP de {hosp2.nome}:");
        reservaVip.ResumoReserva();

    }
}
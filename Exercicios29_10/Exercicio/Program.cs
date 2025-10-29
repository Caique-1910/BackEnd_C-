namespace Parte1;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020, NumeroPortas = 4 };
        Moto moto = new Moto { Marca = "Honda", Modelo = "CB500", Ano = 2019, Cilindrada = 500 };
        Onibus onibus = new Onibus();
        Aviao aviao = new Aviao();

        Console.WriteLine(carro.Ligar());
        carro.Abastecer(40);
        carro.VerificarNivelCombustivel();
        Console.WriteLine(carro.ExibirDetalhes());

        Console.WriteLine("\n" + moto.Ligar());
        moto.Abastecer(15);
        moto.VerificarNivelCombustivel();
        Console.WriteLine(moto.ExibirDetalhes());

        Console.WriteLine("\n" + onibus.IniciarViagem());
        onibus.CalcularTempoViagem(300);
        Console.WriteLine($"Tempo estimado de viagem de ônibus: {onibus.CalcularTempoViagem(300)} horas");

        Console.WriteLine("\n" + aviao.IniciarViagem());
        aviao.CalcularTempoViagem(1600);
        Console.WriteLine($"Tempo estimado de viagem de avião: {aviao.CalcularTempoViagem(1600)} horas");

        RelatorioDeFrota relatorio = new RelatorioDeFrota();
        Console.WriteLine("\n" + relatorio.GerarRelatorioVeiculo(carro));

        DescontoPadrao descontoP = new DescontoPadrao();
        DescontoFidelidade descontoF = new DescontoFidelidade();

        double valor = 2000;

        Console.WriteLine("\n" + $"Valor da viagem e {valor} e com desconto padrao {descontoP.CalcularDesconto:F2}");
        Console.WriteLine("\n" + $"Valor da viagem e {valor} e com desconto fidelidade {descontoP.CalcularDesconto:F2}");

        EmailNotificador emailNotificador = new EmailNotificador();
        AgenciaDeViagem agenciaDeViagem = new AgenciaDeViagem(emailNotificador);

        agenciaDeViagem.ConfirmarViagem("Joao Cleber", "Cuiaba");

        Console.WriteLine("\n" + emailNotificador);
        Console.WriteLine("\n" + agenciaDeViagem.ConfirmarViagem);


    }
}

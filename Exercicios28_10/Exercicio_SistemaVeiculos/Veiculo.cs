namespace Exercicio_SistemaVeiculos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public abstract double CalcularRevisao();

        public string ExibirResumo() => $"Modelo: {Modelo}, Ano: {Ano}, Custo de Revisão: {CalcularRevisao():C}";
    }
}
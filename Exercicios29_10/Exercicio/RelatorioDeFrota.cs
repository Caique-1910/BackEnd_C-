namespace Parte1
{
    public class RelatorioDeFrota
    {
        public string GerarRelatorioVeiculo(Veiculo veiculo) => $"Relatório do Veículo: {veiculo.ExibirDetalhes()}";
        public string GerarRelatorioTransporte(Transporte transporte, double distancia)
        {
            double tempo = transporte.CalcularTempoViagem(distancia);
            return $"Relatório do Transporte: Tempo estimado para {distancia} km é {tempo} horas.";
        }
    }
}
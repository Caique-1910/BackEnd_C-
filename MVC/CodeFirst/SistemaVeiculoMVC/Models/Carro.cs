namespace SistemaVeiculoMVC.Models
{
    public class Carro : Veiculo
    {
        public Carro() { }
        public Carro(string modeloConstrutor, string anoConstrutor, string tipoConstrutor) : base(modeloConstrutor, anoConstrutor, tipoConstrutor) { }
        public override double CalcularRevisao()
        {
            return 500.00;
        }
    }
}
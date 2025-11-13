namespace SistemaVeiculoMVC.Models
{
    public class Moto : Veiculo
    {
        public Moto() { }
        public Moto(string modeloConstrutor, string anoConstrutor, string tipoConstrutor) : base(modeloConstrutor, anoConstrutor, tipoConstrutor) { }
        public override double CalcularRevisao()
        {
            return 300.00;
        }
    }
}
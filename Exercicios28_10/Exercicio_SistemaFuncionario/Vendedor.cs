namespace Exercicio_SistemaFuncionario
{
    public class Vendedor : Funcionario
    {
        public override double CalcularSalario() => SalarioBase * 0.20 + SalarioBase;
    }
}
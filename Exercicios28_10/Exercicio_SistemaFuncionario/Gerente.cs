namespace Exercicio_SistemaFuncionario
{
    public class Gerente : Funcionario
    {
        public override double CalcularSalario() => SalarioBase * 0.50 + SalarioBase;      
    }
}